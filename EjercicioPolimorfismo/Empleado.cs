

using System.Globalization;

namespace EjercicioPolimorfismo
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double SalarioBase { get; set; }

        public Empleado() { }
        public abstract double CalcularSalario();
       
    }
}
