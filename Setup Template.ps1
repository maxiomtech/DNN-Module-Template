param (
    [Parameter(Mandatory=$true)]
    [string]$companyName,
	
    [Parameter(Mandatory=$true)]
    [string]$moduleName
)

if(-not($companyName) -or -not($companyName)) { 
    Throw "You must specify a companyName and a moduleName"
}


$files = Get-ChildItem $PSScriptRoot -File -Recurse -Exclude *.ps1 | Where-Object  {$_.FullName -notmatch "\\scripts\\?" }

$files | %{
    (gc $_) -replace "CompanyName", $companyName | Set-Content $_.fullname
    (gc $_) -replace "ModuleName", $moduleName | Set-Content $_.fullname
	rni -LiteralPath $_.fullname -NewName $_.name.replace("CompanyName", $companyName).replace("ModuleName", $moduleName)
}


