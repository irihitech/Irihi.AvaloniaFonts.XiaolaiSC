# Irihi.Avalonia.Fonts.XiaolaiSC

Xiaolai Fonts for Avalonia

# How to Use

## Installation

```bash
dotnet add package Irihi.Avalonia.Fonts.XiaolaiSC
```

or

```bash
dotnet add package Irihi.Avalonia.Fonts.XiaolaiMonoSC
```

Include Xiaolai Fonts in Program.cs:

```csharp
public static AppBuilder BuildAvaloniaApp()
    => AppBuilder.Configure<App>()
        .UsePlatformDetect()
        .WithXiaolaiSCFont()
        //.WithXiaolaiMonoSCFont()
```