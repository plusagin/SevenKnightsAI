using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidReadyPM
    {
        #region Public Fields

        public static readonly Rectangle EnteredCount = new Rectangle
        {
            X = 729,
            Y = 297,
            Height = 24,
            Width = 53
        };

        public static readonly PixelMapping MemberListBackground = new PixelMapping
        {
            X = 40,
            Y = 69,
            Color = 1708300,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 740,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyButtonBorderLeft = new PixelMapping
        {
            X = 555,
            Y = 475,
            Color = 16376483,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ReadyButtonBorderRight = new PixelMapping
        {
            X = 924,
            Y = 475,
            Color = 16376483,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Blood25 = new PixelMapping
        {
            X = 868,
            Y = 200,
            Color = 13873749,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Blood50 = new PixelMapping
        {
            X = 745,
            Y = 227,
            Color = 6902069,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Blood75 = new PixelMapping
        {
            X = 830,
            Y = 227,
            Color = 6902069,
            Type = MappingType.BOTH
        };

        public static readonly Rectangle Ownner = new Rectangle
        {
            X = 763,
            Y = 118,
            Height = 23,
            Width = 150
        };

        public static readonly Rectangle Attacker = new Rectangle
        {
            X = 653,
            Y = 260,
            Height = 26,
            Width = 150
        };

        public static readonly Rectangle DragonLV = new Rectangle
        {
            X = 729,
            Y = 297,
            Height = 24,
            Width = 53
        };

        #endregion Public Fields
    }
}