using T2.Model;
using T2.Db;
using Microsoft.EntityFrameworkCore;

namespace T2.Controllers
{
    public class AutocarroController
    {
        private readonly AppDbContext _context;

        public AutocarroController(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarAutocarro(Autocarro autocarro)
        {
            _context.Autocarros.Add(autocarro);
            _context.SaveChanges();
        }

        public void ActualizarAutocarro(Autocarro autocarro)
        {
            _context.Autocarros.Update(autocarro);
            _context.SaveChanges();
        }

        public void ExcluirAutocarro(int id)
        {
            var autocarro = _context.Autocarros.Find(id);
            if (autocarro != null)
            {
                _context.Autocarros.Remove(autocarro);
                _context.SaveChanges();
            }
        }

        public List<Autocarro> ListarAutocarros()
        {
            return _context.Autocarros.Include(a => a.Colaboradores).ToList();
        }
    }
}