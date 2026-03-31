using ASP_NET_Core.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Core.Controllers;

public class SampleDataController : Controller {

    [HttpGet]
    public object GetTasks(DataSourceLoadOptions loadOptions) {
        return DataSourceLoader.Load(GanttDataProvider.Tasks, loadOptions);
    }

    [HttpGet]
    public object GetDependencies(DataSourceLoadOptions loadOptions) {
        return DataSourceLoader.Load(GanttDataProvider.Dependencies, loadOptions);
    }

    [HttpGet]
    public object GetResources(DataSourceLoadOptions loadOptions) {
        return DataSourceLoader.Load(GanttDataProvider.Resources, loadOptions);
    }

    [HttpGet]
    public object GetResourceAssignments(DataSourceLoadOptions loadOptions) {
        return DataSourceLoader.Load(GanttDataProvider.ResourceAssignments, loadOptions);
    }

}
