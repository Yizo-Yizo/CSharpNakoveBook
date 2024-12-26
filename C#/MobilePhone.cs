using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace C_
{
    public class MobilePhone
    {
        // Ch 14 No. 7
        private string? model;
        private string? manufacturer;
        private double? price;
        private string? owner;
        private Battery? batteryFeatures;
        private Display? dispalyFeatures;

        // Ch 14 No.10
        private static MobilePhone nokiaN95 = new MobilePhone(
        "Nokia N95", "Nokia", 600, "John Doe",
        new Battery("Nokia Battery", TimeSpan.FromHours(10), TimeSpan.FromHours(5), Battery.BatteryType.LiIon),
        new Display("5.0 inches", "16M")
    );

        public static MobilePhone? NokiaN95
        {
            get
            {
                return nokiaN95;
            }
        }

        // Ch 14 No. 7
        public string? Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public string? Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }

        public double? Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string? Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }

        public Battery? BatteryFeatures
        {
            get
            {
                return batteryFeatures;
            }
            set
            {
                batteryFeatures = value;
            }
        }

        public Display? DispalyFeatures
        {
            get
            {
                return dispalyFeatures;
            }
            set
            {
                dispalyFeatures = value;
            }
        }

        

        // Ch 14 No. 9
        public MobilePhone()
        {
            this.model = null;
            this.manufacturer = null;
            this.price = 0;
            this.owner = null;
            this.batteryFeatures = null;
            this.dispalyFeatures = null;
        }
        public MobilePhone(string model, string manufacturer, double price, string owner, Battery batteryFeatures, Display screenFeatures)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.batteryFeatures = batteryFeatures;
            this.dispalyFeatures = screenFeatures;
        }

        public MobilePhone(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner= null;
            this.batteryFeatures= null;
            this.dispalyFeatures = null;
        }

        public MobilePhone(string model, string manufacturer)
        {
            this.model= model;
            this.manufacturer= manufacturer;
            this.price= 0;
            this.owner = null;
            this.batteryFeatures= null;
            this.dispalyFeatures = null;
        }

        public MobilePhone(string model)
        {
            this.model = model;
            this.manufacturer= null;
            this.price= 0;
            this.owner = null;
            this.batteryFeatures= null;
            this.dispalyFeatures = null;
        }

        // Ch 14 No.10
        public static void DisplayNokiaN95Info()
        {
            if (nokiaN95 != null)
            {
                Console.WriteLine(nokiaN95.ToString());
            }
        }

        public override string ToString()
        {
            return $"Model: {model}\nManufacturer: {manufacturer}\nPrice: {price}\nOwner: {owner}\n" +
                   $"Battery Model: {batteryFeatures?.Model}\nIdle Time: {batteryFeatures?.IdleTime}\n" +
                   $"Talk Time: {batteryFeatures?.HoursTalk}\nScreen Size: {dispalyFeatures?.Size}\n" +
                   $"Screen Colors: {dispalyFeatures?.Color}";
        }
    }
}
