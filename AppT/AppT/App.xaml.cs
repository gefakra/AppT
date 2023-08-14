using Xamarin.Forms;
using System.Threading.Tasks;

namespace AppT
{
    public partial class App : Application
    {        
        public static yml_catalog Catalog { get; private set; }
        public App()
        {
            InitializeComponent();            
            MainPage = new MainPage();
            GetCatolog();            
        }

        private void GetCatolog()
        {
            var content = new HttpConext();
            Task.Run(async () => 
            { 
                Catalog = await content.GetContent();
            }).Wait();           
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
