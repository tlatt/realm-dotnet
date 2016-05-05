using System;

using Xamarin.Forms;

namespace JSONimport
{
    public class App : Application
    {
        public JSONimportModel Model { get; set; }

        public App()
        {
            Model = new JSONimportModel();

            // The root page of your application
            var content = new TabbedPage {
                Title = "JSONimport"
            };
            content.Children.Add(new PreviewJSON());
            content.Children.Add(new ImportPage());

            MainPage = content;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

