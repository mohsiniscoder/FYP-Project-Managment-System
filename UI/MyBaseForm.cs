using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Salvation.UI
{
    public partial class MyBaseForm : Form
    {
        public MyBaseForm()
        {
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void MyBaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
