using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidEndPM
    {
        public static readonly PixelMapping AgainButton = new PixelMapping
        {
            X = 898,
            Y = 224,
            Color = 10253093,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping GetStrongerButton = new PixelMapping
        {
            X = 894,
            Y = 128,
            Color = 15455338,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping LobbyButton = new PixelMapping
        {
            X = 894,
            Y = 463,
            Color = 7688206,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RaidButton = new PixelMapping
        {
            X = 897,
            Y = 364,
            Color = 13939542,
            Type = MappingType.BOTH
        };
    }
}