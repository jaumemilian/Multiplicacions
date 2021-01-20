using Multiplicacions.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Multiplicacions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Taules : ContentPage
    {
        public Taules()
        {
            InitializeComponent();

            var taulesMultiplicar = new[]
            {
                new Taula(1),
                new Taula(2),
                new Taula(3),
                new Taula(4),
                new Taula(5),
                new Taula(6),
                new Taula(7),
                new Taula(8),
                new Taula(9)
            };

            TaulesMultiplicar.ItemsSource = taulesMultiplicar;
        }

        private async void TaulesMultiplicar_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new TaulaMultiplicar((Taula) e.Item), true);
        }
    }
}