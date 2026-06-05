using System.Text.Json;
using Microsoft.AspNetCore.Components.Forms;
using MultiFileDataExtractionBlazorApp.Data;

namespace MultiFileDataExtractionBlazorApp.Helpers
{
	public class JsonFileImporter : IFileImporter
	{
		public List<Employee> Import(string _fileName)
		{
			var employees = new List<Employee>();

			string jsonContent = File.ReadAllText(_fileName);
			if(jsonContent.Length == 0)
				return employees;

			employees = JsonSerializer.Deserialize<List<Employee>>(jsonContent);
			return employees;
		}
	}
}
