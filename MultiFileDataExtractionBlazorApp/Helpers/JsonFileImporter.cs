using MultiFileDataExtractionBlazorApp.Data;

namespace MultiFileDataExtractionBlazorApp.Helpers
{
	public class JsonFileImporter : IFileImporter
	{
		public List<Employee> Import()
		{
			return new List<Employee>()
			{
				new Employee { Id = 60, Name = "Browany y FromJson", Designation = "AI Engineer", DOJ = new DateOnly(1993, 6, 20), IsActive = true }
			};
		}
	}
}
