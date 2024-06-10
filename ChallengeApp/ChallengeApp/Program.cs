using ChallengeApp;

List<Employee> employes = new List<Employee>();
employes.Add(new Employee("marek", "nowak", 23));
employes.Add(new Employee("andrzej", "kowalski", 43));
employes.Add(new Employee("tomasz", "kot", 32));
var rand = new Random();
List<int> results = new List<int>();
results.Add(0);
int MaxGrade = 0;

for (int i = 0; i < 5; i++)
{
    foreach (var emp in employes)
        emp.AddGrade(rand.Next(1, 10));
}

for (int i = 0; i < employes.Count(); i++)
{
    if (employes[i].SumGrades > MaxGrade)
    {
        MaxGrade = employes[i].SumGrades;
        results.Clear();
        results.Add(i);
    }
    else if (employes[i].SumGrades == MaxGrade)
    {
        results.Add(i);
    }
}

foreach (var res in results)
{
    employes[res].Display();
}
