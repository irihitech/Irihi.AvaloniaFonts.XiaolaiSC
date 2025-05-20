using Avalonia;
using Avalonia.Media;

namespace Irihi.AvaloniaFonts.XiaolaiSC;

public static class AvaloniaAppBuilderExtensions
{
    public static AppBuilder WithXiaolaiSCFont(this AppBuilder builder)
    {
        const string uri = "avares://Irihi.AvaloniaFonts.XiaolaiSC/Assets#Xiaolai SC";
        return builder.With(new FontManagerOptions
        {
            DefaultFamilyName = uri,
            FontFallbacks = [new FontFallback { FontFamily = new FontFamily(uri) }]
        });
    }
}