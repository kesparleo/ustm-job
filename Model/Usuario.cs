namespace T2.Model
{
    public enum TipoUsuario
    {
        Admin,
        Gestor,
        Operador
    }

    public class Usuario
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Username { get; set; }
        public required string Senha { get; set; }
        public required TipoUsuario TipoUsuario { get; set; }
    }
}