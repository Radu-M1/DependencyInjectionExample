using ServiceContracts;

namespace Services;

public class CitiesService : ICitiesService, IDisposable
{
    private List<string> _cities;
    private Guid _serviceId;

    public CitiesService()
    {
        _serviceId = Guid.NewGuid();
        _cities = new List<string>
        {
            "New York",
            "Los Angeles",
            "Chicago",
            "Houston",
            "Phoenix"
        };
        // TO DO: Add logic to open the db connection
    }

    public List<string> GetCities()
    {
        return _cities;
    }

    public void Dispose()
    {
        // throw new NotImplementedException();
        //TO DO: add logic to close db connection
    }

    public Guid ServiceId
    {
        get { return _serviceId; }
    }
}