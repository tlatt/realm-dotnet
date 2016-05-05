using System;
using Realms;
using System.Diagnostics;
using Xamarin.Forms;
using System.Windows.Input;

namespace JSONimport
{
    public class JSONimportModel
    {
        public Realm TheRealm { get; set; } 
        public string VisibleJson { get; set; }
        public ICommand DoImport { get; private set; }

        public JSONimportModel()
        {
            TheRealm = Realm.GetInstance("JSONstash");
            VisibleJson = "";  
            DoImport = new Command(() => {
            });
        }
    }
}

