﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace inventarioRM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnProducto_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CrearProducto());
        }

        private void btnIngresoPro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IngresoProducto());
        }

        private void btnSalidaPro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SalidaProducto());
        }
    }
}