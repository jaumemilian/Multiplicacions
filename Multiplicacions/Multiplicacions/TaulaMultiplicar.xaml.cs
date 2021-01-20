using Multiplicacions.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Multiplicacions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaulaMultiplicar : ContentPage
    {
        public TaulaMultiplicar(Taula taula)
        {
            InitializeComponent();

            TaulaMultiplicarListView.ItemsSource = taula.Linees;
        }
    }
}