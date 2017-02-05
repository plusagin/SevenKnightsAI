using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class HeroRemovePM
    {
        public static readonly PixelMapping PositionButton = new PixelMapping
        {
            X = 481,
            Y = 483,
            Color = 12420649,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RemoveAllButton = new PixelMapping
        {
            X = 596,
            Y = 484,
            Color = 8147744,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RemoveButton = new PixelMapping
        {
            X = 848,
            Y = 485,
            Color = 8542242,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RemoveButtonIcon = new PixelMapping
        {
            X = 859,
            Y = 471,
            Color = 15058003,
            Type = MappingType.ANCHOR
        };
    }
}