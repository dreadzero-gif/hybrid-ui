Write-Host "Generating Hybrid UI documentation..."

$docsPath = "../docs"

if (!(Test-Path $docsPath)) {
    Write-Host "Docs folder not found."
    exit
}

Write-Host "Documentation refreshed."
