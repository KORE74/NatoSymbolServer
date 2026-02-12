using System.Collections;
using SkiaSharp;

namespace KorePlotter.NatoSymbol;

// KoreNatoSymbolDrawOps: Static methods to draw specific shapes for NATO symbols.
// - Functions passed the canvas and the necessary parameters to draw the shape.
// - Static class for utility functions, holds no state.

public static partial class KoreNatoSymbolDrawOps
{
    // Usage: KoreNatoSymbolDrawOps.DrawIcon(canvas, NatoPlatformFunction.Military);
    public static void DrawModifier(KoreNatoSymbolCanvas canvas, int position, NatoPlatformModifier modifier)
    {
    }

    // --------------------------------------------------------------------------------------------
    // MARK: RECT
    // --------------------------------------------------------------------------------------------

    public static SKRect Modifier1BoundsRect(KoreNatoSymbolCanvas canvas)
    {
        float padding = canvas.LDistance * 0.01f; // 10% padding
        return new SKRect(
            canvas.Center.X - (canvas.LDistance * 0.5f) + padding,
            canvas.Center.Y - (canvas.LDistance * 0.5f) + padding,
            canvas.Center.X + (canvas.LDistance * 0.5f) - padding,
            canvas.Center.Y - (canvas.LDistance * 0.2f) - padding
        );
    }

    public static SKRect Modifier2BoundsRect(KoreNatoSymbolCanvas canvas)
    {
        float padding = canvas.LDistance * 0.01f; // 10% padding
        return new SKRect(
            canvas.Center.X - (canvas.LDistance * 0.5f) + padding,
            canvas.Center.Y + (canvas.LDistance * 0.2f) + padding,
            canvas.Center.X + (canvas.LDistance * 0.5f) - padding,
            canvas.Center.Y + (canvas.LDistance * 0.5f) - padding
        );
    }

    // --------------------------------------------------------------------------------------------
    // MARK: Text Icons
    // --------------------------------------------------------------------------------------------

}
