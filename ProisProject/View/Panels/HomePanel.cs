using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProisProject.View.Panels
{
    public partial class HomePanel : UserControl
    {
        public HomePanel()
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(btnShowDoctor, "Doctores");
        }
    }
}
