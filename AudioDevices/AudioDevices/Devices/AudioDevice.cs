using System;

namespace AudioDevices.Devices
{
    public abstract class AudioDevice
    {
        protected int serialId;
        protected string model;
        protected string make;
        protected decimal priceExBtw;
        protected DateTime creationDate;
        protected readonly static double btwPercentage = 19.0;
        
        public string DisplayIdentity()
        {
            return "Serial: " + serialId;
        }
        
        public string DisplayIdentity(bool modelInfo, bool makeInfo)
        {
            String temp = DisplayIdentity();
            if (modelInfo)
            {
                temp += "\nModel: " + model;
            } else if (makeInfo)
            {
                temp += "\nMake: " + make;
            }
            return temp;
        }
        
        public String GetDeviceLifeTime()
        {
            if(creationDate != null)
            {
                DateTime currentDate = DateTime.Now;
                return "Lifetime: " + (currentDate - creationDate).TotalDays + " days";
            }
            else
            {
                return "Lifetime is unknown";
            }
        }

        public abstract string DisplayStorageCapacity();

        public int SerialId
        {
            get { return serialId; }
            set { serialId = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public decimal PriceExBtw
        {
            get { return priceExBtw; }
            set { priceExBtw = value; }
        }

        public decimal ConsumerPrice
        {
            get { return Decimal.Round(priceExBtw * (((decimal)btwPercentage / 100) + 1), 2, MidpointRounding.AwayFromZero); }
        }

        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
    }
}
