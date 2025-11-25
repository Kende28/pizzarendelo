using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pizzarendelo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> tesztak = new List<string>()
        {
            "Vékony",
            "Normál",
			"Extra vastag"
		};
        List<string> meretek = new List<string>()
        {
            "Kicsi",
            "Közepes",
            "Nagy"
        };
		public MainWindow()
        {
            InitializeComponent();
		    PizzaUIBetoltes();
		}

        private void PizzaUIBetoltes()
        {
			lb_teszta.ItemsSource = tesztak;
            cb_meret.ItemsSource = meretek;
            cb_meret.Text = meretek[0];
		}
    }
}