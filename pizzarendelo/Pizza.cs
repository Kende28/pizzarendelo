using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzarendelo
{
    class Pizza
    {
        public string Teszta { get; set; }
        public string Meret { get; set; }
        public List<string> Feltet { get; set; } = new List<string>();
        public string Atvetel { get; set; }

        public Pizza (string teszta, string meret, List<string> feltet, string atvetel)
        {
            Teszta = teszta;
            Meret = meret;
            Feltet = feltet;
            Atvetel = atvetel;
		}

        public override string ToString()
        {
            string feltetek = string.Join(", ", Feltet);
            return $"Tészta: {Teszta}, Méret: {Meret}, Feltétek: {feltetek}, Átvétel: {Atvetel}";
		}
	}
}
