namespace TaskManager.Presentation.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName 
        {
            get { return LastName + " " + FirstName; }
        }
    }
}