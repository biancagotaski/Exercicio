namespace ConsoleApp2
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public Cliente(string nome, string cpf, int idade, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Idade = idade;
            Endereco = endereco;
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;

            if (cliente == null || !cliente.Cpf.Equals(Cpf))
            {
                return false;
            }

            return true;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
    }
}
