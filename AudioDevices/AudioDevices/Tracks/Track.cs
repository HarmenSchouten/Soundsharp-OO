using System;
using System.Collections.Generic;

namespace AudioDevices.Tracks
{
    public class Track
    {
        private int id;
        private string name;
        private string artist;
        private string albumSource;
        private Category style;
        private Time length;

        public void TrackList()
        {
            List<Track> tracks = new List<Track>();
        }

        public void TrackList(List<Track> tracks)
        {

        }

        public Track(int id)
        {
            this.id = id;
        }

        public Track(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Track(int id, string artist, string name)
        {
            this.id = id;
            this.artist = artist;
            this.name = name;
        }

        public Time GetLength()
        {
            return length;
        }

        public int GetLengthInSeconds()
        {
            return length.Seconds + (length.Minutes * 60) + (length.Hours * 3600);
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public String DisplayName
        {
            get
            {
                if (Artist != null && Name != null)
                {
                    return Artist + " - " + Name;
                }
                else
                {
                    return "Unknown";
                }
            }
        }

        public Time Length
        {
            set { length = value; }
        }

        public String DisplayLength
        {
            get
            {
                return String.Format("{0}:{1}:{2}", length.Hours.ToString("D2"), length.Minutes.ToString("D2"),
                  length.Seconds.ToString("D2"));
            }
        }

        public Category Style
        {
            get { return style; }
            set { style = value; }
        }

        public String AlbumSource
        {
            get { return albumSource; }
            set { albumSource = value; }
        }
    }

        public class Time
        {
            private int hours;
            private int minutes;
            private int seconds;

            public Time(int seconds)
            {
                this.seconds = (seconds % 3600) % 60;
                this.minutes = ((seconds % 3600) / 60) % 60;
                this.hours = (((seconds % 3600) / 60) / 60) + (seconds / 3600);
            }

            public Time(int minutes, int seconds)
            {
                this.seconds = (seconds % 3600) % 60;
                this.minutes = (minutes + ((seconds % 3600) / 60)) % 60;
                this.hours = ((minutes + ((seconds % 3600) / 60)) / 60) + (seconds / 3600);
            }

            public Time(int hours, int minutes, int seconds)
            {
                this.seconds = (seconds % 3600) % 60;
                this.minutes = (minutes + ((seconds % 3600) / 60)) % 60;
                this.hours = hours + ((minutes + ((seconds % 3600) / 60)) / 60) + (seconds / 3600);
            }

            public override string ToString()
            {
                return String.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
            }

            public int Hours
            {
                get { return hours; }
                set { hours = value; }
            }

            public int Minutes
            {
                get { return minutes; }
                set { minutes = value; }
            }

            public int Seconds
            {
                get { return seconds; }
                set { seconds = value; }
            }
        }

    public enum Category
    {
        Ambient,
        Blues,
        Country,
        Disco,
        Electro,
        Hardcore,
        HardRock,
        HeavyMetal,
        Hiphop,
        Jazz,
        Jumpstyle,
        Klassiek,
        Latin,
        Other,
        Pop,
        Punk,
        Reggae,
        Rock,
        Soul,
        Trance,
        Techno
    }
}
