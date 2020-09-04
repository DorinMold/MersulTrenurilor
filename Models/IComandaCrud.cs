using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MersTrenuri.Models
{
    public interface IComandaCrud
    {
        public Task<Comanda> AdaugareComanda(Comanda comanda);

        public Task<Comanda> AnulareComanda(int id);

        public Comanda GasireComanda(int id);
        public string EditSalvare(Comanda comanda);

        public IEnumerable<Comanda> ArataComenzi();

    }
}
