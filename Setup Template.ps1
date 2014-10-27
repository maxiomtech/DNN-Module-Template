param (
    [Parameter(Mandatory=$true)]
    [string]$projectName,
    [Parameter(Mandatory=$true)]
    [string]$moduleName
)

if(-not($projectName) -or -not($moduleName)) { 
    Throw "You must specify a projectName and a moduleName"
}


$fileName = Get-ChildItem $PSScriptRoot -Recurse -Exclude *.ps1 | Where-Object  {$_.FullName -notmatch "\\scripts\\?" }

$filename | %{
    (gc $_) -replace "InspectorIT", $projectName |Set-Content $_.fullname
    (gc $_) -replace "moduleName", $moduleName |Set-Content $_.fullname
}




