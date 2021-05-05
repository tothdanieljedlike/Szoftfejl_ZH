using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoftfej_ZH
{
    class Program
    {
        public static int mappaba(int hanyas, int db)
        {
            String line;
            int szam = 0;
            StreamReader sr = new StreamReader("sg500/svmResult.csv");
            Console.WriteLine(hanyas);
            line = sr.ReadLine();
            for (int i = 0; i < hanyas * 100; i++)
            {
                Console.WriteLine("sad");
                line = sr.ReadLine();
            }
            line = sr.ReadLine();
            while (line != null)
            {
                
                string[] darabok = line.Split(';');
                if (Convert.ToInt32(darabok[1]) == db)
                {
                    szam = Convert.ToInt32(darabok[4]);
                    break;
                }

                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();           
            return szam;
        }
        static void Main(string[] args)
        {
            int startw = 0;
            int starth = 0;
            int hova = 0;
            for (int i = 0; i < 30; i++)
            {
                int szamlalo = i + 1;
                string fileName = "01.bmp";
                string pathpart = "sg500\\" + Convert.ToString(szamlalo);
                string path = Path.Combine(Environment.CurrentDirectory, pathpart , fileName);
                
                Bitmap originalImage = new Bitmap(Image.FromFile(path));
                Bitmap nthpiece;
                for (int j = 1; j <= 100; j++)
                {
                    
                    Rectangle rect = new Rectangle(startw, starth, originalImage.Width / 10, originalImage.Height / 10);
                    
                    nthpiece = originalImage.Clone(rect, originalImage.PixelFormat);
                    
                    hova = mappaba(i, j - 1);
                    
                    string pathe = Path.Combine(Environment.CurrentDirectory, Convert.ToString(hova) , (i*j*i+1)+fileName);
                    
                    nthpiece.Save(pathe);
                    startw = startw + originalImage.Width / 10;
                    starth = starth + originalImage.Width / 10;                    
                }
            }
        }
    }
}
