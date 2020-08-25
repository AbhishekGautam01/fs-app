using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sapient.API.DTO;
using Sapient.Repository;
using Sapient.Services.Abstraction;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sapient.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IMedicineService _medicineService;
        public MedicineController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }
        // GET: api/<MedicineController>
        [HttpGet("GetMedicines")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _medicineService.GetMedicines());
            }catch(Exception ex)
            {
                Response response = new Response
                {
                    IsSucces = false,
                    Message = "Some Error Occoured While processing Request"
                };

                return StatusCode(500, response);
            }
        }

        
        // POST api/<MedicineController>
        [HttpPost("Create")]
        public async Task<IActionResult> Post([FromBody] Medicines value)
        {
            try
            {
                bool result = await _medicineService.CreateMedcine(value);
                if (result)
                {
                    return Ok(new Response { IsSucces = true, Message = "Medicine Successfully Created" }) ; 
                } else
                {
                    return BadRequest(new Response { IsSucces = false, Message = "Medicine Creation Failed" });
                }
            } catch(Exception ex)
            {
                Response response = new Response
                {
                    IsSucces = false,
                    Message = "Some Error Occoured While processing Request"
                };

                return StatusCode(500, response);
            }
        }

       
       
    }
}
