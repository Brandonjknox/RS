using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Rs.Business;
using RS.Business.Contracts;
using RS.Business.Managers.Contracts;

namespace RS.Presentation.MVC.Controllers
{
    public class ImageValuesController : ApiController
    {
        public IImageManager ImageManager { get; set; }
        // GET api/values
        public IEnumerable<Image> Get()
        {
            return ImageManager.Images;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete([FromBody]int id)
        {
            ImageManager.Delete(id);
        }
    }
}