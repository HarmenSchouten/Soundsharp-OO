using System;
using AudioDevices.Tracks;

namespace AudioDevices.Devices
{
    public abstract class DisplayAudioDevice : AudioDevice
    {
        private int displayWidth;
        private int displayHeight;

        public String GetResolutionInfo()
        {
            return "Resolution: " + TotalPixels + " pixels.";
        }

        public int DisplayWidth
        {
            get { return displayWidth; }
            set { displayWidth = value; }
        }

        public int DisplayHeight
        {
            get { return displayHeight; }
            set { displayHeight = value; }
        }

        public int TotalPixels
        {
            get { return displayWidth * displayHeight; }
        }
    }
}
