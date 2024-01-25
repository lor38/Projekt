using Auf7;

var employee = new Employee("Rafael", "Lorenc");
employee.AddGrade(5);
employee.AddGrade("Rafael");
employee.AddGrade(20);
employee.AddGrade(6);
var statistics = employee.GetStatistics();






Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");