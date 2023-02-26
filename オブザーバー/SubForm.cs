using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace オブザーバー
{
    public partial class SubForm : Form,INotify
    {
        public SubForm()
        {
            InitializeComponent();

            this.Disposed += SubForm_Disposed;
            StartPosition = FormStartPosition.CenterScreen;
            //WarningTimer.WarningAction += WarningTimer_WarningAction;
        }

        public void Update(bool isWarning)
        {
            this.Invoke((Action)delegate ()
            {
                if (isWarning)
                {
                    WarningLabel.Text = "警報";
                    WarningLabel.BackColor = Color.Red;
                }
                else
                {
                    WarningLabel.Text = "正常";
                    WarningLabel.BackColor = Color.Lime;
                }
            });
        }

        private void SubForm_Disposed(object sender, EventArgs e)
        {
            //WarningTimer.WarningAction -= WarningTimer_WarningAction;
            Program.WarningTimer.Remove(this);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Program.WarningTimer.Add(this);
            }
            else
            {
                Program.WarningTimer.Remove(this);
            }
        }

    
    }
}
