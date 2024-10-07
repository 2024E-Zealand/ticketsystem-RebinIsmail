namespace TicketClassLibrary
{
    /// <summary>
    /// Vi ser en klasse, som repræsenterer en motorcykel (MC).
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Vi ser metoden, som returnerer prisen for motorcykler og giver en rabat, hvis Brobizz bruges.
        /// </summary>
        public override double Price(bool useBrobizz = false)
        {
            double price = 125;
            if (useBrobizz)
            {
                price *= 0.95; // 5% rabat
            }
            return price;
        }

        /// <summary>
        /// Vi ser en metode, der returnerer køretøjstypen, som her er "MC".
        /// </summary>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}