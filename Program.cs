
bool isRunning = true;

Console.WriteLine("Välkommen till Personregistret!");
Console.WriteLine("Här kan du söka efter personer, sortera dem och se de fem första i registret.");
Console.WriteLine("----------------------------------------------------");

while (isRunning)
{ 


Console.WriteLine("Här är personregistrets menyval:");
Console.WriteLine("1. Sortera efter ID");
Console.WriteLine("2. Sortera efter Namn");
Console.WriteLine("3. Visa de fem första personerna i registret efter ID");
Console.WriteLine("4. Visa de fem första personerna i registret efter Namn");
Console.WriteLine("5. Sök efter en person i registret");
Console.WriteLine("6. Se menyn igen");

Console.WriteLine("7. Avsluta programmet");
Console.WriteLine("----------------------------------------------------");

string? userInput = Console.ReadLine();

switch (userInput)
{
    case "1":
    SortPublicDataId sortPublicData = new SortPublicDataId();
sortPublicData.SortAfterId();
        break;
    case "2":
    SortPublicDataName sortPublicDataName = new SortPublicDataName();
sortPublicDataName.SortAfterName();
        break;
    case "3":
    GetTopFiveID getTopFiveId = new GetTopFiveID();
getTopFiveId.FirstFiveId();
        break;
    case "4":
    GetTopFiveName getTopFiveName = new GetTopFiveName();
getTopFiveName.FirstFiveName();
        break;
    case "5":
    SearchPeople searchPerson = new SearchPeople();
searchPerson.SearchPerson();
        break;
    case "6":
        Console.WriteLine("Visar menyn igen.");
        break;
    case "7":
        Console.WriteLine("Programmet avslutas.");
        isRunning = false;
        break;
    default:
        Console.WriteLine("Ogiltigt val. Vänligen välj ett alternativ från menyn.");
        break;
}
}




// SortPublicDataId sortPublicData = new SortPublicDataId();
// sortPublicData.SortAfterId();


// SortPublicDataName sortPublicDataName = new SortPublicDataName();

// sortPublicDataName.SortAfterName();


// GetTopFiveID getTopFiveId = new GetTopFiveID();
// getTopFiveId.FirstFiveId();



// GetTopFiveName getTopFiveName = new GetTopFiveName();
// getTopFiveName.FirstFiveName();



// SearchPeople searchPerson = new SearchPeople();
// searchPerson.SearchPerson();
