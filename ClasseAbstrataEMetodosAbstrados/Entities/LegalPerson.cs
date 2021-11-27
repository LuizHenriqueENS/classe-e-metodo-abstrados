using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataEMetodosAbstrados.Entities {
    class LegalPerson : Person{

        public int NumberOfEmployees { get; set; }

        public LegalPerson() {
        }

        public LegalPerson(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome) {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax() {
            if(NumberOfEmployees > 10) {
                return base.AnnualIncome * 0.14;
            } else {
                return base.AnnualIncome * 0.16;
            }
        }
    }
}
