using IdentityServer.API2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IdentityServer.API2.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PicturesController : Controller
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetPictures()
        {
            var Pictures = new List<Picture>()
            {
                new Picture{Id=1,Name="Resim1",Url="Resim1.jpg"},
                new Picture{Id=2,Name="Resim2",Url="Resim2.jpg"},
                new Picture{Id=3,Name="Resim3",Url="Resim3.jpg"},
            };


            return Ok(Pictures);
        }
    }
}
