using System;
using System.Collections.Generic;
using System.Linq;

namespace WCFSampleApp
{
    class BetService : IBetService
    {
        public List<double> CalculateSin(double[] x)
        {
            return x.Select(p => Math.Sin(p)).ToList();
        }

        public List<Person> GetPerson()
        {
            return new List<Person>
            {
                new Person
                {
                    Name = "John Smith",
                    Age = 45
                },

                new Person
                {
                    Name = "Bob Marley",
                    Age = 24
                }
            };
        }

        public string GetValue(int i)
        {
            return $"you have sent {i}";
        }

    }
}
