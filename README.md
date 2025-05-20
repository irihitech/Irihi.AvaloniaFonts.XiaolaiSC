# Irihi.AvaloniaFonts.XiaolaiSC

Xiaolai Fonts for Avalonia

# How to Use

## Installation

```bash
dotnet add package Irihi.AvaloniaFonts.XiaolaiSC
```

or

```bash
dotnet add package Irihi.AvaloniaFonts.XiaolaiMonoSC
```

Include Xiaolai Fonts in Program.cs:

```csharp
public static AppBuilder BuildAvaloniaApp()
    => AppBuilder.Configure<App>()
        .UsePlatformDetect()
        .WithXiaolaiSCFont()
        //.WithXiaolaiMonoSCFont()
```