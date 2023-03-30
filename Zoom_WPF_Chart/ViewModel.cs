using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom_WPF_Chart
{
    public class ViewModel
    {
        public List<Person> ProductA { get; set; }
        public List<Person> ProductB { get; set; }
        public List<Person> Revenue { get; set; }
        public List<Person> Profit { get; set; }
        public List<Person> Data { get; set; }

        public ViewModel()
        {
            ProductA = new List<Person>();
            ProductB = new List<Person>();

            Revenue = new List<Person>();
            Profit = new List<Person>();

            Data = new List<Person>();

            DateTime dateTime = new DateTime(2018, 1, 1);
            DateTime months = new DateTime(2018, 1, 1);
            Random random = new Random();

            for (int i = 1; i <= 25; i++)
            {
                ProductA.Add(new Person { Date = dateTime, Sales = random.Next(0, 2000) });
                ProductB.Add(new Person { Date = dateTime, Sales = random.Next(0, 2000) });
                dateTime = dateTime.AddDays(15);
            }

            for (int i = 1; i <= 12; i++)
            {
                Revenue.Add(new Person { Date = months, Revenue = random.Next(1800, 2300) });
                Profit.Add(new Person { Date = months, Profit = random.Next(200, 500) });
                months = months.AddMonths(1);
            }

            Data = new List<Person>()
            {
                new Person { Name = "David", Sales = 180 },
                new Person { Name = "Michael", Sales = 100 },
                new Person { Name = "Steve", Sales = 260 },
                new Person { Name = "Joel", Sales = 72 },
                new Person { Name = "Thomas", Sales = 280 }
            };
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public double Sales { get; set; }
        public double Revenue { get; set; }
        public double Profit { get; set; }
    }
}
