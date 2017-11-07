using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidRewardPM
    {
        public static readonly PixelMapping MemberListBackground = new PixelMapping
        {
            X = 30,
            Y = 66,
            Color = 10191710,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardButton = new PixelMapping
        {
            X = 825,
            Y = 421,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RewardButtonBackground = new PixelMapping
        {
            X = 825,
            Y = 421,
            Color = 15118851,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardButtonRedIcon = new PixelMapping
        {
            X = 757,
            Y = 398,
            Color = 12854534,
            Type = MappingType.ANCHOR
        };
    }
}