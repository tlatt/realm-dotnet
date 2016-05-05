using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace JSONimport
{
    public partial class PreviewJSON : ContentPage
    {
        public PreviewJSON()
        {
            var app = (App)(Application.Current);
            BindingContext = app.Model;
            InitializeComponent();
        }
    }
}

