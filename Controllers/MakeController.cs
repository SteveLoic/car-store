using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using digitalcar.Controllers.Models;
using digitalcar.Controllers.Ressources;
using digitalcar.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace digitalcar.Controllers
{
    public class MakeController : Controller
    {
        private readonly DigitalCarDbContext digitalCarDbContext;
        private readonly IMapper mapper;

        public MakeController(DigitalCarDbContext digitalCarDbContext, IMapper mapper)
        {
            this.mapper = mapper;
            this.digitalCarDbContext = digitalCarDbContext;
        }


        [HttpGet("api/makes")]
        public async Task<IEnumerable<MakeRessource>> GetMakes()
        {
            var makes = await digitalCarDbContext.Makes.Include(marke => marke.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeRessource>>(makes);

        }

    }
}