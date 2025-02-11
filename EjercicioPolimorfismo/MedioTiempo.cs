

namespace EjercicioPolimorfismo
{
    public class MedioTiempo : Empleado
    {
        public double HorasTrabajadas { get; set; }
        public double pagoPorHora { get; set; }

        public MedioTiempo()
        {
            Console.WriteLine("Ingrese el nombre del empleado de medio tiempo: ");
            Nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese el cargo del empleado: ");
            Cargo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese las horas trabajadas: ");
            HorasTrabajadas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese el pago por hora: ");
            pagoPorHora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }
        public override double CalcularSalario()
        {
            return HorasTrabajadas * pagoPorHora;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Empleado de medio tiempo: {Nombre}, Cargo: {Cargo}, salario: {CalcularSalario()}");
        }
    }
}
