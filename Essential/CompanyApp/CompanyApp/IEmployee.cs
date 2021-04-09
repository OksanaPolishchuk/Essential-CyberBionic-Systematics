namespace CompanyApp
{
    public interface IEmployee
    {
        string FullName { get; set; }
        int Experience { get; set; }

        void Work();
    }
}
