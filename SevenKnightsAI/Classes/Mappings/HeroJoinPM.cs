using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class HeroJoinPM
    {
        #region Public Fields

        public static readonly PixelMapping JoinButton = new PixelMapping
        {
            X = 848,
            Y = 485,
            Color = 10252843,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping JoinButtonIcon = new PixelMapping
        {
            X = 859,
            Y = 466,
            Color = 15058003,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SellButton = new PixelMapping
        {
            X = 594,
            Y = 481,
            Color = 15520877,
            Type = MappingType.BOTH
        };

        #endregion Public Fields
    }
}