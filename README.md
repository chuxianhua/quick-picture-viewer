<p align="center">
  <img src="/quick-picture-viewer/resources/imgs/picture96.png">
</p>
<h1 align="center">Quick Picture Viewer</h1>

<p align="center">
  Quick Picture Viewer is a lightweight, versatile desktop image viewer for Windows.<br>The best replacement for the default Windows photo viewer.
</p>

<p align="center">
  <a href="https://github.com/ModuleArt/quick-picture-viewer/releases">
    <img alt="GitHub release (latest by date including pre-releases)" src="https://img.shields.io/github/v/release/moduleart/quick-picture-viewer?include_prereleases">
    <img alt="GitHub All Releases" src="https://img.shields.io/github/downloads/ModuleArt/quick-picture-viewer/total">
  </a>
  <a href="https://moduleart.github.io">
    <img alt="Module Art website" src="https://img.shields.io/badge/www-moduleart-%2300BCD4">
  </a>
  <a alt="Trello roadmap" href="https://trello.com/b/mFgTs747/quick-picture-viewer">
    <img src="https://img.shields.io/badge/planner-trello-%230079BF" />
  </a>
</p>

<p align="center">	
  <a href="https://moduleart.github.io/quick-picture-viewer">
    <img src="/docs/screenshots/main.png">
  </a>
</p>

<h2 align="center">Install</h2>

| Windows | Version | Codename | Release date | Size | Downloads | Installer |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| 7-10 | <a href="https://github.com/ModuleArt/quick-picture-viewer/releases/tag/v2.2.6">v2.2.6</a> (Stable) | Community | Nov 4, 2020 | 3.8 MB | ![GitHub Releases (by Release)](https://img.shields.io/github/downloads/ModuleArt/quick-picture-viewer/v2.2.6/total?label=latest%40v2.2.6) | <a href="https://github.com/ModuleArt/quick-picture-viewer/releases/download/v2.2.6/QuickPictureViewer-Setup.exe">Download (.exe)</a> |
| 7-10 | v3.0.2 (Beta 3) | Sunshine | Feb 1, 2021 | 3.7 MB | - | <a href="https://github.com/ModuleArt/quick-picture-viewer/raw/master/inno-setup/beta/v3.0.2-beta3.exe">Download (.exe)</a> |

<h2 align="center">Features</h2>

* Supported image formats: .png, .jpg, .jpeg, .jpe, .jfif, .exif, .gif, .bmp, .dib, .rle, .tiff, .tif
* Supported other file types: .ico, .webp, .svg, .dds, .tga, .psd
* Basic image editing: rotate, flip, change file type
* Built-in plugins: Blur region, Screenshot 
* Open image with external app or show in file explorer
* Picture in picture mode
* Copy, paste to clipboard
* Checkerboard background
* Window can be always on top, borderless and fullscreen
* Set image as desktop background
* Print image or export to PDF
* View image details
* Slideshow
* Dark mode

<h2 align="center">Other great apps</h2>

| | App | Last commit | Last release | Description |
| :---: | :---: | :---: | :---: | :---: |
| <img src="https://github.com/ModuleArt/quick-whiteboard/blob/master/quick-whiteboard/resources/imgs/whiteboard64.png?raw=true"/> | <a href="https://github.com/ModuleArt/quick-whiteboard/">Quick Whiteboard</a> | ![GitHub last commit](https://img.shields.io/github/last-commit/ModuleArt/quick-whiteboard) | ![GitHub Release Date](https://img.shields.io/github/release-date/ModuleArt/quick-whiteboard) | Lightweight tool to draw or keep notes on your desktop background for Windows. |
| <img src="https://github.com/ModuleArt/quick-color-picker/blob/master/quick-color-picker/resources/imgs/picker64.png?raw=true"/> | <a href="https://github.com/ModuleArt/quick-color-picker/">Quick Color Picker</a> | ![GitHub last commit](https://img.shields.io/github/last-commit/moduleart/quick-color-picker) | ![GitHub Release Date](https://img.shields.io/github/release-date/ModuleArt/quick-color-picker) | Lightweight desktop color picker and color editor utility for Windows, built on top of WinForms (C#). |
 
<h2 align="center">More screenshots</h2>
<p align="center">
  <img src="/docs/screenshots/svg.png">
  <br><br>
  <img src="/docs/screenshots/checkerboard.png">
  <br><br>
  <img src="/docs/screenshots/info.png">
</p>

<hr>

### Built-in plugins:

| Plugin | Codename | Last commit date | Last release date | Download (.zip) |
| :---: | :---: | :---: | :---: | :---: |
| <a href="https://github.com/ModuleArt/qpv-plugins#blur">Blur region</a> | blur | ![GitHub last commit](https://img.shields.io/github/last-commit/ModuleArt/qpv-plugins) | ![GitHub Release Date](https://img.shields.io/github/release-date/ModuleArt/qpv-plugins) | <a href="https://github.com/ModuleArt/qpv-plugins/releases/">Releases</a> |
| <a href="https://github.com/ModuleArt/qpv-plugins#screenshot">Screenshot</a> | screenshot | ![GitHub last commit](https://img.shields.io/github/last-commit/ModuleArt/qpv-plugins) | ![GitHub Release Date](https://img.shields.io/github/release-date/ModuleArt/qpv-plugins) | <a href="https://github.com/ModuleArt/qpv-plugins/releases/">Releases</a> |

### Contribution:

Help Module Art!

* Give us a star ⭐
* Fork and Clone! Awesome
* Select existing <a href="https://github.com/ModuleArt/quick-picture-viewer/issues">issues</a> or create a <a href="https://github.com/ModuleArt/quick-picture-viewer/issues/new">new issue</a> and give us a PR with your bugfix or improvement after. We love it ❤


### How to uninstall built-in photos app in Windows 10:
<a href="https://www.howtogeek.com/224798/how-to-uninstall-windows-10s-built-in-apps-and-how-to-reinstall-them/">Guide</a><br>
Powershell (Admin):

```powershell
Get-AppxPackage *photos* | Remove-AppxPackage
```

### Extension module for Windows Explorer to render SVG thumbnails:
<a href="https://github.com/tibold/svg-explorer-extension/">Guide</a>
