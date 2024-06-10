namespace ChallengeApp
{
    internal class Employee
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        private List<int> Grades = new List<int>();

        public void AddGrade(int Grade)
        {
            Grades.Add(Grade);
        }
        public int SumGrades { get { return Grades.Sum(); } }

        public void Display()
        {
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("Last Name: "+LastName);
            Console.WriteLine("Age: "+Age);
            Console.WriteLine("Score: " + Grades.Sum());
        }
        public Employee(string name, string lastname, int age)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Age = age;

        }
    }
}
