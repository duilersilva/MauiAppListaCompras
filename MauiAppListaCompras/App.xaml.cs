namespace MauiAppListaCompras
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ListaProduto());  

            //MainPage = new AppShell();

        }
    }
}
