using Xamarin.Forms;
using System.Threading.Tasks;
using System;
using System.Net.Http;

namespace AppT
{
    public partial class App : Application
    {        
       // public static YmlCatalog Catalog { get; private set; }
        public App()
        {
            InitializeComponent();            
            MainPage = new MainPage(new HtppClientService());                     
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
