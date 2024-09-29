
namespace TicketClassLibrary
{
    /// Repræsenterer en bil med et nummerplade og en dato.
    public class Car
    {

        /// Får eller sætter nummerpladen for bilen.
   
        public string Licenseplate { get; set; }


        /// Får eller sætter datoen knyttet til bilen.

        public DateTime Date { get; set; }


        /// Returnerer den faste pris for at krydse broenn.
        
        public double Price()
        {
            return 240;
        }

        /// Returnerer typen af køretøjet.
       
        public string VehicleType()
        {
            return "Car";
        }
    }
}