param (
    [Parameter(Mandatory=$true)]
    [string]$companyName,
    [Parameter(Mandatory=$true)]
    [string]$moduleName
)

if(-not($companyName) -or -not($companyName)) { 
    Throw "You must specify a companyName and a moduleName"
}


$fileName = Get-ChildItem $PSScriptRoot -Recurse -Exclude *.ps1 | Where-Object  {$_.FullName -notmatch "\\scripts\\?" }

$filename | %{
    (gc $_) -replace "companyName", $companyName |Set-Content $_.fullname
    (gc $_) -replace "moduleName", $moduleName |Set-Content $_.fullname
}




