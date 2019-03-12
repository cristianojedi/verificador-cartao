using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace verificador_cartao
{
    public class Cartao
    {
        private readonly IConfiguration _configuration;

        public Cartao(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Numero { get; set; }

        public bool ValidarTamanhoNumero()
        {
            return Numero.Length <= 16;
        }

        public bool EhNumero()
        {
            long numero = 0;

            return long.TryParse(Numero, out numero);
        }

        private bool ValidarTipoCartao()
        {
            switch (Numero.Length)
            {
                case 13: // VISA
                    return _configuration[Mensagens.TipoCartaoVisa].Contains(Numero.Substring(0, 1));
                case 15: // AMEX
                    return _configuration[Mensagens.TipoCartaoAmex].Contains(Numero.Substring(0, 2));
                case 16: // VISA, MASTERCARD e DISCOVER
                    bool ehVisa = _configuration[Mensagens.TipoCartaoVisa].Contains(Numero.Substring(0, 1));
                    bool ehMastercard = _configuration[Mensagens.TipoCartaoMastercard].Contains(Numero.Substring(0, 2));
                    bool ehDiscover = _configuration[Mensagens.TipoCartaoDiscover].Contains(Numero.Substring(0, 4));

                    return ehDiscover || ehMastercard || ehVisa;
                default:
                    return false;
            }
        }

        private string InverterNumero()
        {
            return new string(Numero.Reverse().ToArray());
        }

        private int DobrarDigito(int digito)
        {
            return digito * 2;
        }

        private int SomarDigito(int digito)
        {
            return 1 + digito % 10;
        }

        public string BuscarTipoCartao()
        {
            switch (Numero.Length)
            {
                case 13:
                    if (_configuration[Mensagens.TipoCartaoVisa].Contains(Numero.Substring(0, 1)))
                        return Mensagens.TipoCartaoVisa;
                    break;
                case 15:
                    if (_configuration[Mensagens.TipoCartaoAmex].Contains(Numero.Substring(0, 2)))
                        return Mensagens.TipoCartaoAmex;
                    break;
                case 16:
                    if (_configuration[Mensagens.TipoCartaoVisa].Contains(Numero.Substring(0, 1)))
                        return Mensagens.TipoCartaoVisa;
                    else if (_configuration[Mensagens.TipoCartaoMastercard].Contains(Numero.Substring(0, 2)))
                        return Mensagens.TipoCartaoMastercard;
                    else if (_configuration[Mensagens.TipoCartaoDiscover].Contains(Numero.Substring(0, 4)))
                        return Mensagens.TipoCartaoDiscover;
                    break;
            }

            return Mensagens.TipoCartaoDesconhecido;
        }

        public bool EhValido()
        {
            string numeroAlterado = string.Empty;
            int digito = 0;
            int numeroDobrado = 0;
            int numeroSomado = 0;
            int soma = 0;

            // 1) Tome uma sequência de números inteiros positivos e a inverta
            numeroAlterado = InverterNumero();

            // 2) Começando pelo segundo número, dobre o valor de cada número de forma alternada
            for (int i = 0; i < numeroAlterado.Length; i++)
            {
                if (i % 2 == 1)
                {
                    digito = int.Parse(numeroAlterado.Substring(i, 1));
                    numeroDobrado = DobrarDigito(digito);

                    // 3) Para dígitos maiores que 9 será necessário que some cada dígito ("10", 1 + 0 = 1) ou subtraia por 9 ("10", 10 - 9 = 1)
                    if (numeroDobrado >= 10)
                    {
                        numeroSomado = 1 + numeroDobrado % 10;
                    }
                    else
                    {
                        numeroSomado = numeroDobrado;
                    }

                    // 4) Some todos os números da sequência
                    soma += numeroSomado;
                }
                else
                {
                    digito = int.Parse(numeroAlterado.Substring(i, 1));

                    // 4) Some todos os números da sequência
                    soma += digito;
                }
            }

            return soma % 10 == 0;
        }
    }
}
