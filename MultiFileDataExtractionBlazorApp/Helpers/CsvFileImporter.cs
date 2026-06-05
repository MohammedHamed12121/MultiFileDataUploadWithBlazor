using MultiFileDataExtractionBlazorApp.Data;

namespace MultiFileDataExtractionBlazorApp.Helpers
{
	public class CsvFileImporter : IFileImporter
	{
		public List<Employee> Import()
		{
			return new List<Employee>()
			{
				new Employee { Id = 50, Name = "Ashly H FromCSV", Designation = "AI Engineer", DOJ = new DateOnly(1993, 6, 20), IsActive = true }
			};
		}
	}
}
