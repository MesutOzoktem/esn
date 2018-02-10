using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class OperationResult
    {

        public int Status { get; set; }
        public string Message { get; set; }
        public dynamic Data { get; set; }
        public static OperationResult GetSuccessResult(dynamic data)
        {
            OperationResult result = new OperationResult
            {
                Status = 1,
                Data = data
            };
            return result;
        }
        public static OperationResult GetFailResult(string message, int status = 0)
        {
            OperationResult result = new OperationResult
            {
                Status = status,
                Message = message
            };
            return result;
        }
    }
}
