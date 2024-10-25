using System.Collections.Specialized;

namespace EmployeeManagement.Helper
{
    public class ApiResponse
    {
        public int Code {  get; set; }  
        public string Message { get; set; }
        public string Result { get; set; }

        public String data { get; set; }
    }
}
