namespace TicketClassLibrary
{
    /// <summary>
    /// Repræsenterer en bil med et nummerplade og en dato.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Returnerer en fast pris på 125 DKK for at komme over broen.
        /// Hvis Brobizz anvendes, gives der 5% rabat.
        /// </summary>
        /// <param name="useBrobizz">Angiver, om Brobizz anvendes for en rabat.</param>
        /// <returns>Prisen for at krydse broen i DKK.</returns>
        public override double Price(bool useBrobizz = false)
        {
            double price = 125;
            if (useBrobizz)
            {
                price *= 0.95; // 5% discount
            }
            return price;
        }

        /// <summary>
        /// Returnerer typen af køretøjet.
        /// </summary>
        /// <returns>Returnerer altid "Car" som typen af køretøjet.</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}