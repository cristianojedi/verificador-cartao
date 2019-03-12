using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace verificador_cartao
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            string numeroCartao = string.Empty;
            Cartao cartao = new Cartao(configuration);

            while (true)
            {
                Console.Clear();

                Console.Write(string.Concat(Mensagens.DigiteNumeroCartao, ": "));
                numeroCartao = Console.ReadLine();

                cartao.Numero = numeroCartao;

                if (!cartao.ValidarTamanhoNumero())
                    Console.WriteLine(Mensagens.DigiteNumeroMaximoCaracteres);
                else if (!cartao.EhNumero())
                    Console.WriteLine(Mensagens.DigiteApenasNumeros);
                else
                {
                    string mensagem = cartao.BuscarTipoCartao() + ": " + numeroCartao;
                    Console.WriteLine(cartao.EhValido() ? mensagem + " (" + Mensagens.CartaoValido + ")" : mensagem + " (" + Mensagens.CartaoInvalido + ")");
                }

                Console.ReadKey();
            }
        }
    }
}
