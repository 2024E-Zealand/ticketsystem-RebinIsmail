namespace TicketClassLibrary
{


    public abstract class Vehicle
    {
   
     /// sætter nummerpladen for køretøjet.
      
        protected string licenseplate;

 
     /// sætter datoen knyttet til køretøjet.
        
        public DateTime Date { get; set; }

      
        /// En property for licensplate.
       
        public string Licenseplate
        {
            get => licenseplate;
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Nummerpladen må ikke overstige 7 tegn.");
                }
                licenseplate = value;
            }
        }

      
        /// Returner priss for at køre ved broen.
   
        /// Returnerer prisen for køretøjet.
        public abstract double Price(bool useBrobizz = false);

        /// Returnerer type af køretøjet.
    
        public abstract string VehicleType();
    }
}