namespace BankCMS.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }

        public Customer(int Id, string Name, string Number, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Number = Number; 
            this.Age = Age;
        }
    }
}
