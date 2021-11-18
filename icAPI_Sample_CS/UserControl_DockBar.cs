using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICApiAddin.icAPI_Sample_CS
{
    public partial class UserControl_DockBar : UserControl
    {
        public UserControl_DockBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ユーザコントロール上のボタン！");
        }
    }
}
