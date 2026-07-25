namespace OOP_6
{
    public class StandardTicket : Ticket
{
        public string SeatNumber { get; set; }

        public StandardTicket(string movieName, decimal price, string seatNumber)
        :base(movieName, price)
    {
            SeatNumber = seatNumber;
        }

        public override decimal CalculateFinalPrice()
    {
            return Price * 1.14m;
        }

        public override void PrintInfo()
    {
            Console.Write($"[Ticket #{TicketId}] {MovieName} | Standard");
            Console.Write($" | Seat: {SeatNumber}");
            Console.Write($" | Price: {Price} | Final: {CalculateFinalPrice():F2}");
            Console.WriteLine($" | Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}
