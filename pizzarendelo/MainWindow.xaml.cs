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
        List<Pizza> rendelesek = new List<Pizza>();
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

		private void btn_rendel_Click(object sender, RoutedEventArgs e)
		{
			List<string> feltet = new List<string>();
			string atvet = "";
			bool validFeltet = false;
			bool validAtvet = false;
			if (lb_teszta.SelectedItem != null || cb_meret.SelectedItem != null)
			{
				foreach (var item in sp_feltet.Children)
				{
					if (item is CheckBox cb && cb.IsChecked == true)
					{
						validFeltet = true;
						feltet.Add(atvet);
					}
				}
				foreach (var item in sp_atvetel.Children)
				{
					if (item is CheckBox cb && cb.IsChecked == true)
					{
						validAtvet = true;
						atvet = item.ToString();
					}
				}
				if (validFeltet && validAtvet)
				{
					Pizza pizza = new Pizza(lb_teszta.SelectedItem.ToString(), cb_meret.SelectedItem.ToString(), feltet, atvet);
					rendelesek.Add(pizza);
					foreach (var item in rendelesek)
					{
						lb_rendeles.Content += item.ToString();
					}
				}
				else
				{
					MessageBox.Show("Hibás adatok");
				}
			}
			else
			{
				MessageBox.Show("Hibás adatok");
			}
		}
	}
}