using System.Runtime.CompilerServices;
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

		public List<Employee> ProcessImport()
		{
			return _importerService.Import();
		}
	}
}
