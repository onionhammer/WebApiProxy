function WebApiProxy-Generate-CSharp() {
    $nugetPath   = Join-Path $PSScriptRoot "..\"
    $projectPath = [System.IO.Path]::GetDirectoryName((Get-Project).FullName)

    $generateJob = Start-Job -ScriptBlock { 
        param($projectPath, $nugetPath)

        $tasksPath     = Join-Path $nugetPath "build\WebApiProxy.Tasks.dll"
        $configPath    = Join-Path $projectPath "WebApiProxy\"
        $generatedPath = Join-Path $projectPath "WebApiProxy\WebApiProxy.generated.cs"

        # Attempt to set file not readonly
        sp $generatedPath IsReadOnly $false -ErrorAction SilentlyContinue
    
        # Load Tasks
        Add-Type -Path $tasksPath
		
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
	 
	$output = Receive-Job -Job $generateJob -Wait

    if ($generateJob.State -eq 'Failed') {
        Write-Host $output -ForegroundColor Red
    }
    else {
        Write-Host "Done." -ForegroundColor Green
    }
} 

Export-ModuleMember "WebApiProxy-Generate-CSharp"