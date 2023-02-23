using it_planet.repository;
using it_planet.service.account;
using it_planet.service.location;

namespace it_planet.service;

public class Service
{
    public IAccount Account;
    public ILocation Location;
    
    public Service(Repository repository)
    {
        Account = new Account(repository);
        Location = new Location(repository);
    }
}