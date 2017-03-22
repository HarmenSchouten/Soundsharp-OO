using System;
using System.Collections.Generic;

namespace AudioDevices.Tracks
{
    public class TrackList<T> : List<T>
    {
        public TrackList<T> GetShuffledList()
        {
            TrackList<T> tempList = new TrackList<T>();
            TrackList<T> randomList = new TrackList<T>();
            Random r = new Random();
            foreach (T track in this)
            {
                tempList.Add(track);
            }

            for (int i = tempList.Count; i > 0; i--)
            {
                int index = r.Next(i);
                randomList.Add(tempList[index]);
                tempList.RemoveAt(index);
            }
            return randomList;
        }

        public void Amount()
        {
            int i = 0;
            foreach (T number in this)
            {
                i++;
            }
            Console.WriteLine("There are {0} tracks in this tracklist", i);
        }

        public Time GetTotalTime()
        {
            if (typeof(T) == typeof(Track))
            {
                int totalTime = 0;
                foreach (T type in this)
                {
                    object obj = type;
                    Track track = (Track)obj;
                    totalTime += track.GetLengthInSeconds();
                }
                return new Time(totalTime);
            }
            return new Time(0);
        }
    }
}
