using ChallengeApp;


var employee = new Employee("marek", "kot");
employee.AddGrade(5);
employee.AddGrade("8");
employee.AddGrade(3.141592653589793238463);
var statistics = employee.GetStatistics();
Console.WriteLine($"average: {statistics.Average:N3}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

var statistics1 = employee.GetStatisticsWithFor();
Console.WriteLine($"average: {statistics1.Average:N3}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

var statistics2 = employee.GetStatisticsWithDoWhile();
Console.WriteLine($"average: {statistics2.Average:N3}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

var statistics3 = employee.GetStatisticsWithWhile();
Console.WriteLine($"average: {statistics3.Average:N3}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");



