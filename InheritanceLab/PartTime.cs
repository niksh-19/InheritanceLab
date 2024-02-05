using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace InheritanceLab
{
    class PartTime : Employee
    {
        private double rate;
        private double hours;

        
        public PartTime()
        {

        }
        public PartTime(string id, string name, string address, string phone, long sin, string dateOfBirth, string department, double rate, double hours) : base(id, name, address, phone, sin, dateOfBirth, department)
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
            return rate * hours;
        }
        public string toString()
        {
            return "Wages ID =" + GetId() + ", name =" + GetName() + ", address =" + GetAddress()
                    + ", phone =" + GetPhone() + ", SIN =" + GetSin() + ", date of birth =" + GetDateOfBirth()
                    + ", department =" + GetDepartment() + ", rate =" + GetRate() + ", hours =" + GetHours()
                    + ", pay =" + GetPay();
        }

    }
}
