using System;
using System.Collections.Generic;

namespace ASP_NET_Core.Models;

public static class GanttDataProvider {
    public static List<GanttTask> Tasks { get; }
    public static List<Dependency> Dependencies { get; }
    public static List<Resource> Resources { get; }
    public static List<ResourceAssignment> ResourceAssignments { get; }

    static GanttDataProvider() {
        Tasks = CreateTasks();
        Dependencies = CreateDependencies();
        Resources = CreateResources();
        ResourceAssignments = CreateResourceAssignments();
    }

    static List<GanttTask> CreateTasks() {
        var result = new List<GanttTask>();
        result.Add(CreateTask("0", "-1", "Software Development", "02/21/2021 08:00:00", "03/15/2021 15:00:00", "02/21/2021 08:00:00", "03/25/2021 12:00:00", "31", "1", "0", "", ""));
        result.Add(CreateTask("1", "0", "Scope", "02/21/2021 08:00:00", "02/26/2021 12:00:00", "02/23/2021 00:00:00", "03/01/2021 00:00:00", "60", "1", "1", "", ""));
        result.Add(CreateTask("2", "1", "Determine project scope", "02/22/2021 08:00:00", "02/24/2021 12:00:00", "02/24/2021 00:00:00", "02/28/2021 00:00:00", "100", "1", "2", "1", "Important"));
        result.Add(CreateTask("3", "1", "Secure project sponsorship", "02/22/2021 13:00:00", "02/23/2021 12:00:00", "02/22/2021 08:00:00", "02/24/2021 00:00:00", "100", "1", "2", "1", ""));
        result.Add(CreateTask("4", "1", "Define preliminary resources", "02/22/2021 13:00:00", "02/26/2021 12:00:00", "02/21/2021 13:00:00", "02/25/2021 00:00:00", "60", "1", "2", "2", ""));
        result.Add(CreateTask("5", "1", "Secure core resources", "02/25/2021 13:00:00", "02/26/2021 12:00:00", "02/27/2021 00:00:00", "02/28/2021 12:00:00", "0", "1", "2", "2", ""));
        result.Add(CreateTask("6", "1", "Scope complete", "02/26/2021 12:00:00", "02/27/2021 12:00:00", "02/27/2021 12:00:00", "03/1/2021 12:00:00", "0", "0", "2", "", "Important"));
        result.Add(CreateTask("7", "0", "Analysis/Software Requirements", "02/26/2021 13:00:00", "03/18/2021 12:00:00", "02/27/2021 00:00:00", "03/21/2021 00:00:00", "80", "1", "1", "", "Important"));
        result.Add(CreateTask("8", "7", "Conduct needs analysis", "02/26/2021 13:00:00", "03/05/2021 12:00:00", "02/24/2021 13:00:00", "03/02/2021 00:00:00", "100", "1", "2", "3", ""));
        result.Add(CreateTask("9", "7", "Draft preliminary software specifications", "03/05/2021 13:00:00", "03/08/2021 12:00:00", "03/08/2021 08:00:00", "03/11/2021 00:00:00", "100", "1", "2", "3", ""));
        result.Add(CreateTask("10", "7", "Develop preliminary budget", "03/08/2021 13:00:00", "03/12/2021 12:00:00", "03/07/2021 13:00:00", "03/10/2021 00:00:00", "100", "1", "2", "2", ""));
        result.Add(CreateTask("11", "7", "Review software specifications/budget with team", "03/12/2021 13:00:00", "03/14/2021 17:00:00", "03/13/2021 17:00:00", "03/16/2021 00:00:00", "100", "1", "2", "2,3", ""));
        result.Add(CreateTask("12", "7", "Incorporate feedback on software specifications", "03/13/2021 08:00:00", "03/19/2021 17:00:00", "03/15/2021 08:00:00", "03/23/2021 17:00:00", "70", "1", "2", "3", ""));
        result.Add(CreateTask("13", "7", "Develop delivery timeline", "03/14/2021 08:00:00", "03/14/2021 17:00:00", "03/14/2021 08:00:00", "03/16/2021 10:00:00", "0", "1", "2", "2", ""));
        result.Add(CreateTask("14", "7", "Obtain approvals to proceed (concept, timeline, budget)", "03/15/2021 08:00:00", "03/15/2021 12:00:00", "03/15/2021 08:00:00", "03/16/2021 12:00:00", "0", "1", "2", "1,2", ""));
        result.Add(CreateTask("15", "14", "Secure required resources", "03/15/2021 13:00:00", "03/18/2021 12:00:00", "03/18/2021 13:00:00", "03/25/2021 12:00:00", "0", "1", "2", "2", ""));
        return result;
    }

    static GanttTask CreateTask(string key, string parentkey, string title, string start, string end, string actualstart, string actualEnd, string percent, string type, string status, string resources, string description) {
        return new GanttTask {
            Key = key,
            ParentKey = parentkey,
            Title = title,
            StartDate = DateTime.Parse(start, System.Globalization.CultureInfo.InvariantCulture),
            EndDate = DateTime.Parse(end, System.Globalization.CultureInfo.InvariantCulture),
            ActualStartDate = DateTime.Parse(actualstart, System.Globalization.CultureInfo.InvariantCulture),
            ActualEndDate = DateTime.Parse(actualEnd, System.Globalization.CultureInfo.InvariantCulture),
            Progress = Convert.ToInt32(percent),
            Resources = resources,
            Description = description
        };
    }

    static List<Dependency> CreateDependencies() {
        var result = new List<Dependency>();
        for (int i = 0; i < Tasks.Count; i++) {
            var task = Tasks[i];
            if (!string.IsNullOrEmpty(task.ParentKey) && task.ParentKey != "-1") {
                result.Add(new Dependency { Key = Guid.NewGuid().ToString(), PredecessorKey = Tasks[i - 1].Key, SuccessorKey = task.Key });
            }
        }
        return result;
    }

    static List<Resource> CreateResources() {
        return [
            new Resource { Key = "1", Name = "Management" },
            new Resource { Key = "2", Name = "Project Manager" },
            new Resource { Key = "3", Name = "Analyst" },
            new Resource { Key = "4", Name = "Developer" },
            new Resource { Key = "5", Name = "Testers" },
            new Resource { Key = "6", Name = "Trainers" },
            new Resource { Key = "7", Name = "Technical Communicators" },
            new Resource { Key = "8", Name = "Deployment Team" }
        ];
    }

    static List<ResourceAssignment> CreateResourceAssignments() {
        var result = new List<ResourceAssignment>();
        foreach (var task in Tasks) {
            if (!string.IsNullOrEmpty(task.Resources)) {
                var resourceIds = task.Resources.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var id in resourceIds)
                    result.Add(new ResourceAssignment { Key = Guid.NewGuid().ToString(), TaskKey = task.Key, ResourceKey = id });
            }
        }
        return result;
    }
}

public class GanttTask {
    public string Key { get; set; }
    public string ParentKey { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime ActualStartDate { get; set; }
    public DateTime ActualEndDate { get; set; }
    public int Progress { get; set; }
    public string Resources { get; set; }
}

public class Dependency {
    public string Key { get; set; }
    public string PredecessorKey { get; set; }
    public string SuccessorKey { get; set; }
}

public class Resource {
    public string Key { get; set; }
    public string Name { get; set; }
}

public class ResourceAssignment {
    public string Key { get; set; }
    public string TaskKey { get; set; }
    public string ResourceKey { get; set; }
}
