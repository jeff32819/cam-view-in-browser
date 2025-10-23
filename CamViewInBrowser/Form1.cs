using System.Windows.Forms;

namespace CamViewInBrowser
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(); // ensure CoreWebView2 is ready
            webView21.CoreWebView2.Navigate("http://192.168.4.79/view/viewer_index.shtml?id=5");
        }
    }
}
