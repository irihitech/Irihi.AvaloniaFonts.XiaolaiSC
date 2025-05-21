using Avalonia;
using Avalonia.Media;

namespace Irihi.Avalonia.Fonts.XiaolaiSC;

public static class AvaloniaAppBuilderExtensions
{
    public static AppBuilder WithXiaolaiSCFont(this AppBuilder builder)
    {
        const string uri = "avares://Irihi.Avalonia.Fonts.XiaolaiSC/Assets#Xiaolai SC";
        return builder.With(new FontManagerOptions
        {
            DefaultFamilyName = uri,
            FontFallbacks = [new FontFallback { FontFamily = new FontFamily(uri) }]
        });
    }
}