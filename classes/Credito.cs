using System;
namespace AulaPOO_Abstracao.classes
{
    public class Credito:Cartao
    {
      
        private float limite = 3000;

        public float Limite{
            get{return limite;}
            
        }
        
        public void Pagar(float valor){
            this.valor = valor;
            if(valor <=this.limite){
                int parcelas;
                do{
                Console.WriteLine("Selecione a quantidade de parcelas de 1 a 12");
                
                int parcelas = int.Parse(Console.ReadLine());
                }while(parcelas >12);

                float juros;
                if(parcelas<=6){
                    juros = 0.05f;

                }else{
                    juros = 0.08f;
                }
                float total = this.valor - (this.valor+ juros);

            }else{
                Console.WriteLine("Sem Limite!");
            }
            }
            public void ExibirNota(string titular, float total){
                Console.WriteLine($"Titular: {titular} - Valor da Compra = {total}");
            }
        }
    }

