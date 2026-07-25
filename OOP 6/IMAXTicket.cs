namespace OOP_6
{
   public class IMAXTicket : Ticket
{
        private bool _is3D;

        public bool Is3D
        {
            get => _is3D;
            set
                {
                _is3D = value;

                if (_is3D)
                    Price += 30;
            }
        }

        public IMAXTicket(string movieName, decimal price, bool is3D)
        : base(movieName, price)
        {
            if (is3D)
                Price += 30;

            _is3D = is3D;
        }

        public override decimal CalculateFinalPrice()
        {
            return Price * 1.14m;
        }

        public override void PrintInfo()
        {
            Console.Write($"[Ticket #{TicketId}] {MovieName} | IMAX");
            Console.Write($" | 3D: {(Is3D ? "Yes" : "No")}");
            Console.Write($" | Price: {Price} | Final: {CalculateFinalPrice():F2}");
            Console.WriteLine($" | Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}
