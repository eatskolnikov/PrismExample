using Prism.Unity;
using Xamarin.Forms;

namespace PrismExample
{
    public partial class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("PrismExamplePage?title=Hola%20Mundo");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<PrismExamplePage>();
        }
    }
}
