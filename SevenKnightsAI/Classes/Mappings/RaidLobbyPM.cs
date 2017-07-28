using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class RaidLobbyPM
    {
        public static readonly PixelMapping AttackedTab = new PixelMapping
        {
            X = 350,
            Y = 91,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping DefeatedTab = new PixelMapping
        {
            X = 800,
            Y = 91,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping CheckPos1 = new PixelMapping
        {
            X = 264,
            Y = 184,
            Color = 16754182,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping CheckPos2 = new PixelMapping
        {
            X = 264,
            Y = 258,
            Color = 16754182,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping CheckPos3 = new PixelMapping
        {
            X = 264,
            Y = 332,
            Color = 16754182,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping CheckPos4 = new PixelMapping
        {
            X = 264,
            Y = 406,
            Color = 16754182,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping EnterButton = new PixelMapping
        {
            X = 868,
            Y = 200,
            Color = 0,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping EnterButton2 = new PixelMapping
        {
            X = 868,
            Y = 270,
            Color = 0,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping EnterButton3 = new PixelMapping
        {
            X = 868,
            Y = 350,
            Color = 0,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping EnterButton4 = new PixelMapping
        {
            X = 868,
            Y = 420,
            Color = 0,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping GreenIconOnNewTab = new PixelMapping
        {
            X = 214,
            Y = 69,
            Color = 45085,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty1Border = new PixelMapping
        {
            X = 46,
            Y = 494,
            Color = 8877126,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty1Button = new PixelMapping
        {
            X = 120,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ManageParty2Border = new PixelMapping
        {
            X = 266,
            Y = 494,
            Color = 8877126,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ManageParty2Button = new PixelMapping
        {
            X = 323,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping NewTab = new PixelMapping
        {
            X = 550,
            Y = 70,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RedIconOnDefeatedTab = new PixelMapping
        {
            X = 718,
            Y = 57,
            Color = 12986369,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RefreshButton = new PixelMapping
        {
            X = 850,
            Y = 130,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int SCROLL_DELTA = 138;

        public static readonly int SCROLL_DOUBLE_DELTA = 275;

        public static readonly PixelMapping ScrollAreaDown = new PixelMapping
        {
            X = 450,
            Y = 430,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ScrollAreaUp = new PixelMapping
        {
            X = 450,
            Y = 170,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly Rectangle DLV1 = new Rectangle
        {
            X = 227,
            Y = 172,
            Height = 30,
            Width = 28
        };

        public static readonly Rectangle DLV2 = new Rectangle
        {
            X = 227,
            Y = 247,
            Height = 30,
            Width = 28
        };

        public static readonly Rectangle DLV3 = new Rectangle
        {
            X = 227,
            Y = 320,
            Height = 30,
            Width = 28
        };

        public static readonly Rectangle DLV4 = new Rectangle
        {
            X = 227,
            Y = 395,
            Height = 30,
            Width = 28
        };

        public static readonly Rectangle Oname1 = new Rectangle
        {
            X = 297,
            Y = 207,
            Height = 24,
            Width = 120
        };

        public static readonly Rectangle Oname2 = new Rectangle
        {
            X = 297,
            Y = 282,
            Height = 24,
            Width = 120
        };

        public static readonly Rectangle Oname3 = new Rectangle
        {
            X = 297,
            Y = 356,
            Height = 24,
            Width = 120
        };

        public static readonly Rectangle Oname4 = new Rectangle
        {
            X = 297,
            Y = 429,
            Height = 24,
            Width = 120
        };

        public static readonly Rectangle EntryCount = new Rectangle
        {
            X = 765,
            Y = 16,
            Height = 22,
            Width = 20
        };
    }
}