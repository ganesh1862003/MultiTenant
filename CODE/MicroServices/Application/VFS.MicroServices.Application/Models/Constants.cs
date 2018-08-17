namespace VFS.MicroServices.Application.Models
{
    public class Message
    {
        public static readonly string[] arrDEColumnName = new[] { "APPLICATION ID(AID)", "MISSION REFERENCE NO.(MRN)", "PASSPORT NO.", "APPLICANT NAME", "APPLICATION STATUS", "ACTION" };
        public const string ServiceConfigureError = "Service Configure Error";
        public const string ResponseJsonContentTypes = "application/json";
        public const string ResponseTextPlainContentTypes = "text/plain";
        public const string DEUpdateSuccess = "Data entry for {ApplicantName} ({AID}) completed";
    }

    public class Error
    {
        public const string RequestProcess = "Error while processing request";
        public const string UnauthorizedAccess = "Unauthorized access";
        public const string BadRequest = "Bad request";
        public const string NotImplemented = "Not implemented";
        public const string NotFound = "Resource not found";
    }
}
