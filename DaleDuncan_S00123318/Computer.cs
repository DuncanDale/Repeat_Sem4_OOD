using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaleDuncan_S00123318
{
    public class Computer
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string OperatingSystem { get; set; }
        public string Manufacturer_Image { get; set; }
        public string Computer_Image { get; set; }
        public string Memory { get; set; }
        public string Processor { get; set; }


        public static void DecreasePrice(double Percentage)
        {
            double decrease;
            double Price = 500;

            Percentage = Percentage / 100;

            decrease = Price * Percentage;

            Price = Price - decrease;



        }
    }

}
