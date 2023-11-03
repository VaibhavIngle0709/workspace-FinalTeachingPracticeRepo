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
    [HttpPost]
    public IEnumerable<string> Get()
    {
        return Fruits;
    }
    }
  
}