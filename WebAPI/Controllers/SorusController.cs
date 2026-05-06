
using Business.Handlers.Sorus.Commands;
using Business.Handlers.Sorus.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Entities.Concrete;
using System.Collections.Generic;
using Core.Entities.Concrete.Project;
using System;

namespace WebAPI.Controllers
{
    /// <summary>
    /// Sorus If controller methods will not be Authorize, [AllowAnonymous] is used.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SorusController : BaseApiController
    {
        ///<summary>
        ///List Sorus
        ///</summary>
        ///<remarks>Sorus</remarks>
        ///<return>List Sorus</return>
        ///<response code="200"></response>
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Soru>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpGet("getall")]
        [Authorize]
        public async Task<IActionResult> GetList()
        {
            var result = await Mediator.Send(new GetSorusQuery());
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        ///<summary>
        ///It brings the details according to its id.
        ///</summary>
        ///<remarks>Sorus</remarks>
        ///<return>Sorus List</return>
        ///<response code="200"></response>  
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Soru))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpGet("getbyid")]
        [Authorize]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await Mediator.Send(new GetSoruQuery { Id = id });
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        /// <summary>
        /// Add Soru.
        /// </summary>
        /// <param name="createSoru"></param>
        /// <returns></returns>
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add([FromBody] CreateSoruCommand createSoru)
        {
            var result = await Mediator.Send(createSoru);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        /// <summary>
        /// Update Soru.
        /// </summary>
        /// <param name="updateSoru"></param>
        /// <returns></returns>
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Update([FromBody] UpdateSoruCommand updateSoru)
        {
            var result = await Mediator.Send(updateSoru);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        /// <summary>
        /// Delete Soru.
        /// </summary>
        /// <param name="deleteSoru"></param>
        /// <returns></returns>
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> Delete([FromBody] DeleteSoruCommand deleteSoru)
        {
            var result = await Mediator.Send(deleteSoru);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        /// <summary>
        /// Soru + 4 veya 5 şık (form alanları). 5. şık boşsa yalnızca 4 şık kaydedilir. GorselUrl yok.
        /// </summary>
        
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpPost("withseceneklerform")]
        [Authorize]
        public async Task<IActionResult> AddWithSeceneklerForm([FromForm] CreateSoruWithSeceneklerFormCommand createSoruWithSecenekler)
        {
           try
            {
                var result = await Mediator.Send(createSoruWithSecenekler);
                if (result.Success)
                {
                    return Ok(result.Message);
                }
                return BadRequest(result.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { 
                    error = ex.Message, 
                    stackTrace = ex.StackTrace,
                    innerException = ex.InnerException?.Message,
                    source = ex.Source
                });
            }
        }
    }
}
