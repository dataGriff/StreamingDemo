using FruitConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griffless
{
    public class Fruit
    {
        public string colour { get; set; }

        public string name { get; private set; }

        public int price { get; private set; }

        public StandardLog standardLog { get; private set; }

        public Fruit(string colour)

        {
            this.colour = colour;
            GetFruitNameAndPrice();
            standardLog = new StandardLog(StandardLog.LogCode.Success);
        }

        public void GetFruitNameAndPrice ()
        {
          switch (colour)
            {
                case "Yellow":
                    name = "Banana";
                    price = 50;
                    break;
                case "Red":
                    name = "Strawberry";
                    price = 75;
                    break;
                case "Green":
                    name = "Apple";
                    price = 25;
                    break;
                case "Orange":
                    name = "Orange";
                    price = 35;
                    break;
                case "Purple":
                    name = "Grape";
                    price = 10;
                    break;
            }
        }
    }
}
