using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoreWebApplication.Controllers.Resources;
using CoreWebApplication.Models;
using CoreWebApplication.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApplication.Controllers
{
    public class MakesController : Controller
    {
       
        private readonly CWADbContext context;
        private readonly IMapper mapper;
        public MakesController(CWADbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }




        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes= await context.Makes.Include(m => m.Models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }

    }
}