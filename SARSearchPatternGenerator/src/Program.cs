﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SARSearchPatternGenerator
{
    static class Program
    {
        //GPX test data
       static double[] lat = new double[] 
        {
            49.3658750, 49.3662420, 49.3665020, 49.3667150, 49.3669600, 49.3670980,
            49.3672960, 49.3674640, 49.3677400, 49.3677850, 49.3679230, 49.3680760,
            49.3682590, 49.3684420, 49.3684570, 49.3688850
        };

        //GPX test data
        static double[] lon = new double[]
        {
            -123.0882700, -123.0881300, -123.0879200, -123.0879200, -123.0878270,
            -123.0878270, -123.0876170, -123.0877110, -123.0875480, -123.0876650,
            -123.0878520, -123.0878290, -123.0879230, -123.0878300, -123.0881570,
            -123.0880650

        };

        //GPX test data
        static double[] lat2 = new double[]
         {
             49.4612020, 49.4610120, 49.4608230, 49.4598760, 49.4598290, 49.4600090, 49.4598100, 49.4596680, 49.4595450,
             49.4594030, 49.4592230, 49.4588720, 49.4588530, 49.4589480, 49.4589200, 49.4587780, 49.4587680, 49.4588730,
             49.4587970, 49.4588250, 49.4589860, 49.4589300, 49.4583520, 49.4584750, 49.4586930, 49.4587970, 49.4586640,
             49.4584180, 49.4583420, 49.4583520, 49.4586270, 49.4589490, 49.4592520, 49.4596880, 49.4599340, 49.4601050,
             49.4601240, 49.4600570, 49.4596880, 49.4595460, 49.4593750, 49.4591670, 49.4589200, 49.4587310, 49.4582290,
             49.4580580, 49.4576410, 49.4574230, 49.4570730
         };

        //GPX test data
        static double[] lon2 = new double[]
        {
            -122.9770940, -122.9785470, -122.9786780, -122.9795360, -122.9807280, -122.9820650, -122.9828790, -122.9838240,
            -122.9840280, -122.9846960, -122.9847690, -122.9856700, -122.9860770, -122.9863390, -122.9868040, -122.9870370,
            -122.9878220, -122.9880250, -122.9888390, -122.9890140, -122.9892020, -122.9894930, -122.9898130, -122.9902200,
            -122.9904820, -122.9907290, -122.9909610, -122.9909760, -122.9911650, -122.9914120, -122.9922260, -122.9924580,
            -122.9925020, -122.9922110, -122.9921530, -122.9922110, -122.9923710, -122.9925020, -122.9927490, -122.9930400,
            -122.9932000, -122.9936500, -122.9936360, -122.9939990, -122.9944350, -122.9944790, -122.9946390, -122.9945520,
            -122.9945520,

        };


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new WindowController();
            //Test GPX export.
            /*
            Pattern p = new Pattern();
            for (int i = 0; i < 16; i++) {
                p.addPoint(new DecDeg(lat[i], lon[i]));
            }
            KML kml = new KML(p);
            kml.writeFile("BCMC");
            */

            //Test GPX export 2.
            /*Pattern p = new Pattern();
            for (int i = 0; i < 49; i++)
            {
                p.addPoint(new DecDeg(lat2[i], lon2[i]));
            }
            KML kml = new KML(p);
            kml.writeFile("BurwellLakeTrailTest"); */
        }
    }
}