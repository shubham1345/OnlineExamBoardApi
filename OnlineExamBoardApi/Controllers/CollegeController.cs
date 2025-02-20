using Microsoft.AspNetCore.Mvc;
using OnlineExamBoardApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineExamBoardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        private readonly DbOnlineExamBoardContext _context;
        public CollegeController(DbOnlineExamBoardContext context)
        {
            _context = context;
        }
        // GET: api/<CollegeController>
        [HttpGet]
        public IEnumerable<TblCollegeDetail> Get()
        {
            return  _context.TblCollegeDetails.ToList();
        }

        // GET api/<CollegeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CollegeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CollegeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CollegeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
