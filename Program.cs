using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIU_Browser.Properties;
using EasyTabs;

namespace DIU_Browser
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
                File.WriteAllBytes("Bunifu_UI_v1.52.dll", Resources.Bunifu_UI_v1_52);
                File.WriteAllBytes("Guna.UI2.dll", Resources.Guna_UI2);
                File.WriteAllBytes("DIU.dll", Resources.DIU);
                string TargetPath;
                TargetPath = "C:\\ProgramData\\DIU\\DIU.zip";
               // System.IO.Compression.ZipFile.ExtractToDirectory(TargetPath, System.AppDomain.CurrentDomain.BaseDirectory);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                AppContainer container = new AppContainer();
                container.Tabs.Add(
                    new TitleBarTab(container)
                    {
                        Content = new frmBrowser
                        {
                            Text = "DIU Tab"
                        }

                    }
                    );
                container.SelectedTabIndex = 0;
                TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
                applicationContext.Start(container);
                Application.Run(applicationContext);
     

        }
    }
}
