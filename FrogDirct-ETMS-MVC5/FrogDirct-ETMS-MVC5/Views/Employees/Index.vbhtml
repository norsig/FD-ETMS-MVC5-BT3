﻿@ModelType IEnumerable(Of Employees)

<div class="col-xs-9">
    <h3><span class="glyphicon glyphicon-dashboard"></span> EmployeeTraining Dashboard</h3>
</div>
<div class="col-xs-3 ">
    <span class="hidden-xs">  <br /><b> @Html.ActionLink("Create a new assignment", "Create", "Employees", New With {.class = "btn btn-primary pull-right "})</b></span> 
    <span class="visible-xs">  <br /><b> @Html.ActionLink("Create New", "Create", "Employees", New With {.class = "btn btn-sm btn-primary "})</b></span> 
</div>


<div class="table-responsive">
    @code
        Dim i As Integer = 1
        ViewBag.Number = i
    End Code
  
    
    <table class="table table-condensed  table-responsive" >
   
        @For Each item In Model
            Dim itemValue = item
            @<tr>

                <td> 
                    @Html.Partial("_Employee", item)

                   
                    <div class="clearfix"></div> 
                </td>

            </tr>

            i = i + 1
            ViewBag.Number = i
        Next

    </table>

</div>