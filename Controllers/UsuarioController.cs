using T2.Model;
using T2.Db;
using Microsoft.EntityFrameworkCore;

namespace T2.Controllers
{
    public class UsuarioController
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void ExcluirUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }

        public List<Usuario> ListarUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario? AutenticarUsuario(string username, string senha)
        {
            return _context.Usuarios
                .FirstOrDefault(u => u.Username == username && u.Senha == senha);
        }
    }
}