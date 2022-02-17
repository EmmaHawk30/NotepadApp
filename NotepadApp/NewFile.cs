using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadApp
{
    public partial class NewFile : Form
    {
        public NewFile()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //if yes is selected, open a new notepad form
            NotePad newNP = new NotePad();
            this.Hide();
            newNP.Show();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //if 'no' is selected, app closes
            this.Hide();
            Close();
        }
    }
}
