using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components.Forms;
using MultiFileDataExtractionBlazorApp.Data;

namespace MultiFileDataExtractionBlazorApp.Helpers
{
	public class ImportFileProcessor
	{
        public IFileImporter _importerService { get; set; }

		public ImportFileProcessor(IFileImporter importerService)
		{
			_importerService = importerService;
		}

		public List<Employee> ProcessImport(string _fileName)
		{
			return _importerService.Import(_fileName);
		}
	}
}
