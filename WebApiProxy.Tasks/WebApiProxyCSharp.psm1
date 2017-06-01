function WebApiProxy-Generate-CSharp() {
    $nugetPath   = Join-Path $PSScriptRoot "..\"
    $projectPath = [System.IO.Path]::GetDirectoryName((Get-Project).FullName)

    $generateJob = Start-Job -ScriptBlock { 
        param($projectPath, $nugetPath)

		$jsonPath      = Join-Path $nugetPath "build\Newtonsoft.Json.dll"
        $tasksPath     = Join-Path $nugetPath "build\WebApiProxy.Tasks.dll"
        $configPath    = Join-Path $projectPath "WebApiProxy\"
        $generatedPath = Join-Path $projectPath "WebApiProxy\WebApiProxy.generated.cs"

        # Attempt to set file not readonly
        sp $generatedPath IsReadOnly $false -ErrorAction SilentlyContinue
    
        # Load Tasks
		$newtonsoftJson = [System.Reflection.Assembly]::LoadFile($jsonPath)
        Add-Type -Path $tasksPath
		
		# Set up DLL path resolver
		[System.AppDomain]::CurrentDomain.add_AssemblyResolve([System.ResolveEventHandler] {
			param($sender, $e)

			if ($e.Name -like "Newtonsoft.Json*") { return $newtonsoftJson }

			foreach($a in [System.AppDomain]::CurrentDomain.GetAssemblies()) {
				if ($a.FullName -eq $e.Name) { return $a }
			}

			return $null
		})

        # Load configuration
        $config    = [WebApiProxy.Tasks.Models.Configuration]::Load($configPath);
        $generator = New-Object WebApiProxy.Tasks.Infrastructure.CSharpGenerator -ArgumentList @($config)
	
        # Generate code
        Write-Host "Generating WebApiProxy code..."
	
        $source = $generator.Generate()

        # Copy content into file
        $discard = New-Item $generatedPath `
            -ItemType "file" -Force `
            -Value $source
    
    } -ArgumentList @($projectPath, $nugetPath)
	 
    Try {
		$output = Receive-Job -Job $generateJob -Wait -ErrorAction Stop

        Write-Host $output
        Write-Host "Done." -ForegroundColor Green
    }
    Catch {
        Write-Host $_.Exception.Message -ForegroundColor Red
    }
} 

Export-ModuleMember "WebApiProxy-Generate-CSharp"