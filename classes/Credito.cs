using System;
namespace AulaPOO_Abstracao.classes
{
    public class Credito:Cartao
    {
        private float limite = 3000;
        
        public void Pagar(){
            Console.WriteLine("Efetuar Pagamento");
        }
    }
}