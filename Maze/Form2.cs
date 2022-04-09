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
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void Finish_lable_MouseEnter_1(object sender, EventArgs e)
        {
            MessageBox.Show("Харош!!!");
            Form2 Form3 = new Form2();
            Form3.Show();
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
