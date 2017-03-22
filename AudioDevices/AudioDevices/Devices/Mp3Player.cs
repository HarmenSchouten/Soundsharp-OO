using AudioDevices.Tracks;

namespace AudioDevices.Devices
{
    public class Mp3Player : DisplayAudioDevice
    {

        private TrackList<Track> trackList;
        private int mbSize = 0;

        public Mp3Player(int serialId)
        {
            this.serialId = serialId;
        }

        public bool HasTracks()
        {
            return trackList != null && trackList.Count > 0;
        }

        public void AddTrackList(TrackList<Track> trackList)
        {
            this.trackList = trackList;
        }

        public void RemoveTrackList()
        {
            trackList = null;
        }

        public override string DisplayStorageCapacity()
        {
            return mbSize > 0 ? (mbSize + " mb.") : "Storage capacity unknown";
        }

        public int MbSize
        {
            get { return mbSize; }
            set { mbSize = value; }
        }

        public TrackList<Track> TrackList
        {
            get { return trackList; }
        }
    }
}
