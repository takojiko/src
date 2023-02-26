using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace オブザーバー
{
    public class MainViewModel : INotifyPropertyChanged,
        INotify,IDisposable
    {
        WarningTimerBase _warningTimerBase;
        Dispatcher _dispatcher;
        public MainViewModel(Dispatcher dispatcher,
            WarningTimerBase warningTimerBase)
        {
            _dispatcher = dispatcher;
            _warningTimerBase = warningTimerBase;

            _warningTimerBase.Add(this);
        }

        public void Dispose()
        {
            _warningTimerBase.Remove(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string _warningLabelText = "AAA";
        public string WarningLabelText
        {
            get { return _warningLabelText; }
            set
            {
                if (_warningLabelText != value)
                {
                    _warningLabelText = value;

                    if (_dispatcher == null)
                    {
                        PropertyChanged?.Invoke(
                            this,
                            new PropertyChangedEventArgs("WarningLabelText"));
                    }
                    else
                    {
                        _dispatcher.Invoke((Action)delegate ()
                        {
                            PropertyChanged?.Invoke(
                                                 this,
                                                 new PropertyChangedEventArgs("WarningLabelText"));

                        });
                    }
                }
            }
        }

        public void Update(bool isWarning)
        {
            if (isWarning)
            {
                WarningLabelText = "警報";
                //WarningLabel.BackColor = Color.Red;
            }
            else
            {
                WarningLabelText = "正常";
                //WarningLabel.BackColor = Color.Lime;
            }
        }

       
    }
}
