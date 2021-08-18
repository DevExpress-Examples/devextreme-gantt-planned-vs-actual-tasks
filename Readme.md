# Gantt for Java Script - Planned vs actual tasks  
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/386356088/)**
<!-- run online end -->

This example demonstrates how to display both actual and planned tasks in the Gantt chart area.

The Gantt data source contains [four date fields](https://github.com/DevExpress-Examples/gantt-for-java-script-planned-vs-actual-tasks/blob/21.1.4+/CS/DevExtremeMvcApp1/Models/GanttDataProvider.cs#L140): two of them contain planned dates for a task and the other two are filled based on real dates of each task.

The [taskContentTemplate](https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxGantt/Configuration/#taskContentTemplate) property is used to display two visual elements for one task.

The main idea is to create two HTML div elements and add them to a task container. The first element represents [planned](https://github.com/DevExpress-Examples/gantt-for-java-script-planned-vs-actual-tasks/blob/21.1.4+/CS/DevExtremeMvcApp1/Views/Home/Index.cshtml#L75) tasks. It is created based on the taskSize parameter.

The second element is for an actual task. Its size and position are [calculated](https://github.com/DevExpress-Examples/gantt-for-java-script-planned-vs-actual-tasks/blob/21.1.4+/CS/DevExtremeMvcApp1/Views/Home/Index.cshtml#L105) based on task data.

See:
[Index.cshtml](https://github.com/DevExpress-Examples/gantt-for-java-script-planned-vs-actual-tasks/blob/21.1.4+/CS/DevExtremeMvcApp1/Views/Home/Index.cshtml)
[Layout.cshtml](https://github.com/DevExpress-Examples/gantt-for-java-script-planned-vs-actual-tasks/blob/21.1.4+/CS/DevExtremeMvcApp1/Views/Shared/_Layout.cshtml)
[GanttDataProvider.cs](https://github.com/DevExpress-Examples/gantt-for-java-script-planned-vs-actual-tasks/blob/21.1.4+/CS/DevExtremeMvcApp1/Models/GanttDataProvider.cs)

