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
            List<string> feltetek = new List<string>();
            string atvet = "";
            foreach (var item in sp_feltet.Children)
            {
                if (item is CheckBox cb && cb.IsChecked == true)
                {
                    feltetek.Add(cb.Content.ToString());
                }
            }
            foreach (var item in sp_atvetel.Children)
            {
                if (item is RadioButton rb && rb.IsChecked == true)
                {
                    atvet = rb.Content.ToString();
                }
            }
            Pizza newPizza = new Pizza(lb_teszta.SelectedItem.ToString(), cb_meret.SelectedItem.ToString(), feltetek, atvet);
            lb_rendeles.Text = newPizza.ToString();
		}
	}
}