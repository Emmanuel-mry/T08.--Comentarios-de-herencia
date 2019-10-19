using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
  public  class Cuenta
    {
        public int Numero{ get; set; }
        public string Titular { get; set; }
        public double  Saldo      { get; set; }
        public double Interes { get; set; }

        public bool Ingreso()
        {
            return false;
        }

        public double InteresPorMes(Cuenta interes) //Metodo para el dar el interes por mes
        {

            return (interes.Interes) * (interes.Saldo); //solo multiplico el interes de la lista por el saldo de la lista
        }
        public void   ConsultarSaldo(Cuenta cuenta) //Metodo dar el saldo
        {
            Console.WriteLine("Su saldo es de: " + cuenta.Saldo + "M");
            Console.ReadKey();
        }
        public void Transferir()
        {

        }
        
    }
}
