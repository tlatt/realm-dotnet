using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JSONimport
{
    public partial class ImportPage : ContentPage
    {
        public ImportPage()
        {
            var app = (App)(Application.Current);
            BindingContext = app.Model;
            InitializeComponent();
        }
    }
}

