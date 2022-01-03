using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using wyDay.Controls;

/* Benjamin Wearn - P467480
 * 
 * 
 * 
 * 
 */


namespace JMCClient
{
    public partial class JMCClient : Form
    {
        private PipeClient pipeClient;
        ASCIIEncoding encoder = new ASCIIEncoding();
        public MediaPlayer MediaPlayer { get; private set; }
        public NameSorter NameSorter { get; private set; }

        public JMCClient()
        {
            InitializeComponent();
            CreateNewPipeClient();
            ButtonLogin.Enabled = false;
            ButtonDisconnect.Enabled = false;
            TextboxLoginName.Enabled = false;
            TextboxLoginPass.Enabled = false;
        }

        #region ButtonEvents
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            pipeClient.SendMessage(encoder.GetBytes(TextboxLoginName.Text + ":" + TextboxLoginPass.Text));
            TextboxLoginName.Clear();
            TextboxLoginPass.Clear();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            pipeClient.Connect(TextboxServerAddress.Text);

            if (pipeClient.Connected)
            {
                EnableDisconnectButton();
                DisableConnectButton();
                ListboxMessages.Items.Add("Connected");
                TextboxLoginName.Enabled = true;
                TextboxLoginPass.Enabled = true;
                ButtonLogin.Enabled = true;
            }
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                pipeClient.Disconnect();
                EnableConnectButton();
                DisableDisconnectButton();
                MediaPlayerButton.Enabled = false;
                NameSortLaunch.Enabled = false;
                ButtonLogin.Enabled = false;
                ButtonDisconnect.Enabled = false;
                TextboxLoginName.Enabled = false;
                TextboxLoginPass.Enabled = false;
                if(Application.OpenForms.OfType<MediaPlayer>().Count() == 1)
                {
                    MediaPlayer.Close();
                }
                if (Application.OpenForms.OfType<NameSorter>().Count() == 1)
                {
                    NameSorter.Close();
                }
                ListboxMessages.Items.Add("Disconnected");
            }
            catch
            {

            }
            
        }

        private void MediaPlayerButton_Click(object sender, EventArgs e)
        {
            //Launch Media Player
            MediaPlayer = new MediaPlayer();
            MediaPlayer.Show();
        }

        private void NameSortLaunch_Click(object sender, EventArgs e)
        {
            //Launch Name Sorter
            NameSorter = new NameSorter();
            NameSorter.Show();
        }
        #endregion

        #region PipeFunctionality
        void CreateNewPipeClient()
        {
            if (pipeClient != null)
            {
                pipeClient.MessageReceived -= PipeClient_MessageReceived;
                pipeClient.ServerDisconnected -= PipeClient_ServerDisconnected;
            }

            pipeClient = new PipeClient();
            pipeClient.MessageReceived += PipeClient_MessageReceived;
            pipeClient.ServerDisconnected += PipeClient_ServerDisconnected;
        }

        void PipeClient_ServerDisconnected()
        {
            Invoke(new PipeClient.ServerDisconnectedHandler(EnableConnectButton));
        }

        void PipeClient_MessageReceived(byte[] message)
        {
            Invoke(new PipeClient.MessageReceivedHandler(DisplayReceivedMessage),
                new object[] { message });
        }
        #endregion

        #region ConnectButtons
        void EnableConnectButton()
        {
            ButtonConnect.Enabled = true;
        }

        void DisableConnectButton()
        {
            ButtonConnect.Enabled = false;
        }

        void EnableDisconnectButton()
        {
            ButtonDisconnect.Enabled = true;
        }

        void DisableDisconnectButton()
        {
            ButtonDisconnect.Enabled = false;
        }
        #endregion

        #region Output
        void DisplayReceivedMessage(byte[] message)
        {
            ASCIIEncoding encoder = new ASCIIEncoding();
            string str = encoder.GetString(message, 0, message.Length);
            if (str.Equals("Login Succeeded"))
            {
                ButtonLogin.Enabled = false;
                MediaPlayerButton.Enabled = true;
                NameSortLaunch.Enabled = true;
                TextboxLoginName.Enabled = false;
                TextboxLoginPass.Enabled = false;
                ListboxMessages.Items.Add(str);

            }
            else if (str.Equals("Login Failed"))
            {
                ListboxMessages.Items.Add("Please try to login again.");
                ListboxMessages.Items.Add(str);
            }
            else
            {
                ListboxMessages.Items.Add(str);
            }
        }
        #endregion

        
    }
}
