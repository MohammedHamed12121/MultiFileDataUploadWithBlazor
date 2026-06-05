namespace MultiFileDataExtractionBlazorApp.Data
{
	public class EmployeeService
	{
		private readonly List<Employee> _employees = new()
		{
			new Employee { Id = 107, Name = "Alice", Designation = "AI Engineer", DOJ = new DateOnly(1998, 11, 17), IsActive = true },
			new Employee { Id = 103, Name = "Bob", Designation = "Senior DevOps Engineer", DOJ = new DateOnly(1985, 1, 5), IsActive = true },
			new Employee { Id = 106, Name = "John", Designation = "Data Engineer", DOJ = new DateOnly(1995, 4, 17), IsActive = true },
			new Employee { Id = 104, Name = "Pop", Designation = "Associate Architect", DOJ = new DateOnly(1985, 6, 8), IsActive = false },
			new Employee { Id = 105, Name = "Ronald", Designation = "Senior Data Engineer", DOJ = new DateOnly(1991, 8, 23), IsActive = true }
		};

		public IReadOnlyList<Employee> GetEmployees()
		{
			return _employees.AsReadOnly();
		}

		public void AddEmployee(Employee employee)
		{
			_employees.Add(employee);
		}
		public void AddEmployee(List<Employee> employees)
		{
			_employees.AddRange(employees);
		}
	}
}
