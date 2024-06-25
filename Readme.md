<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/386356088/21.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1014715)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Gantt for DevExtreme - Planned vs actual tasks  

This example demonstrates how to display both actual and planned tasks in the Gantt chart area.

![Gantt planned and actual tasks](/gantt-planned-vs-actual-tasks.png)

The Gantt data source contains [four date fields](./CS/DevExtremeMvcApp1/Models/GanttDataProvider.cs#L140): two of them contain planned dates for a task and the other two are filled based on real dates of each task.

The [taskContentTemplate](https://js.devexpress.com/jQuery/Documentation/ApiReference/UI_Components/dxGantt/Configuration/#taskContentTemplate) property is used to display two visual elements for one task.

The main idea is to create two HTML div elements and add them to a task container. The first element represents [planned](./CS/DevExtremeMvcApp1/Views/Home/Index.cshtml#L75) tasks. It is created based on the taskSize parameter.

The second element is for an actual task. Its size and position are [calculated](./CS/DevExtremeMvcApp1/Views/Home/Index.cshtml#L105) based on task data. Appearance of actual tasks is defined by the [actual-task](./CS/DevExtremeMvcApp1/Views/Shared/_Layout.cshtml#L25) class. 

## Files to Review

- **NetCore**    
    - [Index.cshtml](./CS/DevExtremeMvcApp1/Views/Home/Index.cshtml)
    - [Layout.cshtml](./CS/DevExtremeMvcApp1/Views/Shared/_Layout.cshtml)
    - [GanttDataProvider.cs](./CS/DevExtremeMvcApp1/Models/GanttDataProvider.cs)

## Documentation

- [Getting Started with Gantt](https://js.devexpress.com/Documentation/Guide/UI_Components/Gantt/Getting_Started_with_Gantt/)
- [taskContentTemplate](https://js.devexpress.com/jQuery/Documentation/ApiReference/UI_Components/dxGantt/Configuration/#taskContentTemplate)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=devextreme-gantt-planned-vs-actual-tasks&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=devextreme-gantt-planned-vs-actual-tasks&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
