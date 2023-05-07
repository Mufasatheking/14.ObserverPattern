namespace ObserverPattern
{
    public class EmailObserver : IObserver
    {
        public EmailObserver(string email)
        {
            Email = email;
        }

        public string Email { get; set; }
        public void Update(int i)
        {
            Console.WriteLine($"Email observer has received an alert: Emailing {this.Email}");
        }
    }
}