
namespace JMCClient
{
    partial class MediaPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CurrentPlaylistListbox = new System.Windows.Forms.ListBox();
            this.RemoveTrackButton = new System.Windows.Forms.Button();
            this.AddTrackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PlaylistNameTextbox = new System.Windows.Forms.TextBox();
            this.SavePlaylistButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AllPlaylistsListbox = new System.Windows.Forms.ListBox();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.FirstTrackButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.lastTrackButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.windowsPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.VolumeControl = new System.Windows.Forms.NumericUpDown();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripText = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeControl)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SortButton);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.SearchTextbox);
            this.groupBox1.Controls.Add(this.CurrentPlaylistListbox);
            this.groupBox1.Controls.Add(this.RemoveTrackButton);
            this.groupBox1.Controls.Add(this.AddTrackButton);
            this.groupBox1.Location = new System.Drawing.Point(105, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Playlist";
            // 
            // CurrentPlaylistListbox
            // 
            this.CurrentPlaylistListbox.FormattingEnabled = true;
            this.CurrentPlaylistListbox.Location = new System.Drawing.Point(6, 82);
            this.CurrentPlaylistListbox.Name = "CurrentPlaylistListbox";
            this.CurrentPlaylistListbox.Size = new System.Drawing.Size(211, 303);
            this.CurrentPlaylistListbox.TabIndex = 0;
            this.CurrentPlaylistListbox.DoubleClick += new System.EventHandler(this.CurrentPlaylistListbox_DoubleClick);
            // 
            // RemoveTrackButton
            // 
            this.RemoveTrackButton.Location = new System.Drawing.Point(89, 19);
            this.RemoveTrackButton.Name = "RemoveTrackButton";
            this.RemoveTrackButton.Size = new System.Drawing.Size(88, 23);
            this.RemoveTrackButton.TabIndex = 3;
            this.RemoveTrackButton.Text = "Remove Track";
            this.RemoveTrackButton.UseVisualStyleBackColor = true;
            this.RemoveTrackButton.Click += new System.EventHandler(this.ButtonRemoveTrack_Click);
            // 
            // AddTrackButton
            // 
            this.AddTrackButton.Location = new System.Drawing.Point(6, 19);
            this.AddTrackButton.Name = "AddTrackButton";
            this.AddTrackButton.Size = new System.Drawing.Size(77, 23);
            this.AddTrackButton.TabIndex = 2;
            this.AddTrackButton.Text = "Add Track/s";
            this.AddTrackButton.UseVisualStyleBackColor = true;
            this.AddTrackButton.Click += new System.EventHandler(this.ButtonAddTrack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Playlist Name";
            // 
            // PlaylistNameTextbox
            // 
            this.PlaylistNameTextbox.Location = new System.Drawing.Point(340, 22);
            this.PlaylistNameTextbox.Name = "PlaylistNameTextbox";
            this.PlaylistNameTextbox.Size = new System.Drawing.Size(120, 20);
            this.PlaylistNameTextbox.TabIndex = 5;
            // 
            // SavePlaylistButton
            // 
            this.SavePlaylistButton.Location = new System.Drawing.Point(466, 20);
            this.SavePlaylistButton.Name = "SavePlaylistButton";
            this.SavePlaylistButton.Size = new System.Drawing.Size(75, 23);
            this.SavePlaylistButton.TabIndex = 4;
            this.SavePlaylistButton.Text = "Save Playlist";
            this.SavePlaylistButton.UseVisualStyleBackColor = true;
            this.SavePlaylistButton.Click += new System.EventHandler(this.SavePlaylistButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AllPlaylistsListbox);
            this.groupBox2.Location = new System.Drawing.Point(334, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 355);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Playlists";
            // 
            // AllPlaylistsListbox
            // 
            this.AllPlaylistsListbox.FormattingEnabled = true;
            this.AllPlaylistsListbox.Location = new System.Drawing.Point(6, 19);
            this.AllPlaylistsListbox.Name = "AllPlaylistsListbox";
            this.AllPlaylistsListbox.Size = new System.Drawing.Size(201, 329);
            this.AllPlaylistsListbox.TabIndex = 0;
            this.AllPlaylistsListbox.DoubleClick += new System.EventHandler(this.AllPlaylistsListbox_DoubleClick);
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.Location = new System.Drawing.Point(6, 19);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(75, 23);
            this.PlayPauseButton.TabIndex = 5;
            this.PlayPauseButton.Text = "Play/Pause";
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            this.PlayPauseButton.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(6, 48);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // FirstTrackButton
            // 
            this.FirstTrackButton.Location = new System.Drawing.Point(6, 77);
            this.FirstTrackButton.Name = "FirstTrackButton";
            this.FirstTrackButton.Size = new System.Drawing.Size(75, 23);
            this.FirstTrackButton.TabIndex = 7;
            this.FirstTrackButton.Text = "First Track";
            this.FirstTrackButton.UseVisualStyleBackColor = true;
            this.FirstTrackButton.Click += new System.EventHandler(this.ButtonFirstTrack_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(6, 106);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 8;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(6, 135);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 9;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // lastTrackButton
            // 
            this.lastTrackButton.Location = new System.Drawing.Point(6, 164);
            this.lastTrackButton.Name = "lastTrackButton";
            this.lastTrackButton.Size = new System.Drawing.Size(75, 23);
            this.lastTrackButton.TabIndex = 10;
            this.lastTrackButton.Text = "Last Track";
            this.lastTrackButton.UseVisualStyleBackColor = true;
            this.lastTrackButton.Click += new System.EventHandler(this.ButtonLastTrack_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.windowsPlayer);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.VolumeControl);
            this.groupBox3.Controls.Add(this.PlayPauseButton);
            this.groupBox3.Controls.Add(this.lastTrackButton);
            this.groupBox3.Controls.Add(this.StopButton);
            this.groupBox3.Controls.Add(this.NextButton);
            this.groupBox3.Controls.Add(this.FirstTrackButton);
            this.groupBox3.Controls.Add(this.PreviousButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(87, 392);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controls";
            // 
            // windowsPlayer
            // 
            this.windowsPlayer.Enabled = true;
            this.windowsPlayer.Location = new System.Drawing.Point(6, 376);
            this.windowsPlayer.Name = "windowsPlayer";
            this.windowsPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsPlayer.OcxState")));
            this.windowsPlayer.Size = new System.Drawing.Size(10, 10);
            this.windowsPlayer.TabIndex = 13;
            this.windowsPlayer.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Volume";
            // 
            // VolumeControl
            // 
            this.VolumeControl.Location = new System.Drawing.Point(12, 204);
            this.VolumeControl.Name = "VolumeControl";
            this.VolumeControl.Size = new System.Drawing.Size(59, 20);
            this.VolumeControl.TabIndex = 11;
            this.VolumeControl.ValueChanged += new System.EventHandler(this.VolumeValueChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripText});
            this.statusStrip.Location = new System.Drawing.Point(0, 413);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(559, 22);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip";
            // 
            // StatusStripText
            // 
            this.StatusStripText.Name = "StatusStripText";
            this.StatusStripText.Size = new System.Drawing.Size(84, 17);
            this.StatusStripText.Text = "StatusStripText";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(61, 50);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(156, 20);
            this.SearchTextbox.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(6, 48);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(49, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(180, 19);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(37, 23);
            this.SortButton.TabIndex = 6;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 435);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PlaylistNameTextbox);
            this.Controls.Add(this.SavePlaylistButton);
            this.Name = "MediaPlayer";
            this.Text = "Media Player";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeControl)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox CurrentPlaylistListbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox AllPlaylistsListbox;
        private System.Windows.Forms.Button AddTrackButton;
        private System.Windows.Forms.Button RemoveTrackButton;
        private System.Windows.Forms.Button SavePlaylistButton;
        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button FirstTrackButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button lastTrackButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripText;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlaylistNameTextbox;
        private AxWMPLib.AxWindowsMediaPlayer windowsPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown VolumeControl;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextbox;
    }
}