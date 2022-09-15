using MicroservicesNet6.Models;

namespace MicroservicesNet6.Services.Implementations
{
    public interface IPersonService
    {
        Person create (Person person);

        Person FindById(long Id);

        List<Person> FindAll();

        Person Updade(Person person);

        void Delete(long id);

    }
}
