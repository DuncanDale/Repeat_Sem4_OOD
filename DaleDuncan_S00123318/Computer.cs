using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaleDuncan_S00123318
{
    public class Computer
    {
      
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string Manufacturer_Image { get; set; }
        public string Computer_Image { get; set; }
        public string HardDrive { get; set; }
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

        public static void GetDetails()
        {
            
        }

        //public override string ToString()
        //{
        //    return string.Format($"{Operating}");

        //}

        public class ComputerData : DbContext
        {

            public ComputerData() : base("MyComputerData") { }

            public DbSet<Computer> Phones { get; set; }
        }
    }

}
