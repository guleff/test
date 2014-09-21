using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Battery
    {
        private string batteryType;
        private double batteryLife;

        public Battery(string batteryType)
        {
            this.BatteryType = batteryType;
        }
        public Battery(string batteryType, double batteryLife = 0)
            : this(batteryType)
        {
            this.BatteryLife = batteryLife;

        }
        public string BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Value cannot be empty string.This field is required");
                }
                this.batteryType = value;
            }
        }
        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value cannot be negative");
                }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("battery " + this.batteryType);
            if (this.BatteryLife != 0)
            {
                result.AppendLine("battery life " + this.batteryLife);
            }
            return result.ToString();
        }
    }
}
