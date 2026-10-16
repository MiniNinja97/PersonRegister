
IPersonData? selectedData = null;
// if (args.Length > 0 && args[0] == "api")
// {
//     selectedData = new ApiPersonData();
// }

if (args.Length == 2 && args[0] == "list" && args[1] == "--top5")
{
    selectedData = new PersonData();
    GetTopFiveID getTopFiveId = new GetTopFiveID(selectedData);
    await getTopFiveId.FirstFiveId();
    return;
}

if (args.Length == 2 && args[0] == "list" && args[1] == "--sort")
{
    selectedData = new PersonData();
    SortPublicDataId sortPublicData = new SortPublicDataId(selectedData);
    await sortPublicData.SortAfterId();
    return;
}

if (args.Length == 3 && args[0] == "list" && args[1] == "--sort" && args[2] == "--top5")
{
    selectedData = new PersonData();

    GetTopFiveID getTopFiveId = new GetTopFiveID(selectedData);
    await getTopFiveId.FirstFiveId();

    return;
}

if (args.Length == 3 && args[0] == "list" && args[1] == "--search")

{
    selectedData = new PersonData();
    if (string.IsNullOrWhiteSpace(args[2]))
    {
        Console.WriteLine("The search tect is incorrect!");
        return;
    }

    SearchPeople searchPerson = new SearchPeople(selectedData);
    await searchPerson.SearchPerson(args[2]);
    return;
}

if (args.Length == 1 && args[0] == "list")
{
    selectedData = new PersonData();

    ListPeople listPeople = new ListPeople(selectedData);
    await listPeople.ListAllPeople();

    return;

}

if (args.Length > 0 )
{
    Console.WriteLine("Invalid command");
    return;
}




Console.WriteLine("Välkommen till Personregistret!");
Console.WriteLine("Här kan du söka efter personer, sortera dem och se de fem första i registret.");
Console.WriteLine("----------------------------------------------------");



bool isRunning = true;
while (isRunning)
{
    if (selectedData == null)
    {

        Console.WriteLine("Välj ett personrigister att söka i:");
        Console.WriteLine("1. Personregiser från lokat lager");
        Console.WriteLine("2. Personregiser från API");



        string? firstUserInput = Console.ReadLine();

        switch (firstUserInput)
        {
            case "1":
                selectedData = new PersonData();

                break;
            case "2":
                selectedData = new ApiPersonData();


                break;
        }

        if (selectedData == null)
        {
            Console.WriteLine("Du måste välja ett regiser först!");
            continue;
        }
    }

    bool isSelected = true;
    while (isSelected && selectedData != null)
    {
        Console.WriteLine("Här är personregistrets menyval:");
        Console.WriteLine("1. Sortera efter ID");
        Console.WriteLine("2. Sortera efter Namn");
        Console.WriteLine("3. Visa de fem första personerna i registret efter ID");
        Console.WriteLine("4. Visa de fem första personerna i registret efter Namn");
        Console.WriteLine("5. Sök efter en person i registret");
        Console.WriteLine("6. Tillbaka till registervalet");

        Console.WriteLine("7. Avsluta programmet");
        Console.WriteLine("----------------------------------------------------");

        string? userInput = Console.ReadLine();





        switch (userInput)
        {
            case "1":
                SortPublicDataId sortPublicData = new SortPublicDataId(selectedData);
                await sortPublicData.SortAfterId();
                break;
            case "2":
                SortPublicDataName sortPublicDataName = new SortPublicDataName(selectedData);
                await sortPublicDataName.SortAfterName();
                break;
            case "3":
                GetTopFiveID getTopFiveId = new GetTopFiveID(selectedData);
                await getTopFiveId.FirstFiveId();
                break;
            case "4":
                GetTopFiveName getTopFiveName = new GetTopFiveName(selectedData);
                await getTopFiveName.FirstFiveName();
                break;
            case "5":
                SearchPeople searchPerson = new SearchPeople(selectedData);
                await searchPerson.SearchPerson();
                break;
            case "6":
                Console.WriteLine("Återgår till registervalet.");
                isSelected = false;
                selectedData = null;
                break;
            case "7":
                Console.WriteLine("Programmet avslutas.");
                isRunning = false;
                isSelected = false;
                break;
            default:
                Console.WriteLine("Ogiltigt val. Vänligen välj ett alternativ från menyn.");
                break;
        }
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
