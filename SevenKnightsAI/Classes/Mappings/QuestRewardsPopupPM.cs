using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class QuestRewardsPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 210,
            Y = 59,
            Color = 3753280,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AragonArmDailyQuestComplete = new PixelMapping
        {
            X = 98,
            Y = 317,
            Color = 16381677,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AragonEyeDailyQuestComplete = new PixelMapping
        {
            X = 106,
            Y = 112,
            Color = 11173466,
            Type = MappingType.ANCHOR
        };
    }
}