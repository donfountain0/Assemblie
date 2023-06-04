using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.IO;
using Microsoft.Web.WebView2.WinForms;
using System.Diagnostics;
using Assemblie_New.Properties;
using Microsoft.Web.WebView2.Wpf;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Printing;
using System.Reflection.PortableExecutable;
using ControlManager;
using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ControlManager.ControlMoverOrResizer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Assemblie_New
{
    public partial class Form1 : Form
    {
        bool mousedown;
        bool mousehover;

        bool sidebarExpand;
        int currentWebViewWidth;
        int currentWebViewHeight;



        public Form1()
        {
            InitializeComponent();
            InitializeAsync();
            ControlMoverOrResizer.Init(NotesMenu);
            ControlMoverOrResizer.Init(webView22);
            ControlMoverOrResizer.Init(CalendarPanel);





            //formBorderShadow.SetShadowForm(this);
        }
        /*private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {

                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }*/
        async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);



        }


        //Beginning of Sliding Menu Operations

        //Timer for Sliding Menu
        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //if sidebar is expanded, minimize
                SideBarPanel.Width -= 10;
                if (SideBarPanel.Width == SideBarPanel.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    MenuLogo.Visible = false;
                    MenuButton.Dock = DockStyle.Left;
                    MenuButton.Size = new Size(77, 121);
                    // meetingMenuButton.Image = Resources.expand_more1;
                    webView21.Location = new Point(198, 69);
                    SideBarTimer.Stop();

                }
            }
            else
            {
                SideBarPanel.Width += 10;
                if (SideBarPanel.Width == SideBarPanel.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    MenuLogo.Visible = true;
                    MenuButton.Dock = DockStyle.None;
                    MenuButton.Size = new Size(35, 38);
                    webView21.Location = new Point(300, 69);
                    // meetingMenuButton.Image = Resources.expand_less;
                    SideBarTimer.Stop();
                }
            }
        }


        private void MenuButton_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        //End of Sliding Menu Operations

        //Begining of Mouse Operations

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

        private void GoogleMeetButton_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://meet.google.com");
        }

        private void ZoomButton_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://zoom.us/join");
        }

        private void TeamsButton_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.microsoft.com/en-us/microsoft-teams/join-a-meeting");
        }

        private void WebExButton_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://web.webex.com/join-meeting");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {


            if (WindowState == FormWindowState.Normal)
            {

                WindowState = FormWindowState.Maximized;
                MaximizeButton.Image = Resources.minimize;
                /*                webView21.MinimumSize = new Size(Convert.ToInt32(this.Width * 0.60), Convert.ToInt32(this.Height * 0.70));
                */
            }
            else
            {
                WindowState = FormWindowState.Normal;
                MaximizeButton.Image = Resources.maximize;
                /*webView21.MinimumSize = new Size(384, 352);*/
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Hovers
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            mousehover = true;
            if (mousehover == true) { ExitButton.BackColor = Color.FromArgb(168, 101, 21); }
        }
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            mousehover = false;
            if (mousehover == false) { ExitButton.BackColor = Color.Transparent; };

        }


        private void MaximizeButton_MouseEnter(object sender, EventArgs e)
        {
            mousehover = true;
            if (mousehover == true) { MaximizeButton.BackColor = Color.FromArgb(168, 101, 21); }
        }
        private void MaximizeButton_MouseLeave(object sender, EventArgs e)
        {
            mousehover = false;
            if (mousehover == false) { MaximizeButton.BackColor = Color.Transparent; };
        }


        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            mousehover = true;
            if (mousehover == true) { MinimizeButton.BackColor = Color.FromArgb(168, 101, 21); }
        }
        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            mousehover = false;
            if (mousehover == false) { MinimizeButton.BackColor = Color.Transparent; };
        }

        private void PencilButton_Click(object sender, EventArgs e)
        {
            NotesForm nf = new NotesForm();
            nf.Show();
        }



        /*private void NotesMenu_MouseEnter(object sender, EventArgs e)
        {
            mousedown = true;

            if (mousedown && NotesMenu.Size.Height > 125)
            {


                Debug.WriteLine(NotesMenu.Size.Height);
            }
        }*/

        private void CalendarRefresh_Click(object sender, EventArgs e)
        {
            webView22.CoreWebView2.Navigate("https://calendar.google.com");
        }

        private void MeetingExpandButton_Click(object sender, EventArgs e)
        {
            CalendarExpanded nf = new CalendarExpanded();
            nf.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Text Files (.txt)|*.txt";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }



        //End Hovers

    }
}