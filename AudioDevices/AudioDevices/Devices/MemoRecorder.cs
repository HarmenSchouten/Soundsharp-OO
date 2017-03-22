using System;

namespace AudioDevices.Devices
{
    public class MemoRecorder : AudioDevice
    {
        private MemoCartridgeType maxCartridgeType;

        public MemoRecorder(int serialId)
        {
            this.serialId = serialId;
        }

        public override string DisplayStorageCapacity()
        {
            String temp = "Max capacity: ";
            switch (maxCartridgeType)
            {
                case MemoCartridgeType.C60:
                    temp += "60 min.";
                    break;
                case MemoCartridgeType.C90:
                    temp += "90min.";
                    break;
                case MemoCartridgeType.C120:
                    temp += "120min.";
                    break;
            }
            return temp;
        }

        public MemoCartridgeType MaxCartridgeType
        {
            get { return maxCartridgeType; }
            set { maxCartridgeType = value; }
        }
    }

    public enum MemoCartridgeType
    {
        C60,
        C90,
        C120,
        Unknown
    }
}
