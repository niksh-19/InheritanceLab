using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    class Employee
    {
        private string id;
        private string name;
        private string address;
        private string phone;
        private long sin;
        private string dateOfBirth;
        private string department;

        
        public Employee()
        {

        }

        
        public Employee(string id, string name, string address, string phone, long sin, string dateOfBirth,
                string department)
        {

           this.id = id;
           this.name = name;
           this.address = address;
           this.phone = phone;
           this.sin = sin;
           this.dateOfBirth = dateOfBirth;
           this.department = department;
        }
        public string GetId()
        {
            return id;
        }
        public void SetId(string id)
        {
            this.id = id;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public string GetPhone()
        {
            return phone;
        }
        public void SetPhone(string phone)
        {
            this.phone = phone;
        }
        public long GetSin()
        {
            return sin;
        }
        public void SetSin(long sin)
        {
            this.sin = sin;
        }
        public string GetDateOfBirth()
        {
            return dateOfBirth;
        }
        public void SetDateOfBirth(string dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
        public string GetDepartment()
        {
            return department;
        }
        public void SetDepartment(string department)
        {
            this.department = department;
        }

        public string tostring()
        {
            return "Employee ID=" + GetId() + ", name=" + GetName() + ", address=" + GetAddress()
                    + ", phone)=" + GetPhone() + ", SIN=" + GetSin() + ", date of birth=" + GetDateOfBirth()
                    + ", department=" + GetDepartment();
        }



    }
}
