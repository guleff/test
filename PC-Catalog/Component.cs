using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private double price;

        public Component(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Component(string name, double price, string details = null)
            : this(name, price)
        {
            this.Details = details;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty string");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value != null && string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The details cannot be empty string");
                }
                this.details = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Name + " - " + this.Price + " BGN\n  Details: " + this.Details);

            return result.ToString();
        }
    }
}
