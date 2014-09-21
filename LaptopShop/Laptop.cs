using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private int hdd;
        private string screen;
        private double price;
        private Battery battery;

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("This field is required...");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value != null && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("You may skip this field or put a non empty string");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value != null && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("You may skip this field or put a non empty string");
                }
                this.processor = value;
            }
        }
        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("You may skip this field or put a valid value(must be positive number)");
                }
                this.ram = value;
            }
        }
        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {

                if (value != null && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("You may skip this field or put a non empty string");
                }
                this.graphicsCard = value;
            }
        }
        public int Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("You may skip this field or put a valid value(must be positive number)");
                }
                this.hdd = value;
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value != null && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("You may skip this field or put a non empty string");
                }
                this.screen = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("This field is required...");
                }
                this.price = value;
            }
        }

        internal Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, double price, string manufacturer = null, string processor = null, int ram = 0, string graphicsCard = null, int hdd = 0, string screen = null, Battery battery = null)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("model " + this.model);
            if (this.manufacturer != null)
            {
                result.AppendLine("manufacturer " + this.manufacturer);
            }
            if (this.processor != null)
            {
                result.AppendLine("processor " + this.processor);
            }
            if (this.ram > 0)
            {
                result.AppendLine("RAM " + this.ram);
            }
            if (this.graphicsCard != null)
            {
                result.AppendLine("graphics card " + this.graphicsCard);
            }
            if (this.hdd > 0)
            {
                result.AppendLine("HDD " + this.hdd);
            }
            if (this.screen != null)
            {
                result.AppendLine("screen " + this.screen);
            }
            if (this.battery != null)
            {
                result.AppendLine("" + this.Battery);
            }
            result.AppendLine("price " + this.price);
            return string.Format(result.ToString());
        }



        static void Main(string[] args)
        {
            Laptop p = new Laptop("HP 250 G2", 1834.44, "hp", "AMD", 0, "Nvidia", 0, null, new Battery("fsdfs", 2));
            Laptop test = new Laptop("Dell", 493, null, "AMD", 12, "fdsfdas", 0, null, new Battery("fdss"));
            Console.WriteLine(p);
            Console.WriteLine(test);
        }
    }
}
