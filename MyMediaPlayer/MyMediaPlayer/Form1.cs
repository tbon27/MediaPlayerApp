using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Button Event Handler
        private void button1_Click(object sender, EventArgs e)
        {
            //File path
            string fpath = "";
            try
            {
                //Create open file dialog for opening input video or audio file
                OpenFileDialog _fileDialog = new OpenFileDialog();

                //Set the title for gile dialog
                _fileDialog.Title = "Browse Media File";

                //Set the filter - optional one 
                _fileDialog.Filter = "MP4 Video (*.mp4)|*.mp4|WMV Video (*.wmv)|*.wmv|Quick Movie File(*.mov)|*.mov|All Files (*.*)|*.*";

                //Display the file dialog
                DialogResult _status = _fileDialog.ShowDialog();

                //Verify whether the user selects file or not using DialogResult constant value
                if (_status == DialogResult.OK)
                {
                    //Get the selected file path
                    fpath = _fileDialog.FileName;

                    //Set the selected inut file path to Textbox 'ss'
                    ss.Text = fpath;

                    //Set this path to WindowsMediaPlayer Control named '_mPlayer' using its URL property
                    _mPlayer.URL = fpath;

                    //Start the media player by setting the following boolean to true --> WMP auto start property
                    _mPlayer.settings.autoStart = true;
                }

            }

            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                
            }
        }
    }
}
