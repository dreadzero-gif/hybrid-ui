Write-Host "Validating Hybrid UI presets..."

$presets = Get-ChildItem "../src/HybridUI.Presets" -Filter *.json

foreach ($preset in $presets) {
    try {
        $json = Get-Content $preset.FullName | ConvertFrom-Json
        Write-Host "OK: $($preset.Name)"
    }
    catch {
        Write-Host "ERROR: $($preset.Name)"
    }
}

Write-Host "Preset validation complete."
