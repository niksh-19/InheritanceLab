using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    class Salaried : Employee
    {
        private double salary;

        /**
		 * Creates a Salaried object with default values.
		 */
        public Salaried()
        {

        }

        
        public Salaried(string id, string name, string address, string phone, long sin, string dateOfBirth,
                string department, double salary) : base(id, name, address, phone, sin, dateOfBirth, department)
        {

            this.salary = salary;
        }
        public double GetSalary()
        {
            return salary;
        }
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
        public double GetPay()
        {
            return salary;
        }

        public string tostring()
        {
            return "Salaried ID =" + GetId() + ", name =" + GetName() + ", address =" + GetAddress()
                    + ", phone =" + GetPhone() + ", SIN =" + GetSin() + ", date of birth =" + GetDateOfBirth()
                    + ", department =" + GetDepartment() + ", salary =" + GetSalary() + ", pay =" + GetPay();
        }

    }
}
