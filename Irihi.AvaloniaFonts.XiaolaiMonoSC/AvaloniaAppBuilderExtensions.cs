using Avalonia;
using Avalonia.Media;

namespace Irihi.AvaloniaFonts.XiaolaiMonoSC;

public static class AvaloniaAppBuilderExtensions
{
    public static AppBuilder WithXiaolaiSCFont(this AppBuilder builder)
    {
        const string uri = "avares://Irihi.AvaloniaFonts.XiaolaiMonoSC/Assets#Xiaolai Mono SC";
        return builder.With(new FontManagerOptions
        {
            DefaultFamilyName = uri,
            FontFallbacks = [new FontFallback { FontFamily = new FontFamily(uri) }]
        });
    }
}