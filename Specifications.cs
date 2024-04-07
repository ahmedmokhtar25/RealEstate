using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Price_Prediction
{
    public class Specifications
    {
        public int Bathrooms;
        public int Balcony;
        public int Bhk;
        public double TotalSqmt;
        public string Location;

        public Specifications(int bathrooms, int balcony, int bhk, double totalSqmt, string location)
        {
            Bathrooms = bathrooms;
            Balcony = balcony;
            Bhk = bhk;
            TotalSqmt = totalSqmt;
            Location = location;
        }
    }
}
