using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodingExercise.Filters;
using CodingExercise.Models;
using CodingExercise.Services;

namespace CodingExercise.Controllers
{
    public class ValuesController : ApiController
    {
        public List<Person> GetAllPeople()
        {
            var service = new PersonService();
            return service.GetAllPeople();
        }
    }
}
