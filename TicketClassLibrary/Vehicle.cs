namespace TicketClassLibrary
{
    /// <summary>
    /// En abstrakt klasse, der repræsenterer et køretøj.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Nummerpladen, som ikke må overstige 7 tegn.
        /// </summary>
        protected string licenseplate;

        /// <summary>
        /// Datoen for køretøjet.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Henter eller sætter nummerpladen og sikrer, at den ikke overstiger 7 tegn.
        /// </summary>
        /// <exception cref="ArgumentException">Kastes hvis nummerpladen overstiger 7 tegn.</exception>
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
                                                                
        /// <summary>
        /// Beregner prisen for at krydse broen.
        /// </summary>
        /// <param name="useBrobizz">Angiver, om Brobizz bruges for at få rabat.</param>
        /// <returns>Prisen for at krydse broen.</returns>
        public abstract double Price(bool useBrobizz = false);

        /// <summary>
        /// Returnerer køretøjets type.
        /// </summary>
        /// <returns>En streng, der angiver køretøjets type.</returns>
        public abstract string VehicleType();
    }
}