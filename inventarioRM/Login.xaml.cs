using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace inventarioRM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private const string Url = "http://192.168.18.53/rmInventario/post.php";
        private readonly HttpClient cliente = new HttpClient();
        private ObservableCollection<inventarioRM.WS.Datos> post;
        public Login()
        {
            InitializeComponent();
        }

        private async void btnInicio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Menu());

            Login log = new Login
            {
                //Usuario = txt
            };
        }
    }
}