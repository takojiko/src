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
    public partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();

            this.Disposed += SubForm_Disposed;
            StartPosition = FormStartPosition.CenterScreen;
            //WarningTimer.WarningAction += WarningTimer_WarningAction;
            WarningTimer.Add(WarningTimer_WarningAction);
        }

        private void SubForm_Disposed(object sender, EventArgs e)
        {
            //WarningTimer.WarningAction -= WarningTimer_WarningAction;
            WarningTimer.Remove(WarningTimer_WarningAction);
        }

        private void WarningTimer_WarningAction(bool isWarning)
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
    }
}
