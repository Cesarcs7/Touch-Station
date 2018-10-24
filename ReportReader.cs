using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;

namespace SoftwareStation
{
    class ReportReader
    {
        XElement root = XElement.Load("C:\\Scann\\Report.xml");
        private float sum;
        
        public void read()
        {
            
                                          
            foreach (XElement e in root.Descendants("Entry"))
            {
             float number;
               if (Single.TryParse(e.Value.Replace(".",","), out number)){

                String id = e.Attribute("id").Value;
                float value = number;
                    switch (id)
                    {
                        case "18":
                            sum += compareMin(value, 35.642f, 34.367f, 31.467f, 28.203f);
                            Console.WriteLine(sum);
                            Console.WriteLine(value);

                            break;
                        case "20":
                            sum += compareMin(value, 6.483f, 3.572f, 3.109f, 2.203f);
                            Console.WriteLine(sum);
                            Console.WriteLine(value);

                            break;
                        case "42":
                            sum += compareMinLungs(value, 3348, 3529);
                            Console.WriteLine(sum);
                            Console.WriteLine(value);

                            break;
                        case "63":
                            sum += compareMax(value, 2.019f, 4.721f, 5.174f, 6.247f);
                            Console.WriteLine(sum);
                            Console.WriteLine(value);

                            break;
                        case "67":
                            sum += compareMin(value, 0.992f, 0.713f, 0.486f, 0.381f);
                            Console.WriteLine(sum);
                            Console.WriteLine(value);

                            break;
                        case "98":
                            sum += compareMin(value, 5.023f, 4.543f, 3.872f, 3.153f);
                            Console.WriteLine(sum);
                            Console.WriteLine(value);

                            break;
                        case "100":
                            sum += compareMin(value, 6.013f, 4.826f, 4.213f, 3.379f);
                            Console.WriteLine(sum);
                            Console.WriteLine(value);

                            break;
                        case "114":
                            sum += compareMin(value, 2.979f, 1.833f, 1.097f, 0.373f);
                            Console.WriteLine(sum);
                            Console.WriteLine(value);

                            break;
                        case "169":
                            sum += compareMin(value, 3.713f, 1.992f, 1.113f, 0.782f);
                            Console.WriteLine(sum);
                            Console.WriteLine(value);

                            break;
                        case "173":
                            sum += compareMax(value, 1.341f, 1.991f, 3.568f, 5.621f);
                            Console.WriteLine(sum);
                            Console.WriteLine(value);

                            break;
                        case "176":
                            sum += compareMax(value, 14.477f, 21.348f, 28.432f, 35.879f);
                            Console.WriteLine(sum);
                            Console.WriteLine(value);

                            break;
                        case "178":
                            sum += compareMax(value, 0.218f, 0.953f, 1.629f, 2.369f);
                            Console.WriteLine(sum);
                            Console.WriteLine(value);

                            break;
                        case "189":
                            sum += compareMax(value, 0.332f, 0.726f, 1.226f, 1.708f);
                            Console.WriteLine(sum);
                            Console.WriteLine(value);

                            break;
                        default:
                            Console.WriteLine("Nix");
                            break;
                    }
                }
                else
                {
                    continue;
                }
                
            }

        }
        
        public float compareMin(float val,float max,float min1, float min2, float min3)
        {
            if(val<max && val > min1)
            {
                return 7.6923f;
            }else if (val<min1 && val>min2)
            {
                return 5.76923f;
            }else if(val<min2 && val > min3)
            {
                return 3.84616f;
            }else if (val < min3)
            {
                return 1.92307f;
            }
            else
            {
                return 0f;
            }
        }

        public float compareMax(float val, float min, float max1, float max2, float max3)
        {
            if (val > min && val < max1)
            {
                return 7.6923f;
            }
            else if (val < max2 && val > max1)
            {
                return 5.76923f;
            }
            else if (val < max3 && val > max2)
            {
                return 3.84616f;
            }
            else if (val > max3)
            {
                return 1.92307f;
            }
            else
            {
                return 0f;
            }
        }

        public float compareMinLungs(float val, float min, float max)
        {
            if (val > min && val < max)
            {
                return 7.6923f;
            }
            else if (val < min || val > max)
            {
                return 1.92307f;
            }
            else
            {
                return 0f;
            }
        }

        public float getSum()
        {
           
            return (float)Math.Round(sum);
        }
    }
}
