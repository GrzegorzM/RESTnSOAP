namespace WCFproject
{
    public class DownloadService : IDownloadService
    {
        public File DownloadDocument()
        {
            File file = new File();
            file.Content = System.IO.File.ReadAllBytes(@"C:\RESTnSOAP\BHP_2.ppt");
            file.Name = "BHP_2.ppt";

            return file;
        }
    }
}