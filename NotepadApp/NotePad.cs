using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadApp
{
    public partial class NotePad : Form
    {
        public NotePad()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {           
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.FileName = "TextFile"; //sets default file name
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                
                if(!File.Exists(path))
                {
                    using(StreamWriter sw = File.CreateText(path))
                    {
                        for(int i = 0; i < rtbText.Lines.Length; i++)
                        {
                            sw.WriteLine(rtbText.Lines[i]);
                        }
                    }
                }
                else if (File.Exists(path))
                {
                    using(StreamWriter sw = File.CreateText(path))
                    {
                        for(int i = 0; i < rtbText.Lines.Length; i++)
                        {
                            sw.WriteLine(rtbText.Lines[i]);
                        }
                    }
                }
            }

            //display NewFile form - asks user if they want to open a new notepad file
            NewFile nf = new NewFile();
            nf.Show();
            this.Hide();

            
        }
    }
}
