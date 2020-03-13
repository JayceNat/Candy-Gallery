using System;
using System.Drawing;
using System.Drawing.Imaging;


namespace CandyGallery.Helpers
{
    public class CandyImageFilters
    {
        // **************************************************************************************************
        private static Bitmap Pixelate(Image image, Rectangle rectangle, int pixelateSize)
        {
            var pixelated = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (var graphics = Graphics.FromImage(pixelated))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            // look at every pixel in the rectangle while making sure we're within the image bounds
            for (var xx = rectangle.X; xx < rectangle.X + rectangle.Width && xx < image.Width; xx += pixelateSize)
            {
                for (var yy = rectangle.Y; yy < rectangle.Y + rectangle.Height && yy < image.Height; yy += pixelateSize)
                {
                    var offsetX = pixelateSize / 2;
                    var offsetY = pixelateSize / 2;

                    // make sure that the offset is within the boundary of the image
                    while (xx + offsetX >= image.Width) offsetX--;
                    while (yy + offsetY >= image.Height) offsetY--;

                    // get the pixel color in the center of the soon to be pixelated area
                    var pixel = pixelated.GetPixel(xx + offsetX, yy + offsetY);

                    // for each pixel in the pixelate size, set it to the center color
                    for (var x = xx; x < xx + pixelateSize && x < image.Width; x++)
                        for (var y = yy; y < yy + pixelateSize && y < image.Height; y++)
                            pixelated.SetPixel(x, y, pixel);
                }
            }

            return pixelated;
        }

        public static Bitmap Pixelate(Bitmap image, int blurSize)
        {
            return Pixelate(image, new Rectangle(0, 0, image.Width, image.Height), blurSize);
        }

        // **************************************************************************************************
        public static void Grayscale(Bitmap image, int amount)
        {
            amount /= 5;

            var cm = new ColorMatrix(new[]
            {
                new[] {0.150f*amount, 0.150f*amount, 0.150f*amount, 0, 0},
                new[] {0.150f, 0.150f, 0.150f, 0, 0},
                new[] {0.150f, 0.150f, 0.150f, 0, 0},
                new float[] { 0, 0, 0, 1, 0},
                new float[] { 0, 0, 0, 0, 1}
            });

            ApplyColorMatrixToImage(image, cm);
        }

        // **************************************************************************************************
        public static void Colorize(Bitmap image, int amount)
        {
            var rand = new Random(amount);
            var redAmount = rand.Next(1, 99);
            var greenAmount = rand.Next(1, 99);
            var blueAmount = rand.Next(1, 99);

            var cm = new ColorMatrix(new[]
            {
                new[] {redAmount * 0.01f, 0, 0, 0, 0},
                new[] {0, greenAmount * 0.01f, 0, 0, 0},
                new[] {0, 0, blueAmount * 0.01f, 0, 0},
                new float[] { 0, 0, 0, 1, 0},
                new float[] { 0, 0, 0, 0, 1}
            });

            ApplyColorMatrixToImage(image, cm);
        }

        // **************************************************************************************************
        public static void Sepia(Bitmap image, int amount)
        {
            amount /= 5;

            var cm = new ColorMatrix(new[]
            {
                new[] {0.393f*amount/2, 0.349f*amount/2, 0.272f*amount/2, 0, 0},
                new[] {0.769f, 0.686f, 0.534f, 0, 0},
                new[] {0.189f, 0.168f, 0.131f, 0, 0},
                new float[] { 0, 0, 0, 1, 0},
                new float[] { 0, 0, 0, 0, 1}
            });

            ApplyColorMatrixToImage(image, cm);
        }

        // **************************************************************************************************
        public static void Negative(Bitmap image)
        {
            var cm = new ColorMatrix(new[]
            {
                new float[] { -1, 0, 0, 0, 0},
                new float[] { 0, -1, 0, 0, 0},
                new float[] { 0, 0, -1, 0, 0},
                new float[] { 0, 0, 0, 1, 0},
                new float[] { 1, 1, 1, 0, 1}
            });

            ApplyColorMatrixToImage(image, cm);
        }

        // **************************************************************************************************
        private static void ApplyColorMatrixToImage(Image image, ColorMatrix cm)
        {
            var attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);

            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
            };
            var rect = new Rectangle(0, 0, image.Width, image.Height);

            using (var gr = Graphics.FromImage(image))
            {
                gr.DrawImage(image, points, rect,
                    GraphicsUnit.Pixel, attributes);
            }
        }
    }
}
