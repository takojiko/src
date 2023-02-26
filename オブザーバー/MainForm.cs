using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace オブザーバー
{

    public partial class MainForm : Form
    {
        private MainViewModel _vm = 
            new MainViewModel(Dispatcher.CurrentDispatcher,
                Program.WarningTimer);
        public MainForm()
        {
            InitializeComponent();

            this.Disposed += MainForm_Disposed;
            StartPosition = FormStartPosition.CenterScreen;

            //WarningTimer.WarningAction += WarningTimer_WarningAction;
            WarningLabel.DataBindings.Add(
                "Text", _vm, nameof(_vm.WarningLabelText));
        }

        private void MainForm_Disposed(object sender, EventArgs e)
        {
            _vm?.Dispose();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            var f = new SubForm();
            f.Show();
        }

       
    }
}
