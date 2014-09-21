using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{
    class Computer
    {

        private string name;
        private List<Component> parts = new List<Component>();


        private decimal price;
        private Component cpu;
        private Component motherboard;
        private Component vga;
        private Component hdd;
        private Component ram;
        private string components;

        public string Components
        {
            get { return this.components; }
            set { this.components = value; }
        }

        public Computer(string name)
        {
            this.Name = name;
        }
        public Computer(string name, Component cpu = null, Component motherboard = null, Component vga = null, Component hdd = null, Component ram = null)
            : this(name)
        {
            this.Cpu = cpu;
            this.Motherboard = motherboard;
            this.Vga = vga;
            this.Hdd = hdd;
            this.Ram = ram;
        }

        public List<Component> Parts
        {
            get { return this.parts; }
            set { this.parts = value; }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                name = value;
            }
        }
        public Component Cpu
        {
            get { return this.cpu; }
            set
            {
                if (value != null)
                {
                    this.parts.Add(value);
                    this.Price += (decimal)value.Price;
                    this.components += "CPU: " + value.ToString() + "\n";
                }
                this.cpu = value;
            }
        }
        public Component Motherboard
        {
            get { return this.motherboard; }
            set
            {
                if (value != null)
                {
                    this.parts.Add(value);
                    this.Price += (decimal)value.Price;
                    this.components += "Motherboard: " + value.ToString() + "\n";
                }
                this.motherboard = value;
            }
        }
        public Component Vga
        {
            get { return this.vga; }
            set
            {
                if (value != null)
                {
                    this.parts.Add(value);
                    this.Price += (decimal)value.Price;
                    this.components += "Video card: " + value.ToString() + "\n";
                }
                this.vga = value;
            }
        }
        public Component Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value != null)
                {
                    this.parts.Add(value);
                    this.Price += (decimal)value.Price;
                    this.components += "HDD: " + value.ToString() + "\n";
                }
                this.hdd = value;
            }
        }

        public Component Ram
        {
            get { return this.ram; }
            set
            {
                if (value != null)
                {
                    this.parts.Add(value);
                    this.Price += (decimal)value.Price;
                    this.components += "RAM: " + value.ToString() + "\n";
                }
                this.ram = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            private set { this.price = value; }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("PC Name: " + this.Name + "\n");
            result.AppendLine(this.components);
            result.AppendLine("PC Price: " + this.Price + " BGN");
            return result.ToString();
        }

        static void Main(string[] args)
        {

            SortedDictionary<decimal, Computer> list = new SortedDictionary<decimal, Computer>();
            Computer comp1 = new Computer("Laptop", new Component("cpu", 46.33), new Component("asus", 218.44),
                new Component("Nvidia", 184.93), new Component("Toshiba", 163.88), new Component("Kingston", 277.19));
            Computer comp2 = new Computer("Desktop PC", new Component("Intel i5-5500M", 258.22, "Very good CPU"), new Component("ASUS-KB-73G2", 391.90, "High performance mainboard"),
                null, new Component("Seagate", 155.84, "500GB"), new Component("Kingston", 299.95, "HyperX memory"));
            Computer comp3 = new Computer("Netbook", new Component("Intel Atom", 163.88, "netbook version"), null, null, new Component("Samsung 200GB", 138.47), new Component("DDR3 1600Mhz", 120.41));

            list.Add(comp1.Price, comp1);
            list.Add(comp2.Price, comp2);
            list.Add(comp3.Price, comp3);

            foreach (var item in list)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
