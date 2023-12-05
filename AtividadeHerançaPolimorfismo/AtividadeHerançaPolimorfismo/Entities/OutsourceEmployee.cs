
namespace AtividadeHerançaPolimorfismo.Entities {
    class OutsourceEmployee : Employee{

        public double AddtionalCharge {  get; set; }

        public OutsourceEmployee() { }

        public OutsourceEmployee(double addtionalCharge, string name, int hours, double valorPerHour) : base (name, hours, valorPerHour) {
            
            AddtionalCharge = addtionalCharge;
        }

        public override double Payment() {
            return base.Payment() + 1.1 * AddtionalCharge;
        }

    }
}
