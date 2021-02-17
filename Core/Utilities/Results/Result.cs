using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        //geter read only'dir.Read onlyler constracterda set edilebilir.
        public Result(bool success, string message):this(success)
        {
            Message = message;
           
        }
        //overloading
        public Result(bool success)
        {
            
            Success = success;
        }


        public bool Success { get; }

        public string Message { get; }
    }
}
