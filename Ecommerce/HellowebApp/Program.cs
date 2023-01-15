using HR;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var emp = new Employee() Id=25, FirstName="Saurabh",LastName="Raut"};
var Employee = new List<Employee>();

Employee.Add( new Employee() {Id=21, FirstName="Saytam",LastName="Pande"});
Employee.Add( new Employee() {Id=22, FirstName="Bhushan" LastName="Shinde"});
Employee.Add(new Employee () {Id=23,FirstName="Rohit", LastName="Patil"});

 app.MapGet("/", () => "Hello world");
 app.MapGet("/api/hello",()=>"R Store");
 app.MapGet("/api/employees", ()=>Employee);
 app.MapGet("/api/employees",()=>emp);
 app.Run();
 