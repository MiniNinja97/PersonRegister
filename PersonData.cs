
public class PersonData
{

    Person person1 = new Person
    {
        Identification = new Identification
        {
            ID = 1,
            Name = "Adam Abrahamsson"
        },
        ContactDetails = new ContactDetails {
             

             Email = "adam@email.com",
             Adress = "Första vägen 1",
             PostNum = "123 44",
             Place = "Ale"


        },

        Business = new Business
        {
            CompanyName = "Adamsföretag AB",
            CompanySlogan = "Vi hjälper dig när ingen annan kan"
        }
    };
    Person person2 = new Person
{
    Identification = new Identification
    {
        ID = 7,
        Name = "Sofia Berg"
    },
    ContactDetails = new ContactDetails
    {
        Email = "sofia.berg@email.com",
        Adress = "Björkvägen 14",
        PostNum = "442 35",
        Place = "Kungälv"
    },
    Business = new Business
    {
        CompanyName = "Berg Design AB",
        CompanySlogan = "Design som gör skillnad"
    }
};

Person person3 = new Person
{
    Identification = new Identification
    {
        ID = 3,
        Name = "Viktor Lind"
    },
    ContactDetails = new ContactDetails
    {
        Email = "viktor.lind@email.com",
        Adress = "Skogsgatan 8",
        PostNum = "411 23",
        Place = "Göteborg"
    },
    Business = new Business
    {
        CompanyName = "Lind Teknik AB",
        CompanySlogan = "Teknik för framtiden"
    }
};

Person person4 = new Person
{
    Identification = new Identification
    {
        ID = 10,
        Name = "Elin Karlsson"
    },
    ContactDetails = new ContactDetails
    {
        Email = "elin.karlsson@email.com",
        Adress = "Ängsvägen 22",
        PostNum = "451 50",
        Place = "Uddevalla"
    },
    Business = new Business
    {
        CompanyName = "Karlsson Media AB",
        CompanySlogan = "Vi får idéer att synas"
    }
};

Person person5 = new Person
{
    Identification = new Identification
    {
        ID = 2,
        Name = "Marcus Holm"
    },
    ContactDetails = new ContactDetails
    {
        Email = "marcus.holm@email.com",
        Adress = "Strandgatan 5",
        PostNum = "444 31",
        Place = "Stenungsund"
    },
    Business = new Business
    {
        CompanyName = "Holm Consulting AB",
        CompanySlogan = "Kunskap som tar dig vidare"
    }
};

Person person6 = new Person
{
    Identification = new Identification
    {
        ID = 9,
        Name = "Nora Andersson"
    },
    ContactDetails = new ContactDetails
    {
        Email = "nora.andersson@email.com",
        Adress = "Parkvägen 17",
        PostNum = "443 30",
        Place = "Lerum"
    },
    Business = new Business
    {
        CompanyName = "Nora Studio AB",
        CompanySlogan = "Kreativitet utan gränser"
    }
};

Person person7 = new Person
{
    Identification = new Identification
    {
        ID = 5,
        Name = "Daniel Ek"
    },
    ContactDetails = new ContactDetails
    {
        Email = "daniel.ek@email.com",
        Adress = "Stationsgatan 4",
        PostNum = "441 30",
        Place = "Alingsås"
    },
    Business = new Business
    {
        CompanyName = "Ek Solutions AB",
        CompanySlogan = "Enklare lösningar varje dag"
    }
};

Person person8 = new Person
{
    Identification = new Identification
    {
        ID = 8,
        Name = "Amanda Nilsson"
    },
    ContactDetails = new ContactDetails
    {
        Email = "amanda.nilsson@email.com",
        Adress = "Vallmovägen 11",
        PostNum = "431 44",
        Place = "Mölndal"
    },
    Business = new Business
    {
        CompanyName = "Nilsson & Co AB",
        CompanySlogan = "Tillsammans skapar vi mer"
    }
};

Person person9 = new Person
{
    Identification = new Identification
    {
        ID = 4,
        Name = "Oliver Svensson"
    },
    ContactDetails = new ContactDetails
    {
        Email = "oliver.svensson@email.com",
        Adress = "Hamngatan 19",
        PostNum = "471 32",
        Place = "Skärhamn"
    },
    Business = new Business
    {
        CompanyName = "Svensson Service AB",
        CompanySlogan = "Service hela vägen"
    }
};

Person person10 = new Person
{
    Identification = new Identification
    {
        ID = 6,
        Name = "Klara Johansson"
    },
    ContactDetails = new ContactDetails
    {
        Email = "klara.johansson@email.com",
        Adress = "Ekvägen 27",
        PostNum = "446 35",
        Place = "Älvängen"
    },
    Business = new Business
    {
        CompanyName = "Klara Idéer AB",
        CompanySlogan = "Från idé till verklighet"
    }
};





public List<Person> GetPeople()
    {
        List<Person> people  = new List<Person>();

        people.AddRange(new List<Person>
        {
            person1,
            person2,
             person3,
              person4,
               person5,
                person6,
                 person7,
                  person8,
                   person9,
                    person10
                     

        });

        return people;
    }
    
    

    
}


