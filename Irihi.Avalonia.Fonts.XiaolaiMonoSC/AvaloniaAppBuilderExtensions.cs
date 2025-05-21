using Avalonia;
using Avalonia.Media;

namespace Irihi.Avalonia.Fonts.XiaolaiMonoSC;

public static class AvaloniaAppBuilderExtensions
{
    public static AppBuilder WithXiaolaiMonoSCFont(this AppBuilder builder)
    {
        const string uri = "avares://Irihi.Avalonia.Fonts.XiaolaiMonoSC/Assets#Xiaolai Mono SC";
        return builder.With(new FontManagerOptions
        {
            DefaultFamilyName = uri,
            FontFallbacks = [new FontFallback { FontFamily = new FontFamily(uri) }]
        });
    }
}