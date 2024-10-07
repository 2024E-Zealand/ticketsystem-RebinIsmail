namespace TicketClassLibrary
{
    /// <summary>
    /// Vi ser en klasse, som repræsenterer en bil (Car).
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Vi ser en metode, som returnerer en fast pris for bilen, 
        /// med mulighed for rabat hvis Brobizz bruges.
        /// </summary>
        public override double Price(bool useBrobizz = false)
        {
            double price = 240;
            if (useBrobizz)
            {
                price *= 0.95; // 5% rabat
            }
            return price;
        }

        /// <summary>
        /// Vi ser en metode, der returnerer køretøjstypen, som her er "Car".
        /// </summary>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}