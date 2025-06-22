namespace T2.Model
{
    public enum BusState
    {
        Disponivel,
        EmManuntencao,
        EmMovimento
    }


public class Colaborador
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public string Contacto { get; set; }
    
    // Chave estrangeira para Autocarro
    public string? AutocarroMatricula { get; set; }
    
    // Propriedade de navegação
    public Bus? Autocarro { get; set; }
}
    public class Bus
    {
        public int id { get; set; }
        public string Matricula { get; set; }
        public int Capacidade { get; set; }
        public BusState EstadoCarro { get; set; }

        public List<Colaborador> Colaboradores { get; set; } = new List<Colaborador>();

        public string estado => StringCarState(EstadoCarro);

        public Bus() { }
        public Bus(string matricula, int capacidade, BusState estado)
        {
            Matricula = matricula;
            Capacidade = capacidade;
            EstadoCarro = estado;
        }



        public string StringCarState(BusState estado) => estado switch
        {
            BusState.Disponivel => "Disponível",
            BusState.EmManuntencao => "Em manuntenção",
            BusState.EmMovimento => "Em movimento",
        };

    }
    

    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; } // "Admin", "Gestor", "Operador"
    }
}