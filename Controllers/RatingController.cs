using First_appl_MVVM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebGymnasticApp.Controllers
{
    public class RatingController : ApiController
    {
        Server _server = new Server();
        [HttpGet]
        [Route("api/rating/{id}/{discipline}")]
        public List<Rating> GetRating(int id, string discipline)
        {
            if (discipline == null)
            {
                throw new ArgumentNullException("Not defined field \"discipline\"");
            }
            return _server.GetRatings(id, discipline);
        }
        //need sort out with throw exception!!!
        [HttpPut]
        public void PutRating(List<Rating> ratings)
        {
            if(ratings == null)
            {
                throw new ArgumentNullException();
            }
            foreach(Rating rating in ratings)
            {
                _server.PutRatings(rating);
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _server.DeleteRating(id);
        }
    }
}
