function WebApiProxy-Generate-CSharp() {
    $nugetPath = Join-Path $PSScriptRoot "..\"
    $projectPath = [System.IO.Path]::GetDirectoryName((Get-Project).FullName)

    $generateJob = Start-Job -ScriptBlock { 
        param($projectPath, $nugetPath)

        $buildPath = Join-Path $nugetPath "build\WebApiProxy.Tasks.dll"
        $configPath = Join-Path $projectPath "WebApiProxy\"
        $generatedPath = Join-Path $projectPath "WebApiProxy\WebApiProxy.generated.cs"

        # Attempt to set file not readonly
        sp $generatedPath IsReadOnly $false -ErrorAction SilentlyContinue
    
        # Load Tasks
        Add-Type -Path $buildPath

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
        Write-Host ( Receive-Job -Job $generateJob -Wait )
        Write-Host "Done." -ForegroundColor Green
    }
    Catch {
        Write-Host $_.Exception.Message -ForegroundColor Red
    }
} 

Export-ModuleMember "WebApiProxy-Generate-CSharp"