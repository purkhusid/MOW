using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MOW.DotNetCoreApi.Models;

namespace MOW.DotNetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return new List<Item>
            {
                new Item
                {
                    Sku = "123",
                    Description = "Desc",
                    Name = "Nameið",
                }
            };
        }
    }
}
