Write-Host "Validating Hybrid UI assets..."

$paths = @(
    "../assets/icons",
    "../assets/gauges",
    "../assets/textures",
    "../assets/themes"
)

foreach ($p in $paths) {
    if (!(Test-Path $p)) {
        Write-Host "Missing: $p"
    } else {
        Write-Host "OK: $p"
    }
}

Write-Host "Asset validation complete."
