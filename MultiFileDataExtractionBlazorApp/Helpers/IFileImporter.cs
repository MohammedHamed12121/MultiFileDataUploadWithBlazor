using MultiFileDataExtractionBlazorApp.Data;
namespace MultiFileDataExtractionBlazorApp.Helpers
{
	public interface IFileImporter
	{
		public List<Employee> Import();
	}
}
