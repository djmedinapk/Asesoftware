using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Errors
{
    public class CodeErrorResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public CodeErrorResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetMessageDefault(statusCode);
        }

        private string GetMessageDefault(int statusCode)
        {
            string statusMessage = "Request Error";
            if (statusCode == 400)
            {
                statusMessage = "Invalid Request";
            }
            if (statusCode == 401)
            {
                statusMessage = "insufficient permissions";
            }
            if (statusCode == 404)
            {
                statusMessage = "Resource not available";
            }
            if (statusCode == 500)
            {
                statusMessage = "Internal Server Error";
            }
            return statusMessage;
        }
    }
}
