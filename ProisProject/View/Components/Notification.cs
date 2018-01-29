using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProisProject.View.Components
{
    public partial class Notification : UserControl
    {
        public static int NORMAL = 5000;
        public static int LOW = 3000;
        public static int HIGHT = 10000;

        public Notification(String message, AlertType type, int duration = 2000)
        {
            InitializeComponent();
            this.notifyMsg.Text = message;
            switch (type) {
                case AlertType.ok:
                    this.BackColor = Color.FromArgb(67,160,71);
                    this.iconNotify.Image =  this.imgList.Images[0]; //rgb(67, 160, 71)
                    break;
                case AlertType.error:
                    this.BackColor = Color.FromArgb(244,67,54);
                    this.iconNotify.Image = this.imgList.Images[1];// rgb(244,67,54)
                    break;
                case AlertType.info:
                    this.BackColor = Color.FromArgb(21,101,192);//rgb(21,101,192)
                    this.iconNotify.Image = this.imgList.Images[2];
                    break;
                case AlertType.warm:
                    this.BackColor = Color.FromArgb(255,112,67);//rgb(255,112,67)
                    this.iconNotify.Image = this.imgList.Images[3];
                    break;
            }

            this.timeoutNotification.Enabled = true;
            this.timeoutNotification.Interval = duration;
            this.Dock = DockStyle.Fill;
            Index.PANELNOTIFY.Controls.Add(this);
            this.animateNotify.Show(Index.PANELNOTIFY);
          //  Index.PANELNOTIFY.Show();           
        }

        public static void Show(string m, AlertType type, int duration  = 3000) {
            new Notification(m, type, duration);
        }
    
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Index.PANELNOTIFY.Controls.Clear();
            Index.PANELNOTIFY.Hide();
            this.DestroyHandle();
            this.Dispose();
        }

        private void timeoutNotification_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Cerrando" + e.ToString());
            Index.PANELNOTIFY.Controls.Clear();
            Index.PANELNOTIFY.Hide();
            this.timeoutNotification.Enabled = false;
            this.Dispose();            
        }
    }

    public enum AlertType {
        ok, info, warm, error
    }
}
