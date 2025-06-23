namespace T2.Model
{

    // Modelo do Colaborador
    public class Colaborador
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string NomeUsuario { get; set; }
        public required string Cargo { get; set; }
        public int AutocarroId { get; set; }
    }



    // Modelo do Autocarro
    public enum EstadoAutocarro
    {
        Disponivel,
        EmManuntencao,
        EmMovimento
    }
    public class Autocarro
    {
        public int id { get; set; }
        public string Matricula { get; set; }
        public int Capacidade { get; set; }
        public EstadoAutocarro EstadoCarro { get; set; }

        public List<Colaborador> Colaboradores { get; set; } = new List<Colaborador>();

        public string estado => StringCarState(EstadoCarro);

        public Autocarro() { }
        public Autocarro(string matricula, int capacidade, EstadoAutocarro estado)
        {
            Matricula = matricula;
            Capacidade = capacidade;
            EstadoCarro = estado;
        }


        public string StringCarState(EstadoAutocarro estado) => estado switch
        {
            EstadoAutocarro.Disponivel => "Disponível",
            EstadoAutocarro.EmManuntencao => "Em manuntenção",
            EstadoAutocarro.EmMovimento => "Em movimento",
        };

    }
    

    // Modelo do Usuário
    public class Usuario
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string NomeUsuario { get; set; }
        public required string Senha { get; set; }
        public required string TipoUsuario { get; set; } // "Admin", "Gestor", "Operador"
    }
}