using OOP_6.interfaces;

namespace OOP_6
{
    public abstract class Ticket : IPrintable, IBookable, ICloneable
{
        private static  int ticketCounter = 0;

        public int TicketId { get; }

        public string MovieName { get; set; }

        private decimal _price;

        public decimal Price
        {
            get => _price;
            set
                {
                if (value > 0)
                    _price = value;
            }
        }

        private bool _isBooked = false;

        public bool IsBooked => _isBooked;

        public abstract decimal CalculateFinalPrice();
        protected Ticket(string movieName, decimal price)
    {
            TicketId = ++ticketCounter;
            MovieName = movieName;
            Price = price;
        }

        public virtual void PrintInfo()
    {
            Console.Write($"[Ticket #{TicketId}] {MovieName}");
            Console.Write($" | Price: {Price} | Final: {CalculateFinalPrice():F2}");
            Console.WriteLine($" | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public bool Book()
    {
            if (_isBooked)
                return false;

            _isBooked = true;
            return true;
        }

        public bool Cancel()
    {
            if (!_isBooked)
                return false;

            _isBooked = false;
            return true;
        }

        public virtual object Clone()
    {
            return this.MemberwiseClone();
        }

        public static int GetTotalTickets() 
    {
            return ticketCounter;
        }
    }
}
