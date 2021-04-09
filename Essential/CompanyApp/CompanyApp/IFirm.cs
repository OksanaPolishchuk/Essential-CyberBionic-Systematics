using System.Collections.Generic;

namespace CompanyApp
{
    public interface IFirm
    {
        IList<IEmployee> Employees { get; }
        IEnumerable<IEmployee> TheEmployee<T>() where T : IEmployee;

        int WorkersCounter<T>() where T : IEmployee;
    }
}
