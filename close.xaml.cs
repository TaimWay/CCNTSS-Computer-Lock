using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CCNTSS_Computer_Lock
{
    /// <summary>
    /// close.xaml 的交互逻辑
    /// </summary>
    public partial class close : Window
    {
        public close()
        {
            InitializeComponent();
            while (true)
            {
                Close_Program();
            }
        }

        private void Close_Program()
        {
            Process[] myProgress;
            myProgress = Process.GetProcesses();　　　　　　　　　　//获取当前启动的所有进程
            foreach (Process p in myProgress)　　　　　　　　　　　　//关闭当前启动的Excel进程
            {
                if (p.ProcessName == "explorer")　　　　　　　　　　//通过进程名来寻找
                {
                    p.Kill();
                    return;
                }
            }

        }
    }
}
