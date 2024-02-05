using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    class Wages : Employee

    {
        private double rate;
        private double hours;
        private const double REGULAR_HOURS = 40;
        private const double OVERTIME_RATE = 1.5;

        public Wages()
        {

        }

        public Wages(String id, String name, String address, String phone, long sin, String dateOfBirth, String department, double rate, double hours) :
            base(id, name, address, phone, sin, dateOfBirth, department)
        {

            this.rate = rate;
            this.hours = hours;
        }
        public double GetRate()
        {
            return rate;
        }
        public void SetRate(double rate)
        {
            this.rate = rate;
        }
        public double GetHours()
        {
            return hours;
        }
        public void SetHours(double hours)
        {
            this.hours = hours;
        }
        public double GetPay()
        {
            if (hours <= REGULAR_HOURS)
            {
                return rate * hours;
            }
            else
            {
                return rate * REGULAR_HOURS + rate * OVERTIME_RATE * (hours - REGULAR_HOURS);
            }
        }
        public String toString()
        {
            return "Wages ID =" + GetId() + ", name =" + GetName() + ", address =" + GetAddress()
                    + ", phone =" + GetPhone() + ", SIN =" + GetSin() + ", date of birth =" + GetDateOfBirth()
                    + ", department =" + GetDepartment() + ", rate =" + GetRate() + ", hours =" + GetHours()
                    + ", pay =" + GetPay();
        }


    }
}
