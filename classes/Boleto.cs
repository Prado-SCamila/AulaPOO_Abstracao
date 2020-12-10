using System;
namespace AulaPOO_Abstracao.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras = "12345678.12345678.12345678.12345678";
        
       
        public override string Desconto(int valor){
            return "";
        }

        public void Registar(float valor,DateTime dataEmissao,string codigoDeBarras){

            Console.WriteLine($"O valor da compra fica em R${valor*0.88f}");
             Console.WriteLine($"Data de emissão: {dataEmissao}");
              Console.WriteLine($"O Código de barras é: {codigoDeBarras}");

        }
    }
}