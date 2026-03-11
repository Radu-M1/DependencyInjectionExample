using ServiceContracts;

namespace Services;

public class CitiesService : ICitiesService
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
    }

    public List<string> GetCities()
    {
        return _cities;
    }

    public Guid ServiceId 
    { 
        get { return _serviceId; }
    }
}