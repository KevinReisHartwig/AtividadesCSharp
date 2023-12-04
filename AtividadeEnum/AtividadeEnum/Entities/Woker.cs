using AtividadeEnum.Entities.Enums;
using System.Collections.Generic;

namespace AtividadeEnum.Entities {
    class Woker {
        public string Name { get; set; }
        public WokerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Departmant { get; set;}
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Woker() {

        }
        public Woker(string name, WokerLevel level, double baseSalary, Department departmant) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departmant = departmant;
        }

        public void AddContract(HourContract contract) {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) {  
            Contracts.Remove(contract); }

        public double Income(int year, int month) {
            double sum = BaseSalary;

            foreach(HourContract contract in Contracts) {
                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}

   
