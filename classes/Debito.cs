using System;

namespace AulaPOO_Abstracao.classes
{
    public class Debito:Cartao
    {
        private float saldo = 600;

        public void Pagar( ){
            Console.WriteLine("Compra Efetuada!");
        }
        public void ExibirNota(string titular, float total){
        Console.WriteLine($"Titular: {titular} - Valor da Compra = {total}")
    }
}