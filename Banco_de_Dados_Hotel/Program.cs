using System.Net.Http.Json;

namespace Banco_de_Dados_Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dados[] dados = new Dados[10];
            Console.Write("Digite a quantidade de Clientes: ");
            int quantidade = int.Parse(Console.ReadLine());
            //Coletando Imformaçoes 
            for(int i = 0; i < quantidade; i++)
            {
                string? cliente;
                string? email;
                string? cpf;
                do
                {
                    //Coletade Imformaçoes Basicas 
                    Console.Clear();
                    Console.WriteLine($"Aluguel #{i + 1}");
                    Console.Write($"Nome: ");
                    cliente = Console.ReadLine();
                    Console.Write("Email: ");
                    email = Console.ReadLine();
                    Console.Write("CPF: ");
                    cpf = (Console.ReadLine());
                    if(cliente == null || email == null || cpf == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Perdecha todos dos topicos !!! ");
                        Task.Delay(500).Wait();
                    }
                } while (cliente == null || email == null || cpf == null);
                //Verificando Quarto Disponivel 
                int quarto;
                do
                {
                    Console.Write("Quarto");
                    quarto = int.Parse(Console.ReadLine());
                    if(dados[quarto] != null)
                    {
                        Console.WriteLine("Quarto ocuapdo escolha outro !!");                                                 
                    }
                } while (dados[quarto] != null);
                //quarto disponivel Emcerindo imformaçoes 
                dados[quarto] = new Dados(cliente,email,cpf);
                Console.Clear();
            }
            //Printar informaçoes Cadastradas 
            for(int i = 0; i < dados.Length; i++)
            {
                if (dados[i] != null)
                {
                    Console.WriteLine($"{i}: " + dados[i]);
                }
            }
        }
    }
}
