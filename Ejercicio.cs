using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad02
{
    class Ejercicio
    {
        public void IngresarDatos()
        {
            List<string> Aeropuertos = new List<string>();
            List<string> Vuelos = new List<string>();
            List<string> CapacidadVuelo = new List<string>();
            List<string> Reserva = new List<string>();
            List<string> origenvuelo = new List<string>();
            List<string> destinovuelo = new List<string>();
            List<string> pasajerosadultos = new List<string>();
            List<string> pasajerosmenores = new List<string>();
            List<string> pasajerosinfantes = new List<string>();

            String NombreAeropuerto;
            string Condicion;
            bool Flag;
            string VuelosSalida;
            string VuelosDestino;
            string Capacidad ;
            int NCapacidad=0;
            int NNroReserva = 0;
            int NPasajerosAdultos = 0;
            int NPasajerosMenores = 0;
            int NPasajerosMenoresde3años = 0;
            string OrigenVuelo;
            string DestinoVuelo;
            string NroReserva;
            string PasajerosAdultos;
            string PasajerosMenores;
            string PasajerosMenoresde3años;
            int acumulador=0;

            //Ej a
            do
            {
                do
                {
                    Console.Write("Ingrese el nombre del aeropuerto: ");
                    NombreAeropuerto = Console.ReadLine();
                    Flag = ValidarCampos(NombreAeropuerto, "Codigo");

                } while (Flag == false);


                NombreAeropuerto = NombreAeropuerto.ToUpper();
                Aeropuertos.Add(NombreAeropuerto);
                do
                {
                    Console.WriteLine("Escriba SI para agregar aeropuertos: ");
                    Condicion = Console.ReadLine();
                    Flag = ValidarCampos(Condicion, "Condicion");
                } while (Flag == false);





            } while (Condicion == "SI");

            foreach (string aeropuerto in Aeropuertos)
            {
                Console.WriteLine("Los aeropuertos son: " + aeropuerto);
            }
            //B
            do
            {
                do
                {
                    Console.WriteLine("Ingrese el nombre de la salida: ");
                    VuelosSalida = Console.ReadLine();
                    Flag = ValidarCampos(VuelosSalida, "Vuelo de salida");
                } while (Flag == false);

                VuelosSalida = VuelosSalida.ToUpper();

                do
                {
                    Console.WriteLine("Ingrese el nombre de destino: ");
                    VuelosDestino = Console.ReadLine();
                    Flag = ValidarCampos(VuelosDestino, "Vuelo de destino");
                } while (Flag == false);

                VuelosDestino = VuelosDestino.ToUpper();

                string SalidaDestino = (VuelosSalida + "-" + VuelosDestino);

                do
                {
                    Console.Write("Ingrese la capacidad del vuelo: " + (VuelosSalida + "-" + VuelosDestino)+": ");
                    Capacidad = Console.ReadLine();
                    Flag = ValidarCapacidad(Capacidad, ref NCapacidad);
                } while (Flag == false);


                Vuelos.Add(SalidaDestino);
                CapacidadVuelo.Add(Capacidad);
                


                do
                {
                    Console.WriteLine("Escriba si para agregar aeropuertos: ");
                    Condicion = Console.ReadLine();
                    Flag = ValidarCampos(Condicion, "Condicion");
                } while (Flag == false);



            } while (Condicion == "SI");


            foreach (string SalidaDestino in Vuelos)
            {
                Console.WriteLine("Los vuelos son: " + SalidaDestino);
            }

            foreach (string capacidad in CapacidadVuelo)
            {
                Console.WriteLine("La capacidad de los vuelos : " + (VuelosSalida + "-" + VuelosDestino) + " son : "+Capacidad);
            }

            //C)
            do
            {
                do
                {
                    Console.WriteLine("Ingrese Nro de reserva: ");
                    NroReserva = Console.ReadLine();
                    Flag = ValidarCapacidad(NroReserva, ref NNroReserva);
                } while (Flag == false);

                Reserva.Add(NroReserva);


                do
                {

                    Console.WriteLine("Ingrese el origen del vuelo: ");
                    OrigenVuelo = Console.ReadLine();
                    Flag = ValidarCampos(OrigenVuelo,"Origen");


                } while (Flag == false);

                origenvuelo.Add(OrigenVuelo);

                do
                {
                    Console.WriteLine("Ingrese el destino del vuelo: ");
                    DestinoVuelo = Console.ReadLine();
                    Flag = ValidarCampos(DestinoVuelo, "Destino Vuelo");

                } while (Flag == false);

                destinovuelo.Add(DestinoVuelo);

                do
                {
                    Console.WriteLine("Ingrese cantidad de adultos pasajeros: ");
                    PasajerosAdultos = Console.ReadLine();
                    Flag = ValidarCapacidad(PasajerosAdultos, ref NPasajerosAdultos);


                } while (Flag == false);

                pasajerosadultos.Add(PasajerosAdultos);

                do
                {
                    Console.WriteLine("Ingrese cantidad de pasajeros entre 3 y 10 años: ");
                    PasajerosMenores = Console.ReadLine();
                    Flag = ValidarCapacidad(PasajerosMenores, ref NPasajerosMenores);
                } while (Flag == false);

                pasajerosmenores.Add(PasajerosMenores);

                do
                {
                    Console.WriteLine("Ingrese cantidad de pasajeros de menos de 3 años: ");
                    PasajerosMenoresde3años = Console.ReadLine();
                    Flag = ValidarCapacidad(PasajerosMenoresde3años, ref NPasajerosMenoresde3años);
                } while (Flag == false);

                pasajerosinfantes.Add(PasajerosMenoresde3años);

                do
                {
                    Console.WriteLine("Escriba SI para agregar aeropuertos: ");
                    Condicion = Console.ReadLine();
                    Flag = ValidarCampos(Condicion, "Condicion");
                } while (Flag == false);

                acumulador = acumulador + NPasajerosAdultos + NPasajerosMenores + NPasajerosMenoresde3años;

               


            } while (Condicion == "SI");

            foreach (string nroReserva in Reserva)
            {
                Console.WriteLine("El numero de reserva del vuelo es: " + nroReserva);
            }
            foreach (string origenvuelos in origenvuelo)
            {
                Console.WriteLine("El origen del vuelo es: " + origenvuelos);
            }
            foreach (string destinovuelos in destinovuelo)
            {
                Console.WriteLine("El destino del vuelo es: " + destinovuelos);
            }
            foreach (string pasajerosadulto in pasajerosadultos)
            {
                Console.WriteLine("El numero de pasajeros adultos es : " + pasajerosadulto);
            }
            foreach (string pasajerosmenore in pasajerosmenores)
            {
                Console.WriteLine("El numero de pasajeros entre 3 y 10 años son : " + pasajerosmenore);
            }
            foreach (string pasajerosinfante in pasajerosinfantes)
            {
                Console.WriteLine("El numero pasajeros infantes es: " + pasajerosinfante);
            }

            Console.WriteLine("La cantidad total de pasajeros del avión es : " + acumulador);


        }




        private bool ValidarCampos(string Valor, string Campo)
        {
            bool Flag = false;

            if (string.IsNullOrEmpty(Valor))
            {
                Console.WriteLine("El campo " + Campo + " no puede estar vacio");
            }
            if (Valor.Length > 3)
            {
                Console.WriteLine("El campo " + Campo + " no puede ser mayor a 3 letras");
            }
            if (!Valor.All(char.IsLetter))
            {
                Console.WriteLine("El campo " + Campo + " debe tener letras");
            }
            else
            {
                Flag = true;
            }

            return Flag;
        }

        private bool ValidarCapacidad(string valor, ref int Salida)
        {
            bool Flag = false;

            if(!int.TryParse(valor,out Salida))
            {
                Console.WriteLine("Usted debe ingresar un dato númerico.");
            }
            else if(Salida<=0)
            {
                Console.WriteLine("Usted debe ingresar un numero positivo.");
            }
            else
            {
                Flag = true;
            }

            return Flag;
        }

        



    }
        
}    
