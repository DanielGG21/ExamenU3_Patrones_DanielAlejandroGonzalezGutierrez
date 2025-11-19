using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3_Patrones_DanielAlejandroGonzalezGutierrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDispositivo> dispositivos = CrearDispositivosIniciales();
            DecorarDispositivos(dispositivos);

            var constructor = new ConstructorCasa(dispositivos);
            var controlador = new ControladorGrupos(constructor.Sala, constructor.Cocina, constructor.Cuarto, constructor.Casa);

            controlador.Ejecutar();
        }

        static List<IDispositivo> CrearDispositivosIniciales()
        {
            List<IDispositivo> lista = new List<IDispositivo>();
            lista.Add(new DispositivoSimple("Televisor"));
            lista.Add(new DispositivoSimple("Bocinas"));
            lista.Add(new DispositivoSimple("Foco sala"));
            lista.Add(new DispositivoSimple("Microondas"));
            lista.Add(new DispositivoSimple("Refrigerador"));
            lista.Add(new DispositivoSimple("Luces LED cuarto"));
            lista.Add(new DispositivoSimple("PC escritorio"));
            return lista;
        }

        static void DecorarDispositivos(List<IDispositivo> dispositivos)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("====   Dispositivos disponibles para decorar:   =====================\n");

                for (int i = 0; i < dispositivos.Count; i++)
                {
                    bool esDecorado = dispositivos[i] is DispositivoDecorador;
                    string etiqueta = esDecorado ? " (decorado)" : "";
                    Console.WriteLine((i + 1) + ". " + dispositivos[i].Nombre + etiqueta);
                }

                Console.WriteLine((dispositivos.Count + 1) + ". Terminar decoracion \n");

                Console.WriteLine("Seleccione una opción:");
                string entrada = Console.ReadLine();
                int opcion;

                if (!int.TryParse(entrada, out opcion))
                {
                    Console.WriteLine("Opción inválida");
                    Console.ReadKey();
                    continue;
                }

                if (opcion == dispositivos.Count + 1)
                {
                    Console.WriteLine("Decoracion finalizada presione una tecla para continuar");
                    Console.ReadKey();
                    break;
                }

                if (opcion < 1 || opcion > dispositivos.Count)
                {
                    Console.WriteLine("Opción inválida");
                    Console.ReadKey();
                    continue;
                }

                IDispositivo seleccionado = dispositivos[opcion - 1];

                int decorador1 = ElegirTipoDecorador(seleccionado.Nombre);

                if (decorador1 == 0)
                    continue;

                IDispositivo decorado1 = AplicarDecorador(seleccionado, decorador1);

                int decorador2 = ElegirTipoDecorador(seleccionado.Nombre, decorador1);

                if (decorador2 == 0)
                {
                    dispositivos[opcion - 1] = decorado1;
                    Console.WriteLine("Decoración finalizada para " + seleccionado.Nombre + " (un decorador).");
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                    continue;
                }

                IDispositivo decoradoFinal = AplicarDecorador(decorado1, decorador2);

                dispositivos[opcion - 1] = decoradoFinal;
            }
        }

        static int ElegirTipoDecorador(string nombreDispositivo, int? decoradorYaElegido = null)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine("========================================");
                Console.WriteLine("Seleccione decorador para " + nombreDispositivo);
                Console.WriteLine("========================================");
                Console.WriteLine("Elija decorador:\n");

                if (decoradorYaElegido != 1)
                    Console.WriteLine("1. Decorador ahorro de energía");

                if (decoradorYaElegido != 2)
                    Console.WriteLine("2. Decorador modo nocturno");

                if (decoradorYaElegido != null)
                    Console.WriteLine("3. Terminar decoración");
                else
                    Console.WriteLine("3. Regresar");

                string opcion = Console.ReadLine();

                if (opcion == "1" && decoradorYaElegido != 1) return 1;
                if (opcion == "2" && decoradorYaElegido != 2) return 2;
                if (opcion == "3") return 0;

                Console.WriteLine("Opción no válida, intente de nuevo.");
                Console.ReadKey();
            }
        }

        static IDispositivo AplicarDecorador(IDispositivo baseDispositivo, int tipo)
        {
            if (tipo == 1) return new DecoradorAhorroEnergia(baseDispositivo);
            if (tipo == 2) return new DecoradorModoNocturno(baseDispositivo);
            return baseDispositivo;
        }
    }
}

