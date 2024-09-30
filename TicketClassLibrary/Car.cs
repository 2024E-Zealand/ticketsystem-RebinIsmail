namespace TicketClassLibrary
{
    /// Repræsenterer en bil med et nummerplade og en dato.
    public class Car : Vehicle
    {
        /// Returne en faste pris på 240 DKK for at komme over broen.
        public override double Price()
        {
            return 240;
        }

        /// Returner en type af køretøjet.

        public override string VehicleType()
        {
            return "Car";
        }
    }
}