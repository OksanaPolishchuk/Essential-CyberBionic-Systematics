using System.Collections.Generic;
using System.Linq;

namespace CompanyApp
{
    public class Firm : IFirm
    {
        private readonly IList<IEmployee> _employees;

        public Firm()
        {
            _employees = new List<IEmployee>();
        }
        public IList<IEmployee> Employees {get { return _employees; }}

        public IEnumerable<IEmployee> TheEmployee<T>() where T : IEmployee
        {
            return _employees.Where(employee => employee is T);
        }

        public int WorkersCounter<T>() where T : IEmployee
        {
            return _employees.Count(employee => employee is T);
        }

        public static bool operator +(Firm firm, IEmployee employee)
        {
            if (firm.Employees.Contains(employee) || employee == null) return false;

            firm.Employees.Add(employee);

            return true;
        }
        
        public static bool operator -(Firm firm, IEmployee employee)
        {
            if (firm.Employees.Contains(employee)) { firm.Employees.Remove(employee); return true; }
            
            return false;
        }
    }
}
