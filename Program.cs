using System;
using AulaPOO_Abstracao.classes;


namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {   
            

            Console.WriteLine("Digite o valor da compra");
            float valorDaCompra = float.Parse(Console.ReadLine());

            Console.WriteLine("Selecione o tipo de pagamento");
              Console.WriteLine("[1] Boleto");
                Console.WriteLine("[2] Cartao");
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                    Boleto boleto = new Boleto();
                    boleto.valor = valorDaCompra;
                    boleto.Registrar(boleto.valor, boleto.data, boleto.codigoDeBarras);
                break;

                case 2:
                     Console.WriteLine("Selecione o tipo de pagamento");
                     Console.WriteLine("[1] - Crédito");
                     Console.WriteLine("[2] - Débito");
                      int tipocard = int.Parse(Console.ReadLine());

                      switch(tipocard){
                          case 1:
                                Credito credito = new Credito();
                                credito.numero = "123245-12345-12345";
                                credito.bandeira="MasterCard";
                                credito.titular = "Carlos Tsukamoto";
                                credito.cvv = "123"
                                credito.Pagar(valorDaCompra);
                          break;

                          case 2:
                                Debito debito = new Debito();
                          break;

                      }
                }
            }
        }
    }
