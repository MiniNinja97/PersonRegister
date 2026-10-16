
using System.Text.Json;
public class ApiPersonData : IPersonData
{

private readonly HttpClient client = new();





public async Task<List<Person>> GetPeople()

    {
       List<Person> people = new List<Person>();

       var json = await client.GetStringAsync("https://randomuser.me/api/?results=100&nat=us");

       var data = new JsonSerializerOptions()
       {
              PropertyNameCaseInsensitive = true    
       };

       var result = JsonSerializer.Deserialize<PersonApiResponse>(json, data);

       int IDCounter = 1;

       if (result == null)
        {
            return people;
        }


       foreach (var randomUser in result.Results)
        {
            Person person = new Person
            {
                Identification = new Identification
                {
                    ID = IDCounter++,
                    Name = $"{randomUser.Name.First} {randomUser.Name.Last}",
                },
                ContactDetails = new ContactDetails
                {
                    Email = randomUser.Email,
                    Adress = $"{randomUser.Location.Street.Number} {randomUser.Location.Street.Name}",
                    PostNum = randomUser.Location.Postcode.ToString(),
                    Place = $"{randomUser.Location.City}, {randomUser.Location.State}"
                },
                Business = new Business
                {
                    CompanyName = $"{randomUser.Name.Last} AB",
                    CompanySlogan = "We are the best! "
                }

                
            };

            
            people.Add(person);
        }



       return people;
    }

    
}

public class PersonApiResponse
{
    public List<RandomUser> Results { get; set; } = new();

    
}

public class RandomUser
{
    public required RandomUserName Name {get; set;}

    public required string Email { get; set; }

    public required RandomUserLocation Location { get; set; }

    
}
// public class RandomUserEmail
// {

    
//     public required string Email {get; set;}
// }

public class RandomUserName

{

    public required string Title {get; set;}
    public required string First {get; set;}
    public required string Last {get; set;}
}

public class RandomUserLocation
{
    public required RandomUserStreet Street { get; set; }
    public required string City {get; set;}
    public required string State {get; set;}
    public required string Postcode {get; set;}
}

public class RandomUserStreet
{
    public required int Number {get; set;}
    public required string Name {get; set;}
}
