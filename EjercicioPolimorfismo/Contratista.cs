
namespace EjercicioPolimorfismo
{
    public class Contratista : Empleado
    {

        public double pagoContrato { get; set; }

        public Contratista() 
        {
            Console.WriteLine("Ingrese el nombre del contratista: ");
            Nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese el cargo del contratista: ");
            Cargo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese el pago por contrato: ");
            pagoContrato = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

        }

        public override double CalcularSalario()
        {
            return pagoContrato;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Contratista: {Nombre}, Cargo: {Cargo}, pago: {CalcularSalario()}");
        }
    }
}
