# Installation

Hybrid UI can be installed as a Blish HUD module or integrated into a custom addon.

## Blish HUD Installation
1. Download the latest `.bhm` release.
2. Place it in:
3. Launch Blish HUD.
4. Enable **Hybrid UI** in the module list.

## Addon Integration
1. Add the `HybridUI.*` folders to your project.
2. Reference the core assembly.
3. Initialize the framework:
```csharp
HybridUI.Initialize();

