using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using prototype.Service.PlaylistUseCases.Queries;

namespace prototype.Controllers
{
	public class LibraryController : Controller
    {
        private readonly IMediator _mediator;

        public LibraryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlaylistsByUser(int id)
        {
            var result = await _mediator.Send(new GetPlaylistByIdQuery(id));
            if (result.StatusCode == 200)
            {
                return Json(result.Data);
            }
            else
            {
                return BadRequest(result.Description);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetSongsByPlaylist(int id)
        {
            var result = await _mediator.Send(new GetSongByIdQuery(id));
            if (result.StatusCode == 200)
            {
                return Json(result.Data);
            }
            else
            {
                return BadRequest(result.Description);
            }
        }

    }
}

