using System;
using System.Drawing;

namespace Vis_Crypto
{
    class Program
    {
        static Bitmap GenRandom(int width, int height)
        {
            var rng = new Random();
            var res = new Bitmap(width, height);
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    res.SetPixel(x, y, rng.NextDouble() > 0.5f ? Color.Black : Color.White);
                }
            }
            return res;
        }

        static void FillP1(Bitmap bmp, int x, int y)
        {
            bmp.SetPixel(x, y, Color.Black);
            bmp.SetPixel(x, y + 1, Color.Black);
            bmp.SetPixel(x + 1, y, Color.White);
            bmp.SetPixel(x + 1, y + 1, Color.White);
        }

        static void FillP2(Bitmap bmp, int x, int y)
        {
            bmp.SetPixel(x, y, Color.White);
            bmp.SetPixel(x, y + 1, Color.White);
            bmp.SetPixel(x + 1, y, Color.Black);
            bmp.SetPixel(x + 1, y + 1, Color.Black);
        }

        static void Encrypt(string input, string output)
        {
            var inBmp = new Bitmap(input);
            var w = inBmp.Width;
            var h = inBmp.Height;
            var outBmp = new Bitmap(inBmp.Width*2, inBmp.Height*2);
            var outBmp2 = new Bitmap(inBmp.Width*2, inBmp.Height*2);
            var rng = new Random();

            for (var y = 0; y < h; y++)
            {
                for (var x = 0; x < w; x++)
                {
                    var inClr = inBmp.GetPixel(x, y);
                    var isWhite = IsWhite(inClr);
                    if (isWhite)
                    {
                        if (rng.NextDouble() >= 0.5)
                        {
                            FillP1(outBmp, x*2, y*2);
                            FillP1(outBmp2, x*2, y*2);
                        }
                        else
                        {
                            FillP2(outBmp, x*2, y*2);
                            FillP2(outBmp2, x*2, y*2);
                        }
                    }
                    else
                    {
                        if (rng.NextDouble() >= 0.5)
                        {
                            FillP2(outBmp, x*2, y*2);
                            FillP1(outBmp2, x*2, y*2);
                        }
                        else
                        {
                            FillP1(outBmp, x*2, y*2);
                            FillP2(outBmp2, x*2, y*2);
                        }
                    }
                }
            }

            outBmp.Save("1_" + output);
            outBmp2.Save("2_" + output);
        }

        static bool IsWhite(Color inClr)
        {
            return inClr.R == 255 && inClr.G == 255 && inClr.B == 255;
        }

        static Color Combine(Bitmap bmp, int x, int y)
        {
            int c = 0;
            if (IsWhite(bmp.GetPixel(x, y)))
            c++;
            if (IsWhite(bmp.GetPixel(x+1, y)))
            c++;
            if (IsWhite(bmp.GetPixel(x, y+1)))
            c++;
            if (IsWhite(bmp.GetPixel(x+1, y+1)))
            c++;

            if (c == 2)
            {
                return Color.White;
            }
            else
            {
                return Color.Black;
            }
        }

        static void Decrypt(string input1, string input2, string output)
        {
            var in1 = new Bitmap(input1);
            var in2 = new Bitmap(input2);
            var w = in1.Width;
            var h = in1.Height;
            var res = new Bitmap(w, h);
            var res1 = new Bitmap(w/2, h/2);

            for (var y = 0; y < h; y++)
            {
                for (var x = 0; x < w; x++)
                {
                    if (IsWhite(in1.GetPixel(x, y)) && IsWhite(in2.GetPixel(x, y)))
                    {
                        res.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        res.SetPixel(x, y, Color.Black);
                    }
                }
            }

            for (var y = 0; y < h/2; y++)
            {
                for (var x = 0; x < w/2; x++)
                {
                    res1.SetPixel(x, y, Combine(res, x*2, y*2));
                }
            }


            res.Save(output);
            res1.Save("T_" + output);
        }

        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                Encrypt(args[0], args[1]);
            }
            else if (args.Length == 3)
            {
                Decrypt(args[0], args[1], args[2]);
            }
        }
    }
}