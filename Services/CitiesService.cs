using ServiceContracts;

namespace Services;

public class CitiesService : ICitiesService
{
    private List<string> _cities;

    public CitiesService()
    {
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
    public List<string> AddCity(string city)
    {
        _cities.Add(city);
        return _cities;
    }
    public List<string> RemoveCity(string city)
    {
        _cities.Remove(city);
        return _cities;
    }

    public List<string> UpdateCity(string oldCity, string newCity)
    {
        var index = _cities.IndexOf(oldCity);
        if (index != -1)
        {
            _cities[index] = newCity;
        }
        return _cities;
    }
}
