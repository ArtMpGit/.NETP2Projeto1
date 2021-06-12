using GestaoGastos.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GestaoGastos.Data.Repository
{
    public class GastoRepository
    {
        private readonly DataContext _context;

        public GastoRepository(DataContext context)
        {
            _context = context;
        }

        public List<Gasto> GetAll()
        {
            return _context.Gasto.ToList();
        }

        public Gasto GetById(int id)
        {
            return _context.Gasto.Find(id);
        }

        public Gasto Create(Gasto gasto)
        {
            _context.Gasto.Add(gasto);
            _context.SaveChanges();

            return gasto;
        }

        public Gasto Update(Gasto gasto)
        {
        
            _context.Entry(gasto).State = EntityState.Modified;
            _context.SaveChanges();

            return gasto;
        }

        public string Delete(int id)
        {
            _context.Gasto.Remove(_context.Gasto.Find(id));
            _context.SaveChanges();

            return "Gasto removido com sucesso.";
        }
    }
}
