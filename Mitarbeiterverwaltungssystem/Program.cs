using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Mitarbeiterverwaltungssystem;
using Mitarbeiterverwaltungssystem.Modals;
using System;
using System.Net.Http;
using System.Collections.Generic;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<EmployeeState>();

var host = builder.Build();

// Beispiel-Daten hinzufügen
var employeeState = host.Services.GetRequiredService<EmployeeState>();

employeeState.AddEmployee(new Employee(1, "Alice Johnson", "Developer"));
employeeState.AddEmployee(new Employee(2, "Bob Smith", "Designer"));
employeeState.AddEmployee(new Employee(3, "Carol White", "Tester"));
employeeState.AddEmployee(new Employee(4, "David Brown", "Developer"));
employeeState.AddEmployee(new Employee(5, "Eve Black", "Support"));

employeeState.AddEmployee(new Manager(6, "Habibi", "Managercap", "IT"));
employeeState.AddEmployee(new Manager(7, "Grace Pink", "Manager", "HR"));
employeeState.AddEmployee(new Manager(8, "Hank Blue", "Manager", "Marketing"));
employeeState.AddEmployee(new Manager(9, "Ivy Orange", "Manager", "Sales"));
employeeState.AddEmployee(new Manager(10, "Jack Red", "Manager", "Finance"));

await host.RunAsync();
