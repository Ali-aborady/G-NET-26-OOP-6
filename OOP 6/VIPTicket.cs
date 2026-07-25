namespace OOP_6
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }

        public decimal ServiceFee { get; set; } = 50;
        public VIPTicket(string movieName, decimal price, bool loungeAccess)
        : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }

        public override decimal CalculateFinalPrice()
        {
            return (Price + ServiceFee) * 1.14m;
        }

        public override void PrintInfo()
        {
            Console.Write($"[Ticket #{TicketId}] {MovieName} | VIP");
            Console.Write($" | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee}");
            Console.Write($" | Price: {Price} | Final: {CalculateFinalPrice():F2}");
            Console.WriteLine($" | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
