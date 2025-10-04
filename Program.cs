using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaVuelosBaratos
{
    // Clase que representa un vuelo
    public class Vuelo
    {
        public int Id { get; set; }
        public string Aerolinea { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public decimal Precio { get; set; }
        public int AsientosDisponibles { get; set; }
        public string Clase { get; set; } // Económica, Ejecutiva, Primera

        public override string ToString()
        {
            return $"ID: {Id} | {Aerolinea} | {Origen} → {Destino} | " +
                   $"Salida: {FechaSalida:dd/MM/yyyy HH:mm} | " +
                   $"Llegada: {FechaLlegada:dd/MM/yyyy HH:mm} | " +
                   $"Precio: ${Precio:N2} | Asientos: {AsientosDisponibles} | Clase: {Clase}";
        }
    }

    // Simulación de base de datos usando una estructura en memoria
    public class BaseDatosVuelos
    {
        private List<Vuelo> vuelos;

        public BaseDatosVuelos()
        {
            vuelos = new List<Vuelo>();
            CargarDatosFicticios();
        }

        // Carga datos ficticios en la estructura
        private void CargarDatosFicticios()
        {
            vuelos.AddRange(new List<Vuelo>
            {
                new Vuelo { Id = 1, Aerolinea = "AeroEcuador", Origen = "Quito", Destino = "Guayaquil", 
                           FechaSalida = DateTime.Now.AddDays(5).AddHours(8), 
                           FechaLlegada = DateTime.Now.AddDays(5).AddHours(9), 
                           Precio = 89.99m, AsientosDisponibles = 45, Clase = "Económica" },
                
                new Vuelo { Id = 2, Aerolinea = "LATAM", Origen = "Quito", Destino = "Miami", 
                           FechaSalida = DateTime.Now.AddDays(10).AddHours(14), 
                           FechaLlegada = DateTime.Now.AddDays(10).AddHours(20), 
                           Precio = 425.50m, AsientosDisponibles = 12, Clase = "Económica" },
                
                new Vuelo { Id = 3, Aerolinea = "Avianca", Origen = "Guayaquil", Destino = "Bogotá", 
                           FechaSalida = DateTime.Now.AddDays(3).AddHours(10), 
                           FechaLlegada = DateTime.Now.AddDays(3).AddHours(13), 
                           Precio = 215.00m, AsientosDisponibles = 28, Clase = "Económica" },
                
                new Vuelo { Id = 4, Aerolinea = "Copa Airlines", Origen = "Quito", Destino = "Ciudad de Panamá", 
                           FechaSalida = DateTime.Now.AddDays(7).AddHours(6), 
                           FechaLlegada = DateTime.Now.AddDays(7).AddHours(9), 
                           Precio = 310.75m, AsientosDisponibles = 8, Clase = "Ejecutiva" },
                
                new Vuelo { Id = 5, Aerolinea = "AeroEcuador", Origen = "Guayaquil", Destino = "Quito", 
                           FechaSalida = DateTime.Now.AddDays(5).AddHours(18), 
                           FechaLlegada = DateTime.Now.AddDays(5).AddHours(19), 
                           Precio = 79.99m, AsientosDisponibles = 52, Clase = "Económica" },
                
                new Vuelo { Id = 6, Aerolinea = "TAME", Origen = "Quito", Destino = "Galápagos", 
                           FechaSalida = DateTime.Now.AddDays(15).AddHours(7), 
                           FechaLlegada = DateTime.Now.AddDays(15).AddHours(9), 
                           Precio = 195.00m, AsientosDisponibles = 35, Clase = "Económica" },
                
                new Vuelo { Id = 7, Aerolinea = "LATAM", Origen = "Guayaquil", Destino = "Lima", 
                           FechaSalida = DateTime.Now.AddDays(8).AddHours(16), 
                           FechaLlegada = DateTime.Now.AddDays(8).AddHours(18), 
                           Precio = 178.50m, AsientosDisponibles = 20, Clase = "Económica" },
                
                new Vuelo { Id = 8, Aerolinea = "Avianca", Origen = "Quito", Destino = "Madrid", 
                           FechaSalida = DateTime.Now.AddDays(20).AddHours(22), 
                           FechaLlegada = DateTime.Now.AddDays(21).AddHours(14), 
                           Precio = 890.00m, AsientosDisponibles = 5, Clase = "Ejecutiva" },
                
                new Vuelo { Id = 9, Aerolinea = "Copa Airlines", Origen = "Guayaquil", Destino = "Ciudad de México", 
                           FechaSalida = DateTime.Now.AddDays(12).AddHours(11), 
                           FechaLlegada = DateTime.Now.AddDays(12).AddHours(16), 
                           Precio = 385.25m, AsientosDisponibles = 15, Clase = "Económica" },
                
                new Vuelo { Id = 10, Aerolinea = "AeroEcuador", Origen = "Cuenca", Destino = "Quito", 
                           FechaSalida = DateTime.Now.AddDays(4).AddHours(12), 
                           FechaLlegada = DateTime.Now.AddDays(4).AddHours(13), 
                           Precio = 65.00m, AsientosDisponibles = 40, Clase = "Económica" },
                
                new Vuelo { Id = 11, Aerolinea = "LATAM", Origen = "Quito", Destino = "Buenos Aires", 
                           FechaSalida = DateTime.Now.AddDays(18).AddHours(9), 
                           FechaLlegada = DateTime.Now.AddDays(18).AddHours(17), 
                           Precio = 520.00m, AsientosDisponibles = 10, Clase = "Económica" },
                
                new Vuelo { Id = 12, Aerolinea = "TAME", Origen = "Quito", Destino = "Coca", 
                           FechaSalida = DateTime.Now.AddDays(6).AddHours(15), 
                           FechaLlegada = DateTime.Now.AddDays(6).AddHours(16), 
                           Precio = 95.50m, AsientosDisponibles = 30, Clase = "Económica" }
            });
        }

        // Métodos de consulta
        public List<Vuelo> ObtenerTodosLosVuelos()
        {
            return vuelos.OrderBy(v => v.Precio).ToList();
        }

        public List<Vuelo> BuscarPorOrigen(string origen)
        {
            return vuelos.Where(v => v.Origen.ToLower().Contains(origen.ToLower()))
                        .OrderBy(v => v.Precio)
                        .ToList();
        }

        public List<Vuelo> BuscarPorDestino(string destino)
        {
            return vuelos.Where(v => v.Destino.ToLower().Contains(destino.ToLower()))
                        .OrderBy(v => v.Precio)
                        .ToList();
        }

        public List<Vuelo> BuscarPorOrigenDestino(string origen, string destino)
        {
            return vuelos.Where(v => v.Origen.ToLower().Contains(origen.ToLower()) && 
                                    v.Destino.ToLower().Contains(destino.ToLower()))
                        .OrderBy(v => v.Precio)
                        .ToList();
        }

        public List<Vuelo> BuscarPorPrecioMaximo(decimal precioMax)
        {
            return vuelos.Where(v => v.Precio <= precioMax)
                        .OrderBy(v => v.Precio)
                        .ToList();
        }

        public List<Vuelo> BuscarPorAerolinea(string aerolinea)
        {
            return vuelos.Where(v => v.Aerolinea.ToLower().Contains(aerolinea.ToLower()))
                        .OrderBy(v => v.Precio)
                        .ToList();
        }

        public List<Vuelo> ObtenerVuelosMasBaratos(int cantidad)
        {
            return vuelos.OrderBy(v => v.Precio)
                        .Take(cantidad)
                        .ToList();
        }

        public Vuelo BuscarPorId(int id)
        {
            return vuelos.FirstOrDefault(v => v.Id == id);
        }

        // Estadísticas
        public void MostrarEstadisticas()
        {
            Console.WriteLine("\n╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║              ESTADÍSTICAS DE LA BASE DE DATOS                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
            Console.WriteLine($"Total de vuelos: {vuelos.Count}");
            Console.WriteLine($"Precio promedio: ${vuelos.Average(v => v.Precio):N2}");
            Console.WriteLine($"Vuelo más barato: ${vuelos.Min(v => v.Precio):N2}");
            Console.WriteLine($"Vuelo más caro: ${vuelos.Max(v => v.Precio):N2}");
            Console.WriteLine($"Total asientos disponibles: {vuelos.Sum(v => v.AsientosDisponibles)}");
            
            var aerolineas = vuelos.GroupBy(v => v.Aerolinea)
                                  .Select(g => new { Aerolinea = g.Key, Cantidad = g.Count() });
            Console.WriteLine("\nVuelos por aerolínea:");
            foreach (var a in aerolineas)
            {
                Console.WriteLine($"  - {a.Aerolinea}: {a.Cantidad} vuelos");
            }
        }
    }

    // Programa principal
    class Program
    {
        static BaseDatosVuelos baseDatos;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            baseDatos = new BaseDatosVuelos();
            
            MostrarBienvenida();
            MostrarMenuPrincipal();
        }

        static void MostrarBienvenida()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║        SISTEMA DE BÚSQUEDA DE VUELOS BARATOS v1.0             ║");
            Console.WriteLine("║              ¡Encuentra los mejores precios!                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        static void MostrarMenuPrincipal()
        {
            bool salir = false;

            while (!salir)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n┌─────────────── MENÚ PRINCIPAL ───────────────┐");
                Console.ResetColor();
                Console.WriteLine("│  1. Ver todos los vuelos                     │");
                Console.WriteLine("│  2. Buscar por origen                        │");
                Console.WriteLine("│  3. Buscar por destino                       │");
                Console.WriteLine("│  4. Buscar por origen y destino              │");
                Console.WriteLine("│  5. Buscar por precio máximo                 │");
                Console.WriteLine("│  6. Buscar por aerolínea                     │");
                Console.WriteLine("│  7. Ver vuelos más baratos (Top 5)           │");
                Console.WriteLine("│  8. Ver estadísticas                         │");
                Console.WriteLine("│  9. Buscar vuelo por ID                      │");
                Console.WriteLine("│  0. Salir                                    │");
                Console.WriteLine("└──────────────────────────────────────────────┘");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        VerTodosLosVuelos();
                        break;
                    case "2":
                        BuscarPorOrigen();
                        break;
                    case "3":
                        BuscarPorDestino();
                        break;
                    case "4":
                        BuscarPorOrigenDestino();
                        break;
                    case "5":
                        BuscarPorPrecioMaximo();
                        break;
                    case "6":
                        BuscarPorAerolinea();
                        break;
                    case "7":
                        VerVuelosMasBaratos();
                        break;
                    case "8":
                        baseDatos.MostrarEstadisticas();
                        break;
                    case "9":
                        BuscarPorId();
                        break;
                    case "0":
                        salir = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n¡Gracias por usar el sistema! ¡Buen viaje! ✈️");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n❌ Opción no válida. Intente nuevamente.");
                        Console.ResetColor();
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    MostrarBienvenida();
                }
            }
        }

        static void MostrarResultados(List<Vuelo> vuelos, string titulo)
        {
            Console.WriteLine($"\n{'═',70}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {titulo}");
            Console.ResetColor();
            Console.WriteLine($"{'═',70}");

            if (vuelos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️  No se encontraron vuelos con los criterios especificados.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"\nSe encontraron {vuelos.Count} vuelo(s):\n");
                foreach (var vuelo in vuelos)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("✈️  ");
                    Console.ResetColor();
                    Console.WriteLine(vuelo.ToString());
                    Console.WriteLine($"{'─',70}");
                }
            }
        }

        static void VerTodosLosVuelos()
        {
            var vuelos = baseDatos.ObtenerTodosLosVuelos();
            MostrarResultados(vuelos, "TODOS LOS VUELOS (Ordenados por precio)");
        }

        static void BuscarPorOrigen()
        {
            Console.Write("\nIngrese la ciudad de origen: ");
            string origen = Console.ReadLine();
            var vuelos = baseDatos.BuscarPorOrigen(origen);
            MostrarResultados(vuelos, $"VUELOS DESDE {origen.ToUpper()}");
        }

        static void BuscarPorDestino()
        {
            Console.Write("\nIngrese la ciudad de destino: ");
            string destino = Console.ReadLine();
            var vuelos = baseDatos.BuscarPorDestino(destino);
            MostrarResultados(vuelos, $"VUELOS HACIA {destino.ToUpper()}");
        }

        static void BuscarPorOrigenDestino()
        {
            Console.Write("\nIngrese la ciudad de origen: ");
            string origen = Console.ReadLine();
            Console.Write("Ingrese la ciudad de destino: ");
            string destino = Console.ReadLine();
            var vuelos = baseDatos.BuscarPorOrigenDestino(origen, destino);
            MostrarResultados(vuelos, $"VUELOS DE {origen.ToUpper()} A {destino.ToUpper()}");
        }

        static void BuscarPorPrecioMaximo()
        {
            Console.Write("\nIngrese el precio máximo: $");
            if (decimal.TryParse(Console.ReadLine(), out decimal precio))
            {
                var vuelos = baseDatos.BuscarPorPrecioMaximo(precio);
                MostrarResultados(vuelos, $"VUELOS CON PRECIO MÁXIMO DE ${precio:N2}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n❌ Precio no válido.");
                Console.ResetColor();
            }
        }

        static void BuscarPorAerolinea()
        {
            Console.Write("\nIngrese el nombre de la aerolínea: ");
            string aerolinea = Console.ReadLine();
            var vuelos = baseDatos.BuscarPorAerolinea(aerolinea);
            MostrarResultados(vuelos, $"VUELOS DE {aerolinea.ToUpper()}");
        }

        static void VerVuelosMasBaratos()
        {
            var vuelos = baseDatos.ObtenerVuelosMasBaratos(5);
            MostrarResultados(vuelos, "TOP 5 VUELOS MÁS BARATOS 💰");
        }

        static void BuscarPorId()
        {
            Console.Write("\nIngrese el ID del vuelo: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var vuelo = baseDatos.BuscarPorId(id);
                if (vuelo != null)
                {
                    MostrarResultados(new List<Vuelo> { vuelo }, $"DETALLES DEL VUELO #{id}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n❌ No se encontró el vuelo con ID {id}.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n❌ ID no válido.");
                Console.ResetColor();
            }
        }
    }
}