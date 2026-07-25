using System.Xml.Linq;

namespace OOP_6
{
    public partial class Cinema
    {
        public string CinemaName { get; set; }

        private Projector _projector = new Projector();
        private Ticket[] _tickets = new Ticket[20];

        public Cinema(string name)
        {
            CinemaName = name;
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = t;
                    return true;
                }
            }

            return false;
        }

        public void OpenCinema()
        {
            Console.WriteLine("=== Cinema Opened ===");
            _projector.TurnOn();
        }

        public void CloseCinema()
        {
            _projector.TurnOff();
            Console.WriteLine("=== Cinema Closed ===");
        }
    }
}
