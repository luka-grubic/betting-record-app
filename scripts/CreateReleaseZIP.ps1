if ($args.Count -gt 0)
{
    $_version = $args[0]; 
    $Output = "../releases/BettingRecordApp-v{0}.zip" -f $_version

    $Files = "../README.md", 
                "../CHANGELOG.md", 
                "../templates/", 
                "../BettingRecordApp/bin/Release/BettingRecordApp.exe"

    Compress-Archive -Path $Files -DestinationPath $Output
}
else 
{
    Write-Host "VERSION NOT PROVIDED AS ARGUMENT!";
}
