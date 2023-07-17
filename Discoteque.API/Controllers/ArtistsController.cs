using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Discoteque.Business.IServices;
using Discoteque.Data.Models;

namespace Discoteque.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistService _artistService;

        public ArtistsController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet]
        [Route("GetAllArtistsAsync")]
        public async Task<IActionResult> GetAllArtistsAsync()
        {
            var artists = await _artistService.GetArtistsAsync();
            return Ok(artists);
        }

        [HttpPost]
        [Route("CreateArtist")]
        public async Task<IActionResult> CreateArtist([FromBody] Artist artist)
        {
             if (artist == null)
            {
                return BadRequest("El objeto Artist es nulo.");
            }
            
            var artists = await _artistService.CreateArtist(artist);
            return Ok(artists);
        }
    }
}
