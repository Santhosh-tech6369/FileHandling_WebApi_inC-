using FinalProjectWebApiV0._2.Interface;
using FinalProjectWebApiV0._2.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectWebApiV0._2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IRepo i;
        public StudentController(IRepo i)
        {
            this.i = i;   
        }
        [HttpPost("Insert")]
        public async Task<ActionResult> Insert([FromBody] Student st)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    message = "Model binding failed",
                    errors = ModelState
                        .Where(x => x.Value.Errors.Count > 0)
                        .Select(x => new { Field = x.Key, Error = x.Value.Errors.First().ErrorMessage })
                });
            }

            try
            {
                await i.create(st);
                return Ok("Successfully Inserted");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpGet("GetAll")]
        public async Task<ActionResult> Get()
        {
            var data = await i.Read();
            if (data == null)
            {
                return NotFound($"Student {data} not found."); // Returns HTTP 404
            }
            return Ok(data);
        }
        [HttpGet("Getby/{id}")]
        public async Task<ActionResult> Getbyid(int id)
        {
            var data = await i.Findid(id);
            if (data == null)
            {
                return NotFound($"Student with ID {id} not found."); // Returns HTTP 404
            }
            return Ok(data);
        }

        [HttpPut("Editby/{id}")]
        public async Task<ActionResult> Getbyid(int id, [FromBody] Student st)
        {
            
            var ans = await i.Edit(id, st);
            if (ans)
                return Ok("Updated Sucessfully");
            else
                return BadRequest("Not Updated");
        }



        [HttpDelete("Deleteby/{id}")]
        public async Task<ActionResult> Delete( int id)
        {
            var result = await i.Delete(id);
            if (result)
                return Ok("Deleted Sucessfully");
            else
                return BadRequest("Not Deleted");
        }
    }
}
