

namespace EjercicioPolimorfismo
{
    public class TiempoCompleto : Empleado
    {

        public TiempoCompleto()
        {
            Console.WriteLine("Ingrese el nombre del empleado de tiempo completo: ");
            Nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese el cargo del empleado: ");
            Cargo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese el salario base: ");
            SalarioBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }

        public override double CalcularSalario()
        {
            return SalarioBase;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Empleado de tiempo completo: {Nombre}, Cargo: {Cargo}, Salario: {CalcularSalario()}");
        }
    }
}
