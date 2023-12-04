

using System.Globalization;
using System.Runtime.CompilerServices;


    internal class ContaBancaria {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
            
        }

        public ContaBancaria(int numero, string titular, double saldoInicial) : this(numero, titular) {
            Deposito(saldoInicial);
        
        
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.00;
        }

        public override string ToString() {
            return "Conta "
                + Numero
                +", Titular "
                + Titular
                +", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
