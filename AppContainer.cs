using System;
using EasyTabs;

namespace DIU_Browser
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }
        private void AppContainer_Load(object sender, EventArgs e)
        {

        }
        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {Content = new frmBrowser
               {
                Text = "DIU Tab"
               }
            };

        }
    }
}
