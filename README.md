# Plan It
Plan It is a simple, aesthetically pleasing task-managing app that includes database functionality, privacy policy enforcement, and smooth animations. The app is designed to help users efficiently manage their tasks within different categories while ensuring their data is secure.

## Features
* Lottie Animations
* Randomly generated color-coded categories
* Collection/TaskView
* CategoryView
* Detailed Task View with update/cancel/delete
* MVVM architecture
* Borders

## Privacy Policy
* Introduction
* Information We Collect
* How We Use Information
* Disclosure of Information
* Security of Information
* Protection of Data Rights
* Changes to Privacy Policy
* Contact Us

## NuGet Packages
This project uses the following NuGet packages:

* [CommunityToolkit.Maui](https://www.nuget.org/packages/CommunityToolkit.Maui) - Version 7.0.1
* [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm) - Version 8.2.2
* [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json) - Version 13.0.3
* [SkiaSharp](https://www.nuget.org/packages/SkiaSharp) - Version 2.88.7
* [SkiaSharp.Extended.UI.Maui](https://www.nuget.org/packages/SkiaSharp.Extended.UI.Maui) - Version 2.0.0-preview.86
* [Microsoft.Maui.Controls](https://www.nuget.org/packages/Microsoft.Maui.Controls) - Version 8.0.7
* [Microsoft.Maui.Controls.Compatibility](https://www.nuget.org/packages/Microsoft.Maui.Controls.Compatibility) - Version 8.0.7
* [Microsoft.EntityFrameworkCore.Sqlite](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite) - Version 8.0.2
* [sqlite-net-pcl](https://www.nuget.org/packages/sqlite-net-pcl) - Version 1.8.116

## Project Dependencies
This project targets the following platforms:

* .NET 8.0 Android
* .NET 8.0 iOS
* .NET 8.0 MacCatalyst
* .NET 8.0 Windows (Minimum version: 10.0.17763.0)

Other important dependencies:

* **MSBuild** - Used for build configurations and target platform-specific properties.
* **AOT Compilation (Android)** - Applied for release builds to optimize performance.
* **Multi-Dex (Android)** - Enabled for better handling of large method counts.

## Installation
To get started with this project, clone the repository, open solution and restore NuGet Packages
