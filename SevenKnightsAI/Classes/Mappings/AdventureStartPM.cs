using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureStartPM
    {
        #region Public Fields

        public static readonly int GOLD_OFFSET_X = 514;
        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly int KEY_OFFSET_X = 357;
        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping KeyPlusButton = new PixelMapping
        {
            X = 492,
            Y = 28,
            Color = 12690529,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LevelSortBorder = new PixelMapping
        {
            X = 734,
            Y = 76,
            Color = 4006419,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RankSortBorder = new PixelMapping
        {
            X = 822,
            Y = 76,
            Color = 4006419,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle R_MapNumber = new Rectangle
        {
            X = 275,
            Y = 12,
            Width = 100,
            Height = 33
        };

        public static readonly PixelMapping AutoRepeat = new PixelMapping
        {
            X = 448,
            Y = 436,
            Color = 16775797,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping BoostMode = new PixelMapping
        {
            X = 655,
            Y = 436,
            Color = 16775797,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping FriendHelp = new PixelMapping
        {
            X = 530,
            Y = 180,
            Color = 8475157,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping FriendHelpBtn = new PixelMapping
        {
            X = 800,
            Y = 180,
            Color = 8475157,
            Type = MappingType.BUTTON
        };
        #endregion Public Fields
    }
}