using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PeepsApi.Entities
{
    public class DAL
    {
        List<Demographic> _demographics = null;

        public List<Demographic> GetDemographics()
        {
            return _demographics ?? RefreshDemographics();
        }

        private List<Demographic> RefreshDemographics()
        {
            string json = File.ReadAllText(System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/state_demographics.json"));
            var demographicList = JsonConvert.DeserializeObject<List<Demographic>>(json);
            return demographicList;
        }

    }
}