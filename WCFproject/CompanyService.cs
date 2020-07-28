namespace WCFproject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CompanyService" in both code and config file together.
    public class CompanyService : ICompanyPublicService, ICompanyConfidentalService
    {
        public string GetConfidentalInformation()
        {
            return "This is confidental information and only available over TCP behind the company Firewall.";
        }

        public string GetPublicInformation()
        {
            return "This is public information and available over HTTP to all general public outside Firewall.";
        }
    }
}
