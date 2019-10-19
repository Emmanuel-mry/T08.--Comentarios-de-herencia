using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    class RepoBanco:Cuenta
    {
        DatosCuenta ad; //se declaro globalmente ad para poder usarlo en todos los metodos
        public RepoBanco()

        {
          
            ad = new DatosCuenta(); //Instancia de la clase datos cuenta
        }
        internal void Principal()
        {
            Console.WriteLine("BIENVENIDO A SU BANCO "); //Bienvenida
            Menu();//LLamada del metodo menu
        }
        private void Menu() //Se despliega un menu para que el cliente elija que quiere realizar
        {
            Console.WriteLine("SELECCIONE LA OPERACION QUE DESEA REALIZAR");
            Console.WriteLine();
            Console.WriteLine("1) Cuenta Corriente");
            Console.WriteLine("2) Pensiones");
            Console.WriteLine("3) Cuenta Ahorro");
            Console.WriteLine("4) Salir");



            switch (Console.ReadLine()) //Case para selecionar la opcion
            {
                case "1":
                    {
                        Console.WriteLine("----CUENTA DE AHORRO----");
                        ObtenerDatosAhorro();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("----PENSIONES----");
                        ObtenerDatosPension();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("---CUENTA CORRIENTE---");
                        ObtenerDatosCorriente();
                        break;
                    }
                case "4":

                    break;


                default:
                    break;


            }
        }
        private int ObtenerDatos()  //Metodo para obtener el numero de cuenta del cliente
        {
            Console.WriteLine("Ingrese su numero de cuenta");
            string res = Console.ReadLine();
            return Convert.ToInt32(res);
        }
        private void ObtenerDatosCorriente() //Metodo para la operaciones de CuentaCorriente
        {
            int numero = ObtenerDatos();

            var lista = ad.Corrientes();
            CuentaCorriente p = new CuentaCorriente();


            foreach (var cuenta in lista)
            {
                if (numero == cuenta.Numero)
                {
                    p = cuenta;

                }

            }
            Console.WriteLine("Bienvenido" + p.Titular);
            MenuUsuario(p);


        }
        private void ObtenerDatosPension() //Metodo para las operaciones de Pension
        {
            int numero = ObtenerDatos();
            var lista = ad.Pension();
            Pensiones p = new Pensiones();


            foreach (var cuenta in lista)
            {
                if (numero == cuenta.Numero)
                {
                    p = cuenta;

                }

            }
            Console.WriteLine("Bienvenido" + p.Titular);
            MenuUsuario(p);
                

            
            
        }
        public void MenuUsuario(Cuenta p) //Menu para que el usuario elija que opcion desea realizar sobre su pension
        {
            Console.Clear();
            Console.WriteLine("BIENVENIDO A TU CUENTA:" + " " + p.Titular);
            Console.WriteLine("SELECCIONE LA OPCION QUE DESEA REALIZAR");
            Console.WriteLine();
            Console.WriteLine("1) Consultar Saldo");
            Console.WriteLine("2) Tranferir");
            Console.WriteLine("3) Interes x Mes");
            Console.WriteLine("4) Ingreso");
           
            Console.WriteLine("Elije una Opcion");

            switch (Convert.ToInt16(Console.ReadLine())) //La respuesta la puso directamente en el swicth en vez de una variables
            {
                case 1:
                    p.ConsultarSaldo(p);
                    break;
                case 2:
                    p.InteresPorMes(p);
                    break;
                case 3:
                    p.Ingreso();
                    break;
                case 4:
                    p.Transferir();
                    break;
                default:
                    break;
            }

        }

        private void ObtenerDatosAhorro()
        {
            int numero = ObtenerDatos();

            var lista = ad.Ahorros();
            CuentaAhorro p = new CuentaAhorro();


            foreach (var cuenta in lista)
            {
                if (numero == cuenta.Numero)
                {
                    p = cuenta;

                }

            }
            Console.WriteLine("Bienvenido" + p.Titular);
            MenuUsuario(p);


        }
    }
}
