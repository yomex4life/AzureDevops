using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using colourapiaugtwentyone.Dtos;
using colourapiaugtwentyone.Models;
using colourapiaugtwentyone.Repos;
using Microsoft.AspNetCore.Mvc;


namespace colourapiaugtwentyone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColoursController : Controller
    {
        private readonly IColourRepo _colourRepo;
        private readonly IMapper _mapper;

        public ColoursController(IColourRepo colourRepo, IMapper mapper)
        {
            _colourRepo = colourRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllColoursAsync()
        {
            var colours = await _colourRepo.GetAllColoursAsync();
            if(colours == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<List<Colour>, List<ColourDto>>(colours.ToList()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleColourAsync(int id)
        {
            if(ModelState.IsValid)
            {
                var colour = await _colourRepo.GetColourAsync(id);
                var convertedColour = _mapper.Map<ColourDto>(colour);
                if(colour == null)
                {
                    return NotFound();
                }
                return Ok(convertedColour);
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> CreateColourAsync([FromBody] ColourDto colourDto)
        {
            if(ModelState.IsValid)
            {
                var newColour = _mapper.Map<Colour>(colourDto);
                await _colourRepo.AddColourAsync(newColour);
                var result = await _colourRepo.SaveChanges();

                if(!result)
                {
                    return StatusCode(500);
                }

                return CreatedAtAction(nameof(GetSingleColourAsync), new { id = newColour.Id }, _mapper.Map<ColourDto>(newColour));
            }

            return BadRequest();
        }
    }
}
