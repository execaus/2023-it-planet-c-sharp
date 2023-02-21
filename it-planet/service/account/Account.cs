using it_planet.models.account;
using it_planet.repository;
using it_planet.repository.postgres;

namespace it_planet.service.account;

public class Account : ServiceResponsibility, IAccount
{
    public Account(Repository repository) : base(repository) {}
    
    public PostgresAccount Registration(RegistrationInput props)
    {
        // TODO валидация
        return _repository.Account.Create(
            props.firstName,
            props.lastName,
            props.email,
            props.password);
    }
}