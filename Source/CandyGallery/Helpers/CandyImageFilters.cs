using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace CandyGallery.Helpers
{
    public class CandyImageFilters
    {
        // **************************************************************************************************
        private static Bitmap SobelEdgeFilter(Bitmap sourceImage,
            double[,] xkernel,
            double[,] ykernel, int amount, int bias = 0, bool grayscale = false)
        {
            var amt = 0;
            if (amount >= 10) amt = amount + 5;

            //Image dimensions stored in variables for convenience
            int width = sourceImage.Width;
            int height = sourceImage.Height;

            //Lock source image bits into system memory
            BitmapData srcData = sourceImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            //Get the total number of bytes in your image - 32 bytes per pixel x image width x image height -> for 32bpp images
            int bytes = srcData.Stride * srcData.Height;

            //Create byte arrays to hold pixel information of your image
            byte[] pixelBuffer = new byte[bytes];
            byte[] resultBuffer = new byte[bytes];

            //Get the address of the first pixel data
            IntPtr srcScan0 = srcData.Scan0;

            //Copy image data to one of the byte arrays
            Marshal.Copy(srcScan0, pixelBuffer, 0, bytes);

            //Unlock bits from system memory -> we have all our needed info in the array
            sourceImage.UnlockBits(srcData);

            if (grayscale == true)
            {
                float rgb = 0;
                for (int i = 0; i < pixelBuffer.Length; i += 4)
                {
                    rgb = pixelBuffer[i] * .21f;
                    rgb += pixelBuffer[i + 1] * .71f;
                    rgb += pixelBuffer[i + 2] * .071f;
                    pixelBuffer[i] = (byte)rgb;
                    pixelBuffer[i + 1] = pixelBuffer[i];
                    pixelBuffer[i + 2] = pixelBuffer[i];
                    pixelBuffer[i + 3] = 255;
                }
            }

            //Create variable for pixel data for each kernel
            double xr = 0.0;
            double xg = 0.0;
            double xb = 0.0;
            double yr = 0.0;
            double yg = 0.0;
            double yb = 0.0;
            double rt = 0.0;
            double gt = 0.0;
            double bt = 0.0;

            //This is how much your center pixel is offset from the border of your kernel
            //Sobel is 3x3, so center is 1 pixel from the kernel border
            int filterOffset = 1;
            int calcOffset = 0;
            int byteOffset = 0;

            //Start with the pixel that is offset 1 from top and 1 from the left side
            //this is so entire kernel is on your image
            for (int OffsetY = filterOffset; OffsetY < height - filterOffset; OffsetY++)
            {
                for (int OffsetX = filterOffset; OffsetX < width - filterOffset; OffsetX++)
                {
                    //reset rgb values to 0
                    xr = xg = xb = yr = yg = yb = 0 + amt;
                    rt = gt = bt = 0.0;

                    //position of the kernel center pixel
                    byteOffset = OffsetY * srcData.Stride + OffsetX * 4;

                    //kernel calculations
                    for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset + filterX * 4 + filterY * srcData.Stride;
                            xb += (double)(pixelBuffer[calcOffset]) * xkernel[filterY + filterOffset, filterX + filterOffset];
                            xg += (double)(pixelBuffer[calcOffset + 1]) * xkernel[filterY + filterOffset, filterX + filterOffset];
                            xr += (double)(pixelBuffer[calcOffset + 2]) * xkernel[filterY + filterOffset, filterX + filterOffset];
                            yb += (double)(pixelBuffer[calcOffset]) * ykernel[filterY + filterOffset, filterX + filterOffset];
                            yg += (double)(pixelBuffer[calcOffset + 1]) * ykernel[filterY + filterOffset, filterX + filterOffset];
                            yr += (double)(pixelBuffer[calcOffset + 2]) * ykernel[filterY + filterOffset, filterX + filterOffset];
                        }
                    }

                    //total rgb values for this pixel
                    bt = Math.Sqrt((xb * xb) + (yb * yb));
                    gt = Math.Sqrt((xg * xg) + (yg * yg));
                    rt = Math.Sqrt((xr * xr) + (yr * yr));

                    //set limits, bytes can hold values from 0 up to 255;
                    if (bt > 255) bt = 255;
                    else if (bt < 0) bt = 0;
                    if (gt > 255) gt = 255;
                    else if (gt < 0) gt = 0;
                    if (rt > 255) rt = 255;
                    else if (rt < 0) rt = 0;

                    //set new data in the other byte array for your image data
                    resultBuffer[byteOffset] = (byte)(bt);
                    resultBuffer[byteOffset + 1] = (byte)(gt);
                    resultBuffer[byteOffset + 2] = (byte)(rt);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            //Create new bitmap which will hold the processed data
            Bitmap resultImage = new Bitmap(width, height);

            //Lock bits into system memory
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            //Copy from byte array that holds processed data to bitmap
            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);

            //Unlock bits from system memory
            resultImage.UnlockBits(resultData);

            //Return processed image
            return resultImage;
        }

        //Sobel operator kernel for horizontal pixel changes
        private static double[,] xSobel
        {
            get
            {
                return new double[,]
                {
                    { -1, 0, 1 },
                    { -2, 0, 2 },
                    { -1, 0, 1 }
                };
            }
        }

        //Sobel operator kernel for vertical pixel changes
        private static double[,] ySobel
        {
            get
            {
                return new double[,]
                {
                    {  1,  2,  1 },
                    {  0,  0,  0 },
                    { -1, -2, -1 }
                };
            }
        }

        public static Bitmap SobelEdgeFilter(Bitmap image, int amount)
        {
            return SobelEdgeFilter(image, xSobel, ySobel, amount);
        }

        // **************************************************************************************************
        //private static Bitmap NewPixelate(Bitmap image, Rectangle rectangel, int pixelSize)
        //{
            
        //}

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
