
using System;
namespace AulaPOO_Abstracao.classes
{
    public abstract class Pagamento
    {
        private DateTime data;

        public DateTime Data{
            get{return data;}
        }

        protected float valor;

        private string desconto;

        public string Cancelar(){
           
            return "";
        }

        public abstract string Desconto(int valor);
        }
    }
