using TicketClassLibrary;

public class MC : Vehicle
{
    /// Returnerer den faste pris for at krydse broen for en motorcykel.
    public override double Price(bool useBrobizz = false)
    {
        double price = 125;
        if (useBrobizz)
        {
            price *= 0.95; // 5% discount
        }
        return price;
    }

    /// Returnerer typen af køretøjet.
    /// <returns>En streng, der angiver køretøjstypen, som er "MC".</returns>
    public override string VehicleType()
    {
        return "MC";
    }
}