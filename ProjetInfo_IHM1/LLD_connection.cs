using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

/*
 * Classe dédiée au passage C# -> C++ 
 * Construite à partir de l'exemple "Seuillage auto - CLImage.cs"
 */


namespace ProjetInfo_IHM1
{
    class LLD_connection
    {
        // Création d'une classe C# avec pointeur sur l'objet C++
        // Création des static extern exportées de chaque méthode utile de la classe C++

        public IntPtr ClPtr;

        public LLD_connection()
        {
            ClPtr = IntPtr.Zero;
        }

        ~LLD_connection()
        {
            if (ClPtr != IntPtr.Zero)
                ClPtr = IntPtr.Zero;
        }

        // Va-et-vient avec constructeur C#/C++ obligatoire dans toute nouvelle classe propre à l'application

        [DllImport("LibraryImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LLD_SetCalibrationSheet(IntPtr ClPtr, int nbChamps, IntPtr data, int stride, int nbLig, int nbCol);

        public void SetCalibrationSheet(Bitmap bmp)
        {
            unsafe
            {
                BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                try
                {
                    LLD_SetCalibrationSheet(ClPtr, 1, bmpData.Scan0, bmpData.Stride, bmp.Height, bmp.Width);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                bmp.UnlockBits(bmpData);
            }
        }

        [DllImport("LibraryImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LLD_AnalyseSheet(IntPtr ClPtr, StringBuilder correction, int nbQuestionsMax, int nbChamps, IntPtr data, int stride, int nbLig, int nbCol);

        public String AnalyseSheet(Bitmap bmp)
        {
            // String correction = "error";
            StringBuilder str = new StringBuilder();
            unsafe
            {
                BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                try
                {
                    LLD_AnalyseSheet(ClPtr, str, str.Capacity, 1, bmpData.Scan0, bmpData.Stride, bmp.Height, bmp.Width);    // Envoie de l'image à la connexion C# du LLD
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                bmp.UnlockBits(bmpData);
            }

            return str.ToString();
        }

        [DllImport("LibraryImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int LLD_GetCandidatNumber(IntPtr ClPtr, int nbChamps, IntPtr data, int stride, int nbLig, int nbCol);

        public int GetCandidatNumber(Bitmap bmp)
        {
            int number = 0;
            unsafe
            {
                BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                try
                {
                    number = LLD_GetCandidatNumber(ClPtr, 1, bmpData.Scan0, bmpData.Stride, bmp.Height, bmp.Width);    // Envoie de l'image à la connexion C# du LLD
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                bmp.UnlockBits(bmpData);
            }

            return number;
        }


        [DllImport("LibraryImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr LLD_Initialisation();

        public void LLD_Init()
        {
            ClPtr = LLD_Initialisation();
        }
    }
}

