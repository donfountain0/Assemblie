using Assemblie_New.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assemblie_New
{
    public partial class NotesForm : Form
    {

        bool mousedown;
        public NotesForm()
        {
            InitializeComponent();
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {

        }

        private void TopBarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void TopBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {

                WindowState = FormWindowState.Maximized;
                MaximizeButton.Image = Resources.minimize;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                MaximizeButton.Image = Resources.maximize;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}
