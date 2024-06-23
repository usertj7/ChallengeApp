using ChallengeApp;


var employee = new Employee("marek", "kot");
employee.AddGrade(2);
employee.AddGrade(8);
employee.AddGrade(4);
var statistics = employee.GetStatistics();
Console.WriteLine($"average: {statistics.Average:N3}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");



