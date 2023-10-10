// See https://aka.ms/new-console-template for more information
using ClassLibrary1;
using System.Collections.Generic;



var job1 = new JobTitle
{
    JobName = "JobName 1",
    Duration = "10h"
};
var job2 = new JobTitle
{
    JobName = "JobName 2",
    Duration = "8h"
};
var job3 = new JobTitle
{
    JobName = "JobName 3",
    Duration = "4h"

};
var job4 = new JobTitle
{
    JobName = "JobName 4",
    Duration = "8h"
};


var employee1 = new Employee
{
    Name = "Name 1",
    Surname = "Surname 1",
    JobTitles = new()
{
   job3,job4
}
};

var employee2 = new Employee
{
    Name = "Name 2",
    Surname = "Surname 2",
    JobTitles = new()
{
   job2,job1
}

};
List<Employee> employees = new List<Employee>();

employees.Add(employee1);
employees.Add(employee2);

for (int i = 0; i < employees.Count; i++)
{
    Console.WriteLine(employees[i]);
}

