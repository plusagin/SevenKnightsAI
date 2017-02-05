using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class QuestPM
    {
        public static readonly PixelMapping AragonTop = new PixelMapping
        {
            X = 120,
            Y = 100,
            Color = 15907986,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AragonMiddle = new PixelMapping
        {
            X = 126,
            Y = 320,
            Color = 8553097,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AragonBot = new PixelMapping
        {
            X = 153,
            Y = 198,
            Color = 2951949,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AragonQuestBtn = new PixelMapping
        {
            X = 655,
            Y = 480,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AragonOkBtn = new PixelMapping
        {
            X = 836,
            Y = 480,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping BattleAvailable = new PixelMapping
        {
            X = 329,
            Y = 58,
            Color = 13052161,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BattleTab = new PixelMapping
        {
            X = 402,
            Y = 92,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CollectAllButton = new PixelMapping
        {
            X = 838,
            Y = 510,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CollectAllButtonBackground = new PixelMapping
        {
            X = 838,
            Y = 522,
            Color = 16771074,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CollectButton = new PixelMapping
        {
            X = 863,
            Y = 184,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CollectButtonBackground = new PixelMapping
        {
            X = 863,
            Y = 197,
            Color = 16771330,
            Type = MappingType.ANCHOR
        };

        public static readonly int GOLD_OFFSET_X = 277;

        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly PixelMapping HeroAvailable = new PixelMapping
        {
            X = 488,
            Y = 58,
            Color = 13052161,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping HeroTab = new PixelMapping
        {
            X = 563,
            Y = 92,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int HONOR_OFFSET_X = 279;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping ItemAvailable = new PixelMapping
        {
            X = 648,
            Y = 58,
            Color = 12986369,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ItemTab = new PixelMapping
        {
            X = 718,
            Y = 92,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int KEY_OFFSET_X = 274;

        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly int RUBY_OFFSET_X = 276;

        public static readonly int RUBY_OFFSET_Y = 0;

        public static readonly PixelMapping SocialAvailable = new PixelMapping
        {
            X = 808,
            Y = 57,
            Color = 13249026,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SocialTab = new PixelMapping
        {
            X = 878,
            Y = 92,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}