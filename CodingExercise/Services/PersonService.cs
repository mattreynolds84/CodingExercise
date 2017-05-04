using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodingExercise.Models;

namespace CodingExercise.Services
{
    public class PersonService
    {
        private List<Person> _people;

        public PersonService()
        {
            PopulatePeople();
        }

        public List<Person> GetAllPeople()
        {
            return _people;
        }

        private void PopulatePeople()
        {
            _people = new List<Person>();
            for (int i = 0; i <= 20; i++)
            {
                var person = new Person()
                {
                    Id = i,
                    FirstName = $"Fisrtname{i}",
                    LastName = $"Lastname{i}",
                    Age = i * 1 + 5,
                    Email = $"person{i}@email.com"
                };
            }
        }
    }
}