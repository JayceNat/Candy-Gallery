using System.Drawing;

namespace CandyGallery.Models
{
    public class CandyInterfaceColors
    {
        public static Color CandyRed = Color.Brown;
        public static Color CandyGreen = Color.DarkGreen;
        public static Color CandyBlue = Color.DodgerBlue;
        public static Color CandyOrange = Color.DarkOrange;
        public static Color CandyYellow = Color.Goldenrod;
        public static Color CandyPurple = Color.SlateBlue;
        public static Color CandyWhite = Color.MintCream;
        public static Color CandyGray = Color.DarkGray;
        public static Color CandyBlack = Color.FromArgb(50,50,50);
        public static Color CandyCream = Color.PeachPuff;
        public static Color CandyBrown = Color.SaddleBrown;
        public static Color CandyPink = Color.Salmon;
        public static Color CandyLightBlue = Color.Aquamarine;

        public static Color GetInterfaceColorByName(string candyColor)
        {
            switch (candyColor)
            {
                case "Cherry":
                    return CandyRed;
                case "Apple":
                    return CandyGreen;
                case "Blueberry":
                    return CandyBlue;
                case "Creamsicle":
                    return CandyOrange;
                case "Mango":
                    return CandyYellow;
                case "Grape":
                    return CandyPurple;
                case "Coconut":
                    return CandyWhite;
                case "Mochi":
                    return CandyGray;
                case "Licorice":
                    return CandyBlack;
                case "Vanilla":
                    return CandyCream;
                case "Chocolate":
                    return CandyBrown;
                case "Peach":
                    return CandyPink;
                case "Sour Blue":
                    return CandyLightBlue;
                default:
                    return CandyRed;
            }
        }
    }
}