using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SpecialDungeonStartPM
    {
        public static readonly PixelMapping StartButton = new PixelMapping
        {
            X = 664,
            Y = 495,
            Color = 5186318,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping KeyPlusBG = new PixelMapping
        {
            X = 705,
            Y = 28,
            Color = 3748123,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CardEnterButton = new PixelMapping
        {
            X = 511,
            Y = 392,
            Color = 11770259,
            Type = MappingType.BOTH
        };
    }
}