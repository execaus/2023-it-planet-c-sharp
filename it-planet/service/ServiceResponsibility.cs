using it_planet.repository;

namespace it_planet.service;

public class ServiceResponsibility
{
    protected readonly Repository _repository;
    
    public ServiceResponsibility(Repository repository)
    {
        _repository = repository;
    }
}