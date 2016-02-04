param(

    [Parameter(Mandatory=$true)]
    [string]$OutputDirectory,
    
    [Parameter(Mandatory=$true)]
    [string]$BuildSourceDirectory,
    
    [Parameter(Mandatory=$true)]
    [string]$BuildConfiguration,
    
    [Parameter(Mandatory=$true)]
    [string]$BuildNumber,

    [string]$NuGetExe,

    [string]$Version,

    [string]$PreVersion

)

# discover version from build number
if ([string]::IsNullOrWhiteSpace($Version))
{
    # get and validate the version data
    $VersionData = [regex]::Matches($BuildNumber, "\d+\.\d+\.\d+\.\d+")

    switch($VersionData.Count)
    {
        0        
            { 
                Write-Error "Could not find version number data in BUILD_BUILDNUMBER."
                exit 1
            }
        1 {}
        default 
            { 
                Write-Warning "Found more than instance of version data in BUILD_BUILDNUMBER." 
                Write-Warning "Will assume first instance is version."
            }
    }
    $Version = $VersionData[0]
}

# append any prerelease version string
if (![string]::IsNullOrWhiteSpace($PreVersion))
{
    $Version = $Version + "-" + $PreVersion
}

# output version
Write-Host "Version: $Version"

if ($OutputDirectory -and !(Test-Path $OutputDirectory))
{
    Write-Host "Output directory used but doesn't exists, creating it"
    New-Item $OutputDirectory -type directory
}

# search for nuspec files
$NuSpecFiles = Get-Item **\*.nuspec

# display found files
Write-Host "Found nuspec files: $($NuSpecFiles.Count)"
foreach ($NuSpecFile in $NuSpecFiles)
{
    Write-Host "--File: `"$NuSpecFile`""
}

# discover location of NuGet.exe from agent if not specified
if ([string]::IsNullOrWhiteSpace($NuGetExe))
{
    $NuGetExe = "$($env:AGENT_HOMEDIRECTORY)\agent\Worker\tools\NuGet.exe"
}

# test nuget
if (!(Test-Path $NuGetExe))
{
    Write-Error "Could not locate NuGet.exe"
    exit 1
}

# run packaging
foreach ($i in $NuSpecFiles)
{
    $f = [System.IO.Path]::ChangeExtension($i.FullName, ".csproj")
    if (Test-Path $f)
    {
	    & $NuGetExe pack -OutputDirectory `"$OutputDirectory`" -Version `"$Version`" -Prop Configuration=$BuildConfiguration `"$f`"
    }
}
