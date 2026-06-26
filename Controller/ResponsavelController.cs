using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_BackEnd_Final.Data;
using Projeto_BackEnd_Final.Models;

namespace Projeto_BackEnd_Final.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ResponsavelController : ControllerBase
    {

        private readonly DataContext _context;



        public ResponsavelController(DataContext context)
        {
            _context = context;



        }

     [HttpGet("{id}")]

public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Responsavel p = await _context.TB_RESPONSAVEL.FirstOrDefaultAsync(pBusca => pBusca.Id ==id);


                return Ok(p);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex)
            } 
        }

    }
}