using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablet
{
    public class Tablet
    {
        public string brand;
        public int price;
        public int weight;
        public string color;
        public bool isthereasimcard;
        public bool isthereamemorycardslot;
        public double screendiagonal;
        public double CPUfrequency;

        public double discountedPrice()
        {
            double discountPercentage = 30;
            double discountedPrice = price - (price * discountPercentage / 100);
            return discountedPrice;
        }

        public double discountwitharegularcustomercard()
        {
            double discount = 5;
            double discountwitharegularcustomercard = discountedPrice() - (discountedPrice() * discount / 100);
            return discountwitharegularcustomercard;
        }
    }
}
