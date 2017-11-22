using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        private List<Cliente> clientes;

        public Program()
        {
            clientes = new List<Cliente>();
        }

        private void CadastrarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        private double CalculaIdadeMedia()
        {
            double soma = 0;

            foreach(var cliente in clientes)
            {
                soma += cliente.Idade;
            }

            return soma / clientes.Count;
        }

        private void RemoveCliente(string cpf)
        {
            Cliente toRemove = new Cliente() { Cpf = cpf };

            clientes.Remove(toRemove);

            //Cliente found = FindCliente(cpf);

            //if (found != null)
            //{
            //    clientes.Remove(found);
            //}
        }

        //private Cliente FindCliente(string cpf)
        //{
        //    //int i = 0;
        //    //Cliente found = null;
        //    //while (i < clientes.Count && found == null)
        //    //{
        //    //    if (clientes[i].Cpf.Equals(cpf))
        //    //    {
        //    //        found = clientes[i];
        //    //    }
        //    //    i++;
        //    //}

        //    //return found;

        //    foreach (var cliente in clientes)
        //    {
        //        if (cliente.Cpf.Equals(cpf))
        //        {
        //            return cliente;
        //        }
        //    }

        //    return null;
        //}

        private void ListarClientes()
        {
            Console.WriteLine("Listagem de Clientes");
            Console.WriteLine("------------------------------------");
            int i = 1;
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"==Cliente {i}==");
                Console.WriteLine($"Nome = {cliente.Nome}");
                Console.WriteLine($"Cpf = {cliente.Cpf}");
                Console.WriteLine($"Idade = {cliente.Idade}");
                Console.WriteLine($"Endereço = {cliente.Endereco}");
                Console.WriteLine();
                i++;
            }
        }

        private Cliente ShowMenuCadastrar()
        {
            Console.Clear();
            Console.Write("Entre com o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Entre com o cpf do cliente: ");
            string cpf = Console.ReadLine();

            Console.Write("Entre com a idade do cliente: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Entre com o endereço do cliente: ");
            string endereco = Console.ReadLine();

            return new Cliente(nome, cpf, idade, endereco);
        }

        private string GetClienteCpf()
        {
            Console.Write("Entre com o cpf do cliente que você deseja remover: ");
            string cpf = Console.ReadLine();

            return cpf;
        }

        public void ShowMainMenu()
        {
            int op = -1;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1 - Cadastrar novo cliente");
                Console.WriteLine("2 - Remover cliente");
                Console.WriteLine("3 - Listar clientes");
                Console.WriteLine("4 - Calcular média das idades");
                Console.WriteLine("5 - Sair");

                Console.WriteLine("Entre com a opção desejada");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Cliente cliente = ShowMenuCadastrar();
                        CadastrarCliente(cliente);
                        break;
                    case 2:
                        string cpf = GetClienteCpf();
                        RemoveCliente(cpf);
                        break;
                    case 3:
                        ListarClientes();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                        double media = CalculaIdadeMedia();
                        Console.WriteLine($"Média das idades = {media}");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
            while (op != 5);
        }
        static void Main(string[] args)
        {
            var p = new Program();
            
            p.ShowMainMenu();
        }
    }
}
