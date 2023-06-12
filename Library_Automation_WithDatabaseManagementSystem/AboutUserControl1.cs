using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation_WithDatabaseManagementSystem
{
    public partial class AboutUserControl1 : UserControl
    {
        private static AboutUserControl1 _instance;

        public static AboutUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AboutUserControl1();
                }
                return _instance;
            }
        }
        public AboutUserControl1()
        {
            InitializeComponent();
        }
    }
}
