$ErrorActionPreference = 'Stop'
$toolsDir = "$(Split-Path -parent $MyInvocation.MyCommand.Definition)"
. "$toolsDir\Install-VsCodeExtension.ps1"

$packageArgs = @{
  packageName   = $env:ChocolateyPackageName
  extensionPath = "$toolsDir\gitpitch-vscode.vsix"
}

Install-VsCodeExtension @packageArgs
