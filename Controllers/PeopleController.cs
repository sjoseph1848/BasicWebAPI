using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;


namespace WebServer.Controllers
{
  [Route("api/people")]
  public class PeopleController : Controller
  {
    [HttpGet]
    public Person[] Get()
    {
      return Repository.People.ToArray();
    }

    //Get person by ID 
    [HttpGet("{id}")]
    public Person GetPerson(int id)
    {
      return Repository.GetPersonByID(id);
    }
    //Create a new Person
    [HttpPost]
    public void Post([FromBody]Person person)
    {
      Repository.AddPerson(person);
    }
    //Replace existing person 
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]Person person)
    {
      Repository.ReplacePersonByID(id, person);
    }
    //Delete existing person 
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      Repository.RemovePersonByID(id);
    }

  }
}