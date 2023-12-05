
namespace AtividadeHerançaPolimorfismo.Entities {
    class Employee {

        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValorPerHour { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valorPerHour) {
            Name = name;
            Hours = hours;
            ValorPerHour = valorPerHour;
        }

        public virtual double Payment() {
            return Hours * ValorPerHour;
        }
    }
}
