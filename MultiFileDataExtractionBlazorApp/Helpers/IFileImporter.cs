using Microsoft.AspNetCore.Components.Forms;
using MultiFileDataExtractionBlazorApp.Data;
namespace MultiFileDataExtractionBlazorApp.Helpers
{
	public interface IFileImporter
	{
		public List<Employee> Import(string _fileName);
	}
}
