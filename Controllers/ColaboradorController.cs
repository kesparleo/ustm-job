using T2.Model;
using T2.Db;
using Microsoft.EntityFrameworkCore;

namespace T2.Controllers
{
    public class ColaboradorController
    {
        private readonly AppDbContext _context;

        public ColaboradorController(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarColaborador(Colaborador colaborador)
        {
            _context.Colaboradores.Add(colaborador);
            _context.SaveChanges();
        }

        public void ActualizarColaborador(Colaborador colaborador)
        {
            _context.Colaboradores.Update(colaborador);
            _context.SaveChanges();
        }

        public void ExcluirColaborador(int id)
        {
            var colaborador = _context.Colaboradores.Find(id);
            if (colaborador != null)
            {
                _context.Colaboradores.Remove(colaborador);
                _context.SaveChanges();
            }
        }

        public List<Colaborador> ListarColaboradores()
        {
            return _context.Colaboradores.Include(c => c.Autocarro).ToList();
        }
    }
}