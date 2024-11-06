using Windows.Web.Http.Headers;
using static System.Net.Mime.MediaTypeNames;

namespace kot
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            imgkot.Source = new UriImageSource
            {
                Uri = new Uri("https://cataas.com/cat")

            };
        }
        private void OnCounterClicked2(object sender, EventArgs e)
        {
            imgkot_gift.Source = new UriImageSource
            {
                Uri = new Uri("https://cataas.com/cat/gif")
            };
        }
        private void OnCounterClicked3(object sender, EventArgs e)
        {
            string kot_size = kotki1.Text;
            string kot_text = kotki.Text;

            imgkot_text.Source = new UriImageSource
            {
                Uri = new Uri("https://cataas.com/cat/says/" + kot_text + "?fontSize=" + kot_size)
            };
        }
        private void OnCounterClicked4(object sender, EventArgs e)
        {
            imgkot_filtr.Source = new UriImageSource
            {
                Uri = new Uri("https://cataas.com/cat?filter=mono")
            };

        }
    }
}
