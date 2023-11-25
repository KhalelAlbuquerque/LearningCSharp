using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ListExerciseSalary
{
    internal class Employee
    {
        public int Id { get; }
        public string Name {  get; set; }
        public double Salary { get; private set; }
        public Employee(int id, string name, double salary) {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            this.Salary = this.Salary + ((percentage / 100) * this.Salary);
        }


        public override string ToString()
        {
            return this.Id + ", " + this.Name + ", " + this.Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
