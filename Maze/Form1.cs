using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
            //this.MinimumSize = this.MaximumSize = this.Size;
        }

        private void Finish_lable_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Харош!!!");
            Form2 Form2 = new Form2();
            Form2.Show();

            //Hide();
        }
        private void MoveToStart()
        {
            Point start = panel1.Location;
            start.Offset(10, 10);
            Cursor.Position = PointToScreen(start);
        }

       

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

       
    }
}
