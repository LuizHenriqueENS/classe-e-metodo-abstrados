using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataEMetodosAbstrados.Entities {
    class NaturalPerson : Person{
        public double HealthExpense { get; set; }

        public NaturalPerson() {
        }

        public NaturalPerson(string name, double annualIncome, double healthExpense) : base(name, annualIncome) {
            HealthExpense = healthExpense;
        }

        public override double Tax() {
            if(base.AnnualIncome < 20000) {
                return base.AnnualIncome * 0.15;
            }
            else {
                return (base.AnnualIncome * 0.25) - (HealthExpense * 0.5);
            }
        }
    }
}
