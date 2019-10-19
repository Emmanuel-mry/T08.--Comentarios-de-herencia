using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    class DatosCuenta
    {
      
        public List<Pensiones> Pension() //En este metodo vamos a crear una lista para los datos de los clientes de pensiones
        {
            List<Pensiones> Pension = new List<Pensiones>();

            Pension.Add(new Pensiones { Numero = 12345, Titular = "Antonio Lopez Juarez    ", Saldo = 12.00 , Interes = 2.21, Cotizacion = 25, NCuentaPrincipal = 12346, Expiracion = Convert.ToDateTime("15/10/24") });
            Pension.Add(new Pensiones { Numero = 12346 , Titular = "Raquel Rodriguez Millan  ", Saldo = 58.30 , Interes = 2.21, Cotizacion = 25, NCuentaPrincipal = 12347, Expiracion = Convert.ToDateTime("15/10/24") });
            Pension.Add(new Pensiones { Numero = 12347 , Titular = "Ana Valadez Martinez     ", Saldo =  5.00 , Interes = 2.21, Cotizacion = 25, NCuentaPrincipal = 12348, Expiracion = Convert.ToDateTime("15/10/24") });
            Pension.Add(new Pensiones { Numero = 12348 , Titular = "Sergio Melendez Reyes  ", Saldo = 99.99 , Interes = 2.21, Cotizacion = 25, NCuentaPrincipal = 12349, Expiracion = Convert.ToDateTime("15/10/24") });

            return Pension; 

        }
        public List<CuentaAhorro> Ahorros() //En este metodo vamos a crear una lista para los datos de los clientes de CuentaAhorro
        {
            List<CuentaAhorro> Ahorros = new List<CuentaAhorro>();
            Ahorros.Add(new CuentaAhorro { Numero = 12345, Titular = "Antonio Lopez Juarez    ", Saldo = 12.00, Interes = 2.21, Expiracion = Convert.ToDateTime("15/10/24") });
            Ahorros.Add(new CuentaAhorro { Numero = 12346, Titular = "Raquel Rodriguez Millan  ", Saldo = 58.30, Interes = 2.21, Expiracion = Convert.ToDateTime("15/10/24") });
            Ahorros.Add(new CuentaAhorro { Numero = 12347, Titular = "Ana Valadez Martinez     ", Saldo = 5.00, Interes = 2.21, Expiracion = Convert.ToDateTime("15/10/24") });
            Ahorros.Add(new CuentaAhorro { Numero = 12348, Titular = "Sergio Melendez Reyes  ", Saldo = 99.99, Interes = 2.21,  Expiracion = Convert.ToDateTime("15/10/24") });

            return Ahorros;
        }
        public List<CuentaCorriente> Corrientes()//En este metodo vamos a crear una lista para los datos de los clientes de cuentaCorriente
        {
            List<CuentaCorriente> Corrientes = new List<CuentaCorriente>();
            Corrientes.Add(new CuentaCorriente { Numero = 12345, Titular = "Antonio Lopez Juarez    ", Saldo = 12.00, Interes = 2.21, Cotizacion = 25, NCuentaPrincipal = 12346, Expiracion = Convert.ToDateTime("15/10/24") });
            Corrientes.Add(new CuentaCorriente { Numero = 12346, Titular = "Raquel Rodriguez Millan  ", Saldo = 58.30, Interes = 2.21, Cotizacion = 25, NCuentaPrincipal = 12347, Expiracion = Convert.ToDateTime("15/10/24") });
            Corrientes.Add(new CuentaCorriente { Numero = 12347, Titular = "Ana Valadez Martinez     ", Saldo = 5.00, Interes = 2.21, Cotizacion = 25, NCuentaPrincipal = 12348, Expiracion = Convert.ToDateTime("15/10/24") });
            Corrientes.Add(new CuentaCorriente { Numero = 12348, Titular = "Sergio Melendez Reyes  ", Saldo = 99.99, Interes = 2.21, Cotizacion = 25, NCuentaPrincipal = 12349, Expiracion = Convert.ToDateTime("15/10/24") });

            return Corrientes;
        }
    }
}
