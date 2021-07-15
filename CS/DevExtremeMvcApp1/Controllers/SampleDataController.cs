using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DevExtremeMvcApp1.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;

namespace DevExtremeMvcApp1.Controllers {
    public class SampleDataController : ApiController {

        [HttpGet]
        public HttpResponseMessage GetTasks(DataSourceLoadOptions loadOptions) {
            return Request.CreateResponse(DataSourceLoader.Load(GanttDataProvider.Tasks, loadOptions));
        }

        [HttpGet]
        public HttpResponseMessage GetDependencies(DataSourceLoadOptions loadOptions) {
            return Request.CreateResponse(DataSourceLoader.Load(GanttDataProvider.Dependencies, loadOptions));
        }

        [HttpGet]
        public HttpResponseMessage GetResources(DataSourceLoadOptions loadOptions) {
            return Request.CreateResponse(DataSourceLoader.Load(GanttDataProvider.Resources, loadOptions));
        }

        [HttpGet]
        public HttpResponseMessage GetResourceAssignments(DataSourceLoadOptions loadOptions) {
            return Request.CreateResponse(DataSourceLoader.Load(GanttDataProvider.ResourceAssignments, loadOptions));
        }


    }
}