using System;
namespace AulaPOO_Abstracao.classes
{
    public class Boleto : Pagamento
    {
        private string codigodebarras;
        
       
        public override string Desconto(int valor){
            return "";
        }

        public void Registar(){
            Console.WriteLine("Registrado");

        }
    }
}