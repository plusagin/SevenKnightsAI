using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class TowerSelectPM
    {
        public static readonly PixelMapping GoldChamberButton = new PixelMapping
        {
            X = 378,
            Y = 120,
            Color = 14467088,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping PreviewBorderLeft = new PixelMapping
        {
            X = 322,
            Y = 230,
            Color = 8154174,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PreviewBorderRight = new PixelMapping
        {
            X = 922,
            Y = 230,
            Color = 8219710,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 740,
            Y = 490,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyDisabled = new PixelMapping
        {
            X = 580,
            Y = 468,
            Color = 1970442,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GoldCount = new PixelMapping
        {
            X = 800,
            Y = 440,
            Color = 2824462,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CollectGoldBTN = new PixelMapping
        {
            X = 823,
            Y = 513,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}