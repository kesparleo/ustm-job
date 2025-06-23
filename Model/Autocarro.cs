namespace T2.Model
{
    public enum EstadoAutocarro
    {
        Disponivel,
        EmManutencao,
        EmMovimento
    }

    public class Autocarro
    {
        public int Id { get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
        public required string Matricula { get; set; }
        public int Lotacao { get; set; }
        public EstadoAutocarro Estado { get; set; }
        public List<Colaborador> Colaboradores { get; set; } = new List<Colaborador>();

        public string EstadoDisplay => Estado switch
        {
            EstadoAutocarro.Disponivel => "Disponível",
            EstadoAutocarro.EmManutencao => "Em Manutenção",
            EstadoAutocarro.EmMovimento => "Em Movimento",
            _ => "Desconhecido"
        };
    }
}