public class Person
{
    public required Identification Identification {get; set;}

    public required ContactDetails ContactDetails {get; set;}

    public required Business Business {get; set;}
}


public class Identification
{
    public required int ID {get; set;}
    public required string Name {get; set;} 
}

public class ContactDetails
{
    public required string Email {get; set;} 

    public required string Adress {get; set;} 

    public required string PostNum {get; set;} 

    public required string Place {get; set;} 
}

public class Business
{
    public required string CompanyName {get; set;} 

    public required string CompanySlogan {get; set;} 

}