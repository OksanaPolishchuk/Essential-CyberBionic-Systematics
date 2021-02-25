namespace FirmApp
{
    public class Firm : IManager
    {
        private IManager _manager;
        private IEmployee _employee;
        private IBrigadier _brigadier;

        public Firm(IManager manager, IEmployee employee, IBrigadier brigadier)
        {
            _manager = manager;
            _employee = employee;
            _brigadier = brigadier;
        }
    }
}