using AutoMapper;
using Azure;
using Exam.Data;
using Exam.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusesController : ControllerBase
    {
        private readonly BusBookingContext context;
        private readonly IMapper mapper;

        public BusesController(BusBookingContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        // GET: api/<BusesController>
        [HttpGet]
        public ActionResult<List<Bus>> Get()
        {
            List<Bus> list = context.buses.ToList();
            List<Bus> activeBuses = new List<Bus>();
            foreach (var bus in list)
            {
                if (bus.Status)
                {
                    activeBuses.Add(bus);
                }
            }
            if (activeBuses == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return Ok(activeBuses);
        }

        // GET api/<BusesController>/5
        [HttpGet("{busId}")]
        public ActionResult<Bus> Get(int busId)
        {
            var bus = context.buses.FirstOrDefault(x => x.Id == busId);
            if (bus == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "Bus is not available");
            }
            return Ok(bus);
        }

        // POST api/<BusesController>
        [HttpPost]
        public ActionResult<busDTO> Post([FromBody] busDTO bus)
        {
            if (bus.BusName == "" || bus.From == "" || bus.To == "" || bus.Image == "")
            {
                return StatusCode(StatusCodes.Status400BadRequest, "entered data is not proper/ you are missing something");
            }
            var AddBus = mapper.Map<Bus>(bus);
            context.buses.Add(AddBus);
            context.SaveChanges();
            return Created("",AddBus);
        }

        // PUT api/<BusesController>/5
        [HttpPut("{busId}")]
        public ActionResult<busDTO> Put(int busId, [FromBody] busDTO busUpdate)
        {

            var busdto = context.buses.FirstOrDefault(x => x.Id == busId);
            if (busdto == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "Bus is not available");
            }
            var bus = mapper.Map<Bus>(busdto);
            bus.BusName = busUpdate.BusName;
            bus.Status = busUpdate.Status;
            bus.To = busUpdate.To;
            bus.From = busUpdate.From;
            bus.Image = busUpdate.Image;
            context.buses.Update(bus);
            context.SaveChanges();
            return Ok(busdto);
        }

        [HttpPatch("{busId}")]
        public ActionResult<Bus> patch(int busId, [FromBody] JsonPatchDocument<Bus> patch)
        {
            var bus = context.buses.FirstOrDefault(x => x.Id == busId);
            patch.ApplyTo(bus, ModelState);
            context.buses.Update(bus);
            context.SaveChanges();
            return Ok(bus);
        }

        // DELETE api/<BusesController>/5
        [HttpDelete("{busId}")]
        public ActionResult<Bus> Delete(int busId)
        {
            var bus = context.buses.FirstOrDefault(x => x.Id == busId);
            bus.Status = false;
            context.buses.Update(bus);
            context.SaveChanges();
            return Ok(bus);
        }
    }
}
