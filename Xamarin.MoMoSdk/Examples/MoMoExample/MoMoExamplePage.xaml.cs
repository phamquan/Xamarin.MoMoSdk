using System;
using MoMoExample.Services;
using Xamarin.Forms;

namespace MoMoExample
{
    public partial class MoMoExamplePage : ContentPage
    {

        IMoMoService _service;

        public MoMoExamplePage()
        {
            InitializeComponent();

            _service = DependencyService.Get<IMoMoService>();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                _service.PayExample();
            }
            catch(Exception ex)
            {
                this.DisplayAlert("Alert", ex.Message, "OK");
            }
        }
    }
}
