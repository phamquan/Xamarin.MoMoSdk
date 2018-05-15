using Xamarin.Forms;
using Xamarin.MoMoSdk;

namespace MoMoExample
{
    public partial class MoMoExamplePage : ContentPage
    {
        public MoMoExamplePage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            MoMoSdk.Current.PayExample();
        }
    }
}
