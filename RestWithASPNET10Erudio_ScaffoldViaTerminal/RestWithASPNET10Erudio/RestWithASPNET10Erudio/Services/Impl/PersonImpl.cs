using RestWithASPNET10Erudio.Model;

namespace RestWithASPNET10Erudio.Services.Impl;

public class PersonImpl : IPersonService
{
    public Person FindById(long id)
    {
        var person = MockPerson((int)id);

        return person;
    }

    public List<Person> FindAll()
    {
        List<Person> people = new List<Person>();
        for (int i = 0; i < 8; i++)
        {
            people.Add(MockPerson(i));
        }
        return people;
    }
    
    public Person Create(Person person)
    {
        person.Id = new Random().Next(1, 1000);
        return person;
    }
    
    public Person Update(Person person)
    {
        return person;
        throw new NotImplementedException();
    }
     
    public void Delete(long id)
    {
        //Simulate delete logic
        throw new NotImplementedException();
    }
    
    private Person MockPerson(int i)
    {
        return new Person
        {
            Id = new Random().Next(1, 1000),
            FirstName = "John" + " " + i,
            LastName = "Doe" + " "  + i,
            Address = "123 Main St, Anytown, USA" + " "  + i,
            Gender = "Male"
        };
    }
}