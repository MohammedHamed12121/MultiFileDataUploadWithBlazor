using Microsoft.AspNetCore.Components.Forms;
using MultiFileDataExtractionBlazorApp.Data;

namespace MultiFileDataExtractionBlazorApp.Helpers
{
	public class CsvFileImporter : IFileImporter
	{
		public List<Employee> Import(string _fileName)
		{
			var employees = new List<Employee>();
			var lines = File.ReadAllLines(_fileName).Skip(1);

			foreach (var line in lines)
			{
				var columns = line.Split(',');
				var employee = new Employee
				{
					Id = int.Parse(columns[0]),
					Name = columns[1],
					Designation = columns[2],
					DOJ = DateOnly.Parse(columns[3]),
					IsActive = bool.Parse(columns[4])
				};
				employees.Add(employee);
			}

			return employees;
		}
	}
}
