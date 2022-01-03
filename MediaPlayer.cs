using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JMCClient
{
    public partial class MediaPlayer : Form
    {
        //Globals
        private LinkedList<string> CurrentPlaylist = new LinkedList<string>();
        String[] mySavedPlaylists = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "\\My Playlists\\");

        public MediaPlayer()
        {
            InitializeComponent();
            StatusStripText.Text = "Welcome, add some songs and get playing.";

            //Playlist Management
            //Playlist Management
            System.IO.Directory.CreateDirectory("My Playlists");
            DisplayCollection();
            windowsPlayer.settings.volume = (int)VolumeControl.Value;
            VolumeControl.Value = 100;
        }

        private void DisplayCollection()
        {
            CurrentPlaylistListbox.Items.Clear();
            foreach (var track in CurrentPlaylist)
            {
                char[] separators = new char[] { '/', '\\' };
                string[] subs = track.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                int finalPiece = (subs.Length - 1);
                CurrentPlaylistListbox.Items.Add(subs[finalPiece]);
            }
            mySavedPlaylists = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "\\My Playlists\\");
            AllPlaylistsListbox.Items.Clear();
            foreach (var playlist in mySavedPlaylists)
            {
                char[] separators = new char[] { '/', '\\', '.' };
                string[] subs = playlist.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                int finalPiece = (subs.Length - 2);
                AllPlaylistsListbox.Items.Add(subs[finalPiece]);
            }
        }

        private void HighlightNowPlaying()
        {
            CurrentPlaylistListbox.SelectedIndex = CurrentPlaylistListbox.FindString(windowsPlayer.currentMedia.name);
        }

        private void ButtonAddTrack_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    try
                    {
                        CurrentPlaylist.AddLast(file);
                    }
                    catch
                    {
                        StatusStripText.Text = "Couldn't add song/s.";
                    }
                }
            }
            StatusStripText.Text = "Track/s Added";
            DisplayCollection();
        }

        private void ButtonRemoveTrack_Click(object sender, EventArgs e)
        {
            /* Stop Function exists due to current limitation of software which even if current playing track
             * is removed from "playlist" it will continue playing, then as it is removed, it causes issue
             * with 'Next' and 'Previous' track buttons. */
            windowsPlayer.Ctlcontrols.stop();
            try
            {
                CurrentPlaylist.Remove(CurrentPlaylist.ElementAt(CurrentPlaylistListbox.SelectedIndex));
                DisplayCollection();
                StatusStripText.Text = "Track removed";
            }
            catch
            {
                StatusStripText.Text = "Nothing to remove, or nothing selected.";
            }
        }

        private void CurrentPlaylistListbox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                windowsPlayer.URL = CurrentPlaylist.ElementAt(CurrentPlaylistListbox.SelectedIndex);
                StatusStripText.Text = "Now playing " + windowsPlayer.currentMedia.name;
                HighlightNowPlaying();
            }
            catch
            {
                StatusStripText.Text = "Double click on an imported item to play.";
            }
        }

        //LinkedList traversal controls
        #region Traversal
        private void ButtonFirstTrack_Click(object sender, EventArgs e)
        {
            try
            {
                windowsPlayer.URL = CurrentPlaylist.First.Value;
                StatusStripText.Text = "Now playing " + windowsPlayer.currentMedia.name;
                HighlightNowPlaying();
            }
            catch
            {
                StatusStripText.Text = "Error - No first song";
            }
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if ((CurrentPlaylist.Find(windowsPlayer.URL).Previous.Value) != null)
                {
                    windowsPlayer.URL = CurrentPlaylist.Find(windowsPlayer.URL).Previous.Value;
                    StatusStripText.Text = "Now playing " + windowsPlayer.currentMedia.name;
                    HighlightNowPlaying();
                }
            }
            catch
            {
                StatusStripText.Text = "Error - No previous song or start of collection";
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            try
            {
                if ((CurrentPlaylist.Find(windowsPlayer.URL).Next.Value) != null)
                {
                    windowsPlayer.URL = CurrentPlaylist.Find(windowsPlayer.URL).Next.Value;
                    StatusStripText.Text = "Now playing " + windowsPlayer.currentMedia.name;
                    HighlightNowPlaying();
                }
            }
            catch
            {
                StatusStripText.Text = "Error - No next song or end of collection.";
            }
        }

        private void ButtonLastTrack_Click(object sender, EventArgs e)
        {
            try
            {
                windowsPlayer.URL = CurrentPlaylist.Last.Value;
                StatusStripText.Text = "Now playing " + windowsPlayer.currentMedia.name;
                HighlightNowPlaying();
            }
            catch
            {
                StatusStripText.Text = "Error - No last song.";
            }
        }
        #endregion

        //New music controls to replace defaults
        #region MusicControls
        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (windowsPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    windowsPlayer.Ctlcontrols.pause();
                    StatusStripText.Text = "Music Paused";
                }
                else if (windowsPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    windowsPlayer.Ctlcontrols.play();
                    StatusStripText.Text = "Now playing " + windowsPlayer.currentMedia.name;
                }
                else
                {
                    windowsPlayer.URL = CurrentPlaylist.ElementAt(CurrentPlaylistListbox.SelectedIndex);
                    StatusStripText.Text = "Now playing " + windowsPlayer.currentMedia.name;
                }
            }
            catch
            {
                StatusStripText.Text = "Nothing to play, or nothing selected.";
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            try
            {
                windowsPlayer.Ctlcontrols.stop();
                StatusStripText.Text = "Music stopped";
            }
            catch
            {
                StatusStripText.Text = "Nothing to stop";
            }
        }
        #endregion

        private void SavePlaylistButton_Click(object sender, EventArgs e)
        {
            if (!PlaylistNameTextbox.Text.Equals(""))
            {
                String currentDir = System.IO.Directory.GetCurrentDirectory();
                using (var writer = new StreamWriter(currentDir + "\\My Playlists\\" + PlaylistNameTextbox.Text + ".csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteField("Playlist Tracks");
                    csv.NextRecord();

                    foreach (var track in CurrentPlaylist)
                    {
                        csv.WriteField(track);
                        csv.NextRecord();
                    }
                    writer.Flush();
                }

            }else
            {
                StatusStripText.Text = "Please input a name for your playlist.";
            }
            DisplayCollection();
        }

        private void AllPlaylistsListbox_DoubleClick(object sender, EventArgs e)
        { //Import previously saved playlist to current playlist
            try{
                //get csv
                int selected = AllPlaylistsListbox.SelectedIndex;
                String playlistSelected = mySavedPlaylists[selected];

                //read contents
                var tracks = new List<String>();
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = false,
                };
                using (var reader = new StreamReader(playlistSelected))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    while (csv.Read())
                    {
                        String track = csv.GetField(0);
                        tracks.Add(track);
                    }
                }
                //shove in current playlist
                CurrentPlaylist.Clear();
                foreach (var track in tracks)
                {
                    CurrentPlaylist.AddLast(track);
                }
                DisplayCollection();
            }
            catch
            {
                StatusStripText.Text = "Failed to import playlist.";
            }
        }

        private void VolumeValueChanged(object sender, EventArgs e)
        {
            windowsPlayer.settings.volume = (int)VolumeControl.Value;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            SortPlaylist();
            DisplayCollection();
        }

        public void SortPlaylist()
        {
            LinkedListNode<String> current, index;
            String temp;
            //Check whether list is empty  
            if (CurrentPlaylist.First == null)
            {
                return;
            }
            else
            {
                //Current will point to first  
                for (current = CurrentPlaylist.First; current.Next != null; current = current.Next)
                {
                    //Index will point to node next to current  
                    for (index = current.Next; index != null; index = index.Next)
                    {
                        //If current's data is greater than index's data, swap the data of current and index  
                        if (current.Value.CompareTo(index.Value) > 0)
                        {
                            temp = current.Value;
                            current.Value = index.Value;
                            index.Value = temp;
                        }
                    }
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SortPlaylist();
            DisplayCollection();
            BinarySearch();
        }

        private void BinarySearch()
        {
            if (SearchTextbox.Text == "")
            {
                StatusStripText.Text = "Please enter search term";
            }
            else
            {
                /*Primary search requires exact match with root string meaning it requires the full absolute path (which isnt displayed to user)
          * this is the reason for the backup search method
          */
                String searchTerm = SearchTextbox.Text;
                int sizeofLinkedList = CurrentPlaylist.Count();
                bool found = false;

                int lowerBound = 0;
                int upperBound = sizeofLinkedList;

                while (!found)
                {
                    if (upperBound <= lowerBound)
                    {
                        //searchTerm not found
                        StatusStripText.Text = "Search term not found in primary search";
                        break;
                    }

                    int mid = lowerBound + ((upperBound - lowerBound) / 2);

                    if (CurrentPlaylist.ElementAt(mid).CompareTo(searchTerm) < 0)
                    {
                        lowerBound = mid + 1;
                    }
                    if (CurrentPlaylist.ElementAt(mid).CompareTo(searchTerm) > 0)
                    {
                        upperBound = mid + 1;
                    }
                    if (CurrentPlaylist.ElementAt(mid).CompareTo(searchTerm) == 0)
                    {
                        //found at mid
                        found = true;
                        CurrentPlaylistListbox.SelectedIndex = mid;
                        StatusStripText.Text = "Found and highlighted";
                    }
                }//endwhile

                if (found == false)
                {
                    String[] playlistArray = new String[CurrentPlaylistListbox.Items.Count];
                    CurrentPlaylistListbox.Items.CopyTo(playlistArray, 0);
                    for (int i = 0; i < playlistArray.Length; i++)
                    {
                        if (playlistArray[i].Contains(searchTerm))
                        {
                            CurrentPlaylistListbox.SelectedIndex = i;
                            StatusStripText.Text = "Non-Exact match found in secondary search";
                            break;
                        }
                    }

                }//endif
            }
        }
    }
}
