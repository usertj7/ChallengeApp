using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
            : base(name, surname) { }


        public Employee(string name)
            : this(name, "no surname") { }


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (grade.Length == 1)
            {
                char character = char.Parse(grade);
                AddGrade(character);
            }
            else
            {
                throw new Exception("string is not a float");
            }
        }

        public void AddGrade(double grade)
        {


            this.AddGrade((float)grade);
        }

        public void AddGrade(long grade)
        {

            this.AddGrade((float)grade);
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;

                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                default:
                    throw new Exception("wrong letter");




            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;


            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var a when a > 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a > 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var a when a > 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a > 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
