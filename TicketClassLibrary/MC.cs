
namespace TicketClassLibrary
{

    /// Repræsenterer en motorcykel (MC) med et nummerplade og en dato.

    public class MC
    {
     
        /// Får eller sætter nummerpladen for motorcyklen.

        public string Licenseplate { get; set; }

 
        /// Får eller sætter datoen knyttet til motorcyklen.

        public DateTime Date { get; set; }


        /// Returnerer den faste pris for at krydse broren for en motorcykel.


        public double Price()
        {
            return 125;
        }


        /// Returnerer typen af køretøjet.
        
        public string VehicleType()
        {
            return "MC";
        }
    }
}