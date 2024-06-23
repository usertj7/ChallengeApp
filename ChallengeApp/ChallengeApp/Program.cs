using ChallengeApp;


var employee = new Employee("marek", "kot");
employee.AddGrade(200);
employee.AddGrade("8");
employee.AddGrade(3.141592653589793238463);
var statistics = employee.GetStatistics();
Console.WriteLine($"average: {statistics.Average:N3}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");



