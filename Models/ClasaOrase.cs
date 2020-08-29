using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MersTrenuri.Models
{
    public class ClasaOrase
    {
        public ClasaOrase()
        {
            GetOrase();
        }
        public List<string> Orase = new List<string>();
        public string Label;
        public string statiePlecare { get; set; }
        public string statieSosire { get; set; }

        public EnumStatii statie { get; set; }

        public List<string> GetOrase ()
        {
            Orase.Clear();
            Orase.AddRange(new string[] { "Alba-Iulia", "Brasov", "Bucuresti", "Craiova", "Cluj-Napoca", "Oradea", "Sibiu", "Timisoara" });
            return Orase;
        }

    }
}
