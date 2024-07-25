using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name}";
        }

        public static bool operator ==(Employee left, Employee right)
        {
            return (left.Id == right.Id) && (left.Name == right.Name);
        }
        public static bool operator !=(Employee left, Employee right)
        {
            return (left.Id != right.Id) || (left.Name != right.Name);
        }

        public override bool Equals(object? obj)
        {
            Employee passedEmp = (Employee)obj; 
            return (this.Id == passedEmp.Id) && (this.Name == passedEmp.Name);
        }

        public int CompareTo(object? obj)
        {
            Employee passedEmp = (Employee)obj;
            if (this.Id > passedEmp.Id)
                return 1;
            else if (this.Id < passedEmp.Id)
                return -1;
            else

                return 0;

            return this.Id.CompareTo(passedEmp.Id);



        }
    }
}
