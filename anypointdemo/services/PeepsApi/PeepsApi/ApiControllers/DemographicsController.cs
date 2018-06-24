using PeepsApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PeepsApi.ApiControllers
{
    [RoutePrefix("api/demographics")]
    public class DemographicsController : ApiController
    {
        DAL _dal = new DAL();

        // GET api/<controller>
        [HttpGet()]
        [Route("ethnicities/{state}")]
        public IEnumerable<Ethnicities> GetEthnicities(string state)
        {
            return _dal.GetDemographics().Select(d => d.Ethnicities).ToList();
        }

        [HttpGet()]
        [Route("education/{state}")]
        public List<Education> GetEducation(string state)
        {
            return _dal.GetDemographics().Select(d => d.Education).ToList();
        }
    }
}