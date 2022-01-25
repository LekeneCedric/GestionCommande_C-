using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_GESTION_COMMANDE_PROJET_CSHARP
{

    //this part of our program is class that stores colours used in the program and will be used randomly in the main program
    public class ThemeColor
    {

        public static Color PrimaryColor { get; set; }
        public static Color SecondryColor { get; set; }
        public static Color TextColor { get; set; }

        public static List<String> ColorList = new List<string>()
        {
                  
                   "#8e90bf",    
                   "#5978bb",
                   "#CBE3A9",      
                   "#e9cfed",  
                   "#7FD6D7"
                               
        };

        /**
         *the  ChangeColorBrightness help to reduce a colour brightness by using decimal values
         *it takes in entry a clour and a correcting factor that will be use to 
         *reduce the RGB concerntration in the colour
         
         */
        public static Color ChangeColorBrightness(Color color, double correctionFactor) 
        {
            double red=color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }

            else {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + red;
                blue = (255 - blue) * correctionFactor + red;
            }

            return Color.FromArgb(color.A,(byte)red,(byte)green,(byte)blue);
        }
    }
}
