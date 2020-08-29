﻿using MersTrenuri.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MersTrenuri.Models
{
    public class ComandaCrud : IComandaCrud
    {
        private AppDbContext _context { get; set; }
        public ComandaCrud (AppDbContext context)
        {
            _context = context;
        }
        public async Task<Comanda> AdaugareComanda(Comanda comanda)
        {
            if (!(comanda is null))
            {
                await _context.Comenzi.AddAsync(comanda);
                await _context.SaveChangesAsync();
            }

            return comanda;
        }

        public async Task<Comanda> AnulareComanda (int id)
        {
            Comanda comanda = await _context.Comenzi.FindAsync(id);
            _context.Comenzi.Remove(comanda);
            await _context.SaveChangesAsync();
            return comanda;
        }

        public Comanda GasireComanda (int id)
        {
            return _context.Comenzi.Find(id);
        }

        public string EditSalvare ( Comanda argComanda )
        {
           try
            {
                _context.Comenzi.Update(argComanda);
                _context.SaveChanges();
            } catch (DbUpdateConcurrencyException)
            {
                if ( !ComandaExista(argComanda.Id) )
                {
                    return "Negasit";
                } else
                {
                    throw;
                }
            }

            return "Actualizat";
        }
        private bool ComandaExista(int id)
        {
            return _context.Comenzi.Any(e => e.Id == id);
        }
    }
}