using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ArenaStartPM
    {
        #region Public Fields

        public static readonly PixelMapping CombatTeamBorderLeft = new PixelMapping
        {
            X = 43,
            Y = 70,
            Color = 13863428,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CombatTeamBorderRight = new PixelMapping
        {
            X = 326,
            Y = 70,
            Color = 13863428,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping FormationBorderLeft = new PixelMapping
        {
            X = 345,
            Y = 137,
            Color = 15587227,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping FormationBorderRight = new PixelMapping
        {
            X = 927,
            Y = 137,
            Color = 15587227,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping FormationSelectBalance = new PixelMapping
        {
            X = 776,
            Y = 200,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping FormationSelectBasic = new PixelMapping
        {
            X = 488,
            Y = 200,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping FormationSelectDefense = new PixelMapping
        {
            X = 776,
            Y = 374,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping FormationSelectOffense = new PixelMapping
        {
            X = 488,
            Y = 374,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int HONOR_OFFSET_X = 227;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping Key_0 = new PixelMapping
        {
            X = 384,
            Y = 18,
            Color = 15035404,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_1 = new PixelMapping
        {
            X = 408,
            Y = 18,
            Color = 13862671,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_2 = new PixelMapping
        {
            X = 434,
            Y = 18,
            Color = 14883077,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_3 = new PixelMapping
        {
            X = 457,
            Y = 18,
            Color = 15475208,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Key_4 = new PixelMapping
        {
            X = 481,
            Y = 18,
            Color = 14971148,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageButton = new PixelMapping
        {
            X = 280,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Mastery_1 = new PixelMapping
        {
            X = 315,
            Y = 125,
            Color = 16637984,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Mastery_2 = new PixelMapping
        {
            X = 319,
            Y = 136,
            Color = 15257116,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Mastery_3 = new PixelMapping
        {
            X = 320,
            Y = 132,
            Color = 16769568,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MasteryButton = new PixelMapping
        {
            X = 302,
            Y = 156,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly Rectangle R_Time = new Rectangle
        {
            X = 517,
            Y = 19,
            Width = 48,
            Height = 20
        };

        public static readonly int RUBY_OFFSET_X = 224;

        public static readonly int RUBY_OFFSET_Y = 0;

        public static readonly PixelMapping StartButton = new PixelMapping
        {
            X = 636,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}