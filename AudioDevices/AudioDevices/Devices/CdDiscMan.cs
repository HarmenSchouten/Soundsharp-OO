using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Devices;

namespace AudioDevices.Devices
{
    public class CdDiscMan : DisplayAudioDevice
    {
        private readonly int mBSize = 700;
        private Boolean isEjected = false;

        public CdDiscMan(int serialId)
        {
            this.serialId = serialId;
        }

        public override string DisplayStorageCapacity()
        {
            return "This CdDiscMan has an MB-size of " + mBSize;
        }

        public void Eject()
        {
            isEjected = !isEjected;
        }

        public int MbSize
        {
            get { return mBSize; }
        }

        public bool IsEjected
        {
            get { return isEjected; }
        }
    }
}
