using ClasseAbstrataEMetodosAbstrados.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataEMetodosAbstrados {
    class Program {
        static void Main(string[] args) {
            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char r = Console.ReadLine()[0];
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (r == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpense = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new NaturalPerson(name, annualIncome, healthExpense));
                } else if(r == 'c') {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new LegalPerson(name, annualIncome, numberOfEmployees));
                }
            }
            double sum = 0;
            Console.WriteLine("\nTAXES PAID: ");
            foreach (Person p in list) {
                Console.WriteLine($"{p.Name} $ {p.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += p.Tax();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
