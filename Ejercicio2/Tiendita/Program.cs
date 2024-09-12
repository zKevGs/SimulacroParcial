namespace Tiendita.Models
{
     class Program
    {
        static void Main()
        {
        Clientes cliente1 = new Clientes("Jesus", 3364399303, "A1");
        Producto harina = new Producto("Harina 000", 3000, "H1");
        DateTime Hora = new DateTime.Now;
        Venta venta1 = new Venta(Hora, 2);
        }

    }
}
