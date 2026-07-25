using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace OOP_6;
public partial class Cinema
{
    public void PrintAllTickets()
    {
        Console.WriteLine("--- All Tickets (from Cinema.Reporting) ---");

        foreach (var ticket in _tickets)
        {
            if (ticket != null)
                ticket.PrintInfo();
        }
    }

    public int GetBookedCount()
    {
        int count = 0;

        foreach (var ticket in _tickets)
        {
            if (ticket != null && ticket.IsBooked)
                count++;
        }

        return count;
    }

    public decimal GetTotalRevenue()
    {
        decimal total = 0;

        foreach (var ticket in _tickets)
        {
            if (ticket != null && ticket.IsBooked)
                total += ticket.CalculateFinalPrice();
        }

        return total;
    }
}
