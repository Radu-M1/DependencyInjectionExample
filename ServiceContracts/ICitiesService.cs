namespace ServiceContracts;

public interface ICitiesService
{
    List<string> GetCities();
    Guid ServiceId { get; }
}