namespace T2.Model
{
    public class Colaborador
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Cargo { get; set; }
        public int? AutocarroId { get; set; }
        public Autocarro? Autocarro { get; set; }
    }
}