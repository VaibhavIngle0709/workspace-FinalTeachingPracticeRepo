using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace demowebapi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class FruitsController: ControllerBase
    {
        static List<string> Fruits=new List<string>{"Apple","Mango","Banana","Orange","Kivi","Watermellon","Chikku","Straberry"};
    [HttpGet]
   // [Route("ShowFruits")]
    public IEnumerable<string> GetFruits()
    {
        return Fruits;
    }
    [HttpGet]
    [Route("ShowFruits/{id}")]
    public string GetSingleFruit(int id)
    {
      return Fruits[id];
    }

    [HttpPost]
    [Route("AddFruit")]
    public void Post([FromBody]string a){
        Fruits.Add(a);
    }
 
    [HttpPut]
    [Route("Edit/{id}")]
    public void Put(int id,[FromBody] string a){
        Fruits[id]=a;
    }
   
    [HttpDelete]
    [Route("Kill/{id}")]
    public void Delete(int id){
        Fruits.Remove(Fruits[id]);
    }
    
    }
  
}