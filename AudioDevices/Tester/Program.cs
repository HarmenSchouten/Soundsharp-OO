using System;
using AudioDevices.Tracks;
using AudioDevices.Devices;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Track t1 = new Track(1, "Prince", "Guitar");
            t1.Length = new Time(4, 12);
            Track t2 = new Track(2, "Nelly Furtado", "Say it Right");
            t2.Length = new Time(4, 41);
            Track t3 = new Track(3, "David Guetta & Chris Willis", "Love is gone");
            t3.Length = new Time(3, 50);
            TrackList<Track> trackList = new TrackList<Track>();
            trackList.Add(t1);
            trackList.Add(t2);
            trackList.Add(t3);
            foreach (Track track in trackList)
            {
                Console.WriteLine(track.DisplayName);
                Console.WriteLine(track.DisplayLength);
                Console.WriteLine("Tijd in seconden: {0}", track.GetLengthInSeconds());
                Console.WriteLine("Category: {0}", track.Style.ToString());
                Console.WriteLine("");
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("----- PRESS ENTER TO SHUFFLE ------");
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();
            TrackList<Track> shuffleList = trackList.GetShuffledList();
            foreach (Track track in shuffleList)
            {
                Console.WriteLine(track.DisplayName);
                Console.WriteLine(track.DisplayLength);
                Console.WriteLine("Tijd in seconden: {0}", track.GetLengthInSeconds());
                Console.WriteLine("Category: {0}", track.Style.ToString());
                Console.WriteLine("");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----- PRESS ENTER TO SEE THE AMOUNT OF TRACKS ------");
            Console.WriteLine("----------------------------------------------------");
            Console.ReadLine();
            trackList.Amount();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----- PRESS ENTER TO SEE THE TOTAL TIME ------------");
            Console.WriteLine("----------------------------------------------------");
            Console.ReadLine();
            Console.WriteLine("The total time of all the tracks in this list is: " + trackList.GetTotalTime());
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----- PRESS ENTER TO CONTINUE TO MEMORECORDERS -----");
            Console.WriteLine("----------------------------------------------------");
            Console.ReadLine();
            MemoRecorder memo = new MemoRecorder(1000);
            memo.MaxCartridgeType = MemoCartridgeType.C90;
            memo.Make = "Sony";
            memo.Model = "FE190";
            memo.PriceExBtw = 129.95M;
            memo.CreationDate = DateTime.Now.AddMonths(-6);
            Console.WriteLine(memo.DisplayIdentity(true, true));
            Console.WriteLine(memo.DisplayStorageCapacity());
            Console.WriteLine("Consumer price: {0:f2}", memo.ConsumerPrice);
            Console.WriteLine(memo.GetDeviceLifeTime());
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----- PRESS ENTER TO CONTINUE TO CDDISKMANS --------");
            Console.WriteLine("----------------------------------------------------");
            Console.ReadLine();
            CdDiscMan discman = new CdDiscMan(10);
            discman.Make = "JVC";
            discman.Model = "HG-410";
            discman.PriceExBtw = 149.00M;
            discman.DisplayWidth = 320;
            discman.DisplayHeight = 160;
            discman.CreationDate = DateTime.Parse("12-2-2006");
            Console.WriteLine(discman.DisplayIdentity(true, true));
            Console.WriteLine("Opslag capacity {0}", discman.DisplayStorageCapacity());
            Console.WriteLine("Display resolution {0} pixels", discman.TotalPixels);
            Console.WriteLine(discman.GetResolutionInfo());
            Console.WriteLine("Consumer price: {0:f2}", discman.ConsumerPrice);
            Console.WriteLine(discman.GetDeviceLifeTime());
            Console.WriteLine("Eject status: {0}", discman.IsEjected);
            discman.Eject();
            Console.WriteLine("Eject status: {0}", discman.IsEjected);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----- PRESS ENTER TO CONTINUE TO MP3PLAYERS --------");
            Console.WriteLine("----------------------------------------------------");
            Console.ReadLine();
            Mp3Player player = new Mp3Player(1000);
            player.Make = "Creative";
            player.Model = "Alpha";
            player.PriceExBtw = 99.00M;
            player.DisplayWidth = 120;
            player.DisplayHeight = 80;
            player.CreationDate = DateTime.Parse("1-1-2007");
            player.MbSize = 1024;
            player.AddTrackList(trackList);
            Console.WriteLine(player.DisplayStorageCapacity());
            Console.WriteLine(player.DisplayIdentity());
            Console.WriteLine(player.DisplayIdentity(true, false));
            Console.WriteLine(player.DisplayIdentity(false, true));
            Console.WriteLine(player.DisplayIdentity(true, true));
            Console.WriteLine(player.GetDeviceLifeTime());
            Console.WriteLine(player.ConsumerPrice);
            foreach (Track track in player.TrackList.GetShuffledList())
            {
                Console.WriteLine(track.DisplayName);
                Console.WriteLine(track.DisplayLength);
                Console.WriteLine(track.Style);
                Console.WriteLine("");
            }
            Console.WriteLine(player.TotalPixels);
            Console.WriteLine(player.MbSize);
            Console.WriteLine(player.HasTracks() ? "Has Tracks" : "Doesn't have tracks");
            player.RemoveTrackList();
            Console.WriteLine(player.HasTracks() ? "Has Tracks" : "Doesn't have tracks");
            Console.WriteLine(trackList.GetTotalTime());
            Console.ReadLine();
        }
    }
}
