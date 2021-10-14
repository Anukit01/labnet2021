using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using TrabajoPractico04.ENTITIES;
using TrabajoPractico04.LOGIC;

namespace TrabajoPractico04.API.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [RoutePrefix("categories")]
    public class CategoriesController : ApiController
    {
        CategoriesLogic logic = new CategoriesLogic();

        // GET api/values
        [Route("getall")]
        public IHttpActionResult GetAll()
        {
            try
            {
                return Ok(logic.GetAll());
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        // GET api/values/5
        [Route("getById/{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            try
            {
                return Ok(Json<Categories>(logic.GetById(id)));
            }
            catch
            {
                return BadRequest("Something went wrong.");
            }
        }

        // POST api/values
        [HttpPost]
        [Route("add")]
        public IHttpActionResult Post([FromBody] Categories category)
        {
            JsonResult<Categories> jsonCategory = null;
            try
            {
                logic.Add(category);
                jsonCategory = Json<Categories>(category);
            }
            catch
            {
                return BadRequest("Something Went wrong.");
            }
            return Created<JsonResult<Categories>>("categories/add", jsonCategory);
        }

        // PUT api/values/5
        [HttpPut]
        [Route("update")]
        public IHttpActionResult Put([FromBody] Categories category)
        {
            try
            {
                logic.Update(category);
            }
            catch
            {
                return BadRequest("Something Went wrong.");
            }
            return Ok("Content has been succesfully updated");
        }

        // DELETE api/values/5
        [Route("delete")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                logic.Delete(id);

            }
            catch
            {
                return BadRequest("The Category could not be deleted.");
            }
            return Ok("Deletion was successful");
        }
    }
}
