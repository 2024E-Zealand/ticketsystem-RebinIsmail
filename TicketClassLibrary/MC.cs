using TicketClassLibrary;

public class MC : Vehicle
{
    /// Returnerer den faste pris for at krydse broen for en motorcykel.
    /// <returns>Prisen for motorcyklens passage, som altid er 125.</returns>
    public override double Price()
    {
        return 125;
    }

    /// Returnerer typen af køretøjet.
    /// <returns>En streng, der angiver køretøjstypen, som er "MC".</returns>
    public override string VehicleType()
    {
        return "MC";
    }
}