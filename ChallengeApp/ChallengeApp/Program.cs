using ChallengeApp;



Console.WriteLine("Witamy w programi do oceny pracownikow");
Console.WriteLine("==================================");


var employee = new Supervisor("marek", "kot");


while (true)
{
    Console.WriteLine("podaj ocene pracownika: ");
    var input = Console.ReadLine();
    if(input=="q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
    
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
