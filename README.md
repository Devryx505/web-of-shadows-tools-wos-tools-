# Spider-Man: Web of Shadows — PCPACK Tools Setup & Update Guide

<p align="center">
  <img src="https://github.com/Hexworksofficial/web-of-shadows-tools-wos-tools-/blob/203d9563368ed9330e7e9d6ab2f6c009eb432052/Web_of_shadows_boxart.jpg" alt="Spider-Man Web of Shadows Boxart" width="400"/>
</p>

---

### Overview
WOS Toolkit is the ultimate all-in-one modding suite for Spider‑Man: Web of Shadows. It features a user‑friendly graphical interface designed to eliminate the need for command‑line utilities. From swapping complex animation tracks and adjusting material properties to extracting multi-platform archives, this toolkit gives you everything needed to build, test, and package custom mods.

> Note: Includes full Drag & Drop support across modules! Just drop your game files directly into the UI to get started.

---

## Setup & Installation

* Supported OS: Windows 7, 8, 10, 11 (Experimental support via Wine/Proton for Linux/macOS)
* Portability: The toolkit components are 100% portable. No deep system installer required!

1. Download the latest compilation from the Releases page.
2. Extract the archive into a dedicated directory (e.g., C:\WOS_Toolkit\).
3. Open your toolkit folder to launch your desired application:
   * Run **WOSToolkit.exe** to open the main asset editor suite.
   * Run **WOSModManager.exe** to launch the separated mod manager executable.

---

## Feature Breakdown

<details>
<summary>Web of Shadows Mod Manager (Separated EXE)</summary>

* Runs as a completely independent executable file within the toolkit directory.
* Manages mod load orders and actively checks for data conflicts between active packages.
* Provides a centralized graphical manager to install, configure, toggle, or remove game modifications cleanly.
</details>

<details>
<summary>Pack Extractor & Ingestion Suite (PC, Xbox 360, PS3)</summary>

* Extract and read .pack and .pcapk archives fully.
* Multi-Platform Support: Fully supports Xbox 360 extraction; currently processes PC and PS3 pcpack components.
* Includes an integrated File Browser to preview or isolate individual file paths within compressed game archives.
</details>

<details>
<summary>Material & Quick Color Editor</summary>

* Native editor for .mat material binary profiles.
* Quick Color Editor: Instantly modify Vector4 color and floating-point parameters via clean, live UI sliders.
* Edit blending flags and engine render configurations via absolute integer values.
* Real-time hexadecimal modification preview arrays with automated source path backups before saving commits.
</details>

<details>
<summary>Texture Viewer & Batch Workshop</summary>

* Interactive image canvas reading textures directly out of .pcapk blocks (supports DXT1, DXT3, DXT5, and ATI2 compression formats).
* Full viewport canvas support: pan, zoom, and borderless fullscreen toggle.
* Texture Batch Tool: Decompress .wrap.tex formats straight into structural .dds standard textures for editing in external image software.
* Repack Module: Ingest your edited .dds assets back into native .wrap.tex engine structures via pre-calculated templates.
* Xbox 360 Textures: Fully extract and repack Xbox 360 formatted texture structures with original asset security rules.
</details>

<details>
<summary>Animation Swap</summary>

* Hot-swap core character animations directly (e.g., combat loops, swing velocities, traversal, or idle sequences).
* Pre-loaded data reference bank tracking over 30 verified Spider-Man animation nodes (covering Red/Blue and Symbiote suits).
* Double-click any listed asset tracking name to copy its internal engine identification string instantly.
* Single-click swapping logic with automated source fallback caching.
</details>

<details>
<summary>Sound Editor (WIP)</summary>

* Work In Progress Module
* Structural architecture being engineered to handle audio streams, voice lines, and sound effects within file packages.
</details>

<details>
<summary>3D Model Viewer</summary>

* Deep model workspace viewport optimized via real-time OpenGL rendering.
* Free-cam navigation layout utilizing standard WASD controls paired with mouse tracking look.
* Toggleable viewing modes: structural wireframe, coordinate bounding boxes, normal orientations, vertex colors, and alpha transparencies.
* Dynamic asset adjustments: map test textures or alter basic mesh colors on the fly before exporting components via standard .obj files.
</details>

<details>
<summary>Integrated Utilities</summary>

* ENT Editor: Early-stage parsing engine for internal entity definitions.
* Hex Viewer: Low-level hexadecimal array editor complete with string searches, jump-to-offset indicators, and live edit synchronization over raw ASCII spaces.
</details>

---

## WOS TOOLS TEAM

This project is a collaborative effort by a team of dedicated developers and reverse engineers. Check out the other projects in our ecosystem:

* Devryx (Owner/Main Suite Developer) — [GitHub Profile](https://github.com/Devryx)
* Kirbystealer — Reverse Engineer, Developer, and CEO of ExWOS. — [Explore Kirbystealer's Tools](https://github.com/kirbystealer)
* UndeadFrankie — Reverse Engineer, Developer, and CEO of DR2 Tool. — [Explore UndeadFrankie's Tools](https://github.com/UndeadFrankie)

Without this beautiful team, everything would be much harder! <3

***

### Special Thanks
A massive thank you goes out to the entire Spider‑Man: Web of Shadows modding community for providing constant research support, telemetry details, and the creative inspiration needed to keep developing these open-source tools.

<p align="center">
  <img src="https://github.com/Hexworksofficial/web-of-shadows-tools-wos-tools-/blob/1a2708b3ffaff74ca527734a727ac1783b271c17/xr0rv7h2qcm51.jpg" alt="WOS Modding Scene" width="600"/>
</p>

Enjoy WOS modders, have fun extracting!
