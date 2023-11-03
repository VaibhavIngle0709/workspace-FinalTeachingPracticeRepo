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
    
    }
  
}