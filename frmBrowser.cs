using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIU_Browser
{
    public partial class frmBrowser : Form
    {
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentTabs as TitleBarTabs);
            }
        }
        public frmBrowser()
        {
            InitializeComponent();
        }

        private async void frmBrowser_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate("https://www.google.com/");
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void webView21_Click_1(object sender, EventArgs e)
        {

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            if(webView21.CanGoBack) webView21.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoForward) webView21.GoForward();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.google.com/");
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            webView21.Refresh();
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchBar.Text.Trim().Length > 0)
            {
                if (SearchBar.Text.Contains("."))
                {
                    webView21.CoreWebView2.Navigate(SearchBar.Text.Trim());
                }
                else
                {
                    webView21.CoreWebView2.Navigate("https://www.google.com/search?q=" + SearchBar.Text.Trim().Replace(" ", "+"));

                }

            }
        }

        private void SearchBar_Enter(object sender, EventArgs e)
        {
            if (SearchBar.Text.Trim().Length > 0)
            {
                if (SearchBar.Text.Contains("."))
                {
                    webView21.CoreWebView2.Navigate(SearchBar.Text.Trim());
                }
                else
                {
                    webView21.CoreWebView2.Navigate("https://www.google.com/search?q=" + SearchBar.Text.Trim().Replace(" ", "+"));

                }

            }
        }
    }
}
