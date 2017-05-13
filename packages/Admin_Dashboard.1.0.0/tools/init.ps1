param($installPath, $toolsPath, $package, $project)

$filesToCopy = "$($installPath)\content"

Write-Host "Copying elements folder to the root of the project: " $project.Name

$final_local_end = "$((get-location).path)\$($project.Name)"
Write-Host $final_local_end

Copy-Item -Path $filesToCopy -Destination $final_local_end -recurse -Force

Remove-Item $filesToCopy -recurse -Force

$projectItems = Get-Interface $project.ProjectItems ([EnvDTE.ProjectItems])
$projectItems.AddFromFile("$final_local_end\Content")
$projectItems.AddFromFile("$final_local_end\fonts")
$projectItems.AddFromFile("$final_local_end\img")
$projectItems.AddFromFile("$final_local_end\scripts")
$projectItems.AddFromFile("$final_local_end\Views")
