
using System.Threading.Tasks;

namespace Tiendita.Models
{
    public class Venta
    {
        public DateTime Fecha { get; private set; }
        public Producto ProductoVendido { get; private set; }
        public int Cantidad { get; private set; }
        public Clientes Cliente { get; private set; }

        public Venta(int cantidad, Producto productoVendido, Clientes cliente)
        {
            Cantidad = cantidad;
            ProductoVendido = productoVendido;
            Cliente = cliente;
        }
        public Venta(DateTime fecha, int cantidad, Producto productoVendido, Clientes cliente)
        {
            Fecha = fecha;
            Cantidad = Cantidad;
            ProductoVendido = productoVendido;
            Cliente = cliente;
        }
        public double CalcularTotal()
        {
            double total = 0;
            if (Cantidad < 0)
            {
                Console.WriteLine($"ingrese una cantidad valida");
            }
            else 
            {
                total = Cantidad * ProductoVentido.Precio;
            }
            return total;
        }
        public string MostrarVenta()
        {   Console.WriteLine($"Ticket de Compra\n");
            Console.WriteLine($"----------------------------");
            Console.WriteLine($"{ProductoVentido} {Cantidad}");
            Console.WriteLine($"Al cliente: {Cliente}");
            Console.WriteLine($"{Fecha}");
            Console.WriteLine($"----------------------------");
            return MostrarVenta();
        }
    }
}
