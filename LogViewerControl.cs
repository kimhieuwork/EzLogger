using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzLogger
{
    public partial class LogViewerControl : UserControl
    {
        public LogViewerControl()
        {
            InitializeComponent();
        }
        public void Log(string message, LogLevel level = LogLevel.Info)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Log(message, level)));
                return;
            }

            Color color = Color.White;
            switch (level)
            {
                case LogLevel.Info:
                    color = Color.Green;
                    break;
                case LogLevel.Warning:
                    color = Color.Yellow;
                    break;
                case LogLevel.Error:
                    color = Color.Red;
                    break;
                case LogLevel.Debug:
                    color = Color.Blue;
                    break;
            }

            _rtb.SelectionStart = _rtb.TextLength;
            _rtb.SelectionColor = color;
            _rtb.AppendText($"{DateTime.Now:HH:mm:ss} [{level}] {message}\n");
            _rtb.ScrollToCaret();
        }
    }
}
