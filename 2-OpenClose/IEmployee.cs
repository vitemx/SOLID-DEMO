namespace OpenClose
{
    public interface IEmployee
    {
        public string? Fullname { get; set; }
        public int HoursWorked { get; set; }

        public abstract decimal CalculateSalaryMonthly();
    }
}