namespace OOP_6
{
    public static class TicketExtensions
  {
        public static string ToReceipt(this Ticket ticket)
    {
            string line = "=============================";
            return $"========== RECEIPT ==========\n"
            + $"  Movie  : {ticket.MovieName}\n"
            + $"  Type   : {ticket.GetType().Name}\n"
            + $"  Price  : {ticket.Price}\n"
            + $"  Final  : {ticket.CalculateFinalPrice():F2}\n"
            + $"  Status : {(ticket.IsBooked ? "Booked" : "NotBooked")}\n"
            + line;
        }

        public static decimal TotalRevenue(this Ticket[] tickets)
    {
            decimal total = 0;

            foreach (var t in tickets)
            {
                if (t != null && t.IsBooked)
                    total += t.CalculateFinalPrice();
            }

            return total;
        }
    }
}
