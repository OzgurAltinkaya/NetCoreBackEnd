using System;
namespace Core.Utilities.Results
{
    public class Result : IResult
    {
     

        public Result(bool success, string message):this(success) //this-kendisine success'i yolla! diğer parametreyi de çalıştır.
        {
            Message = message;
            
        }
        public Result(bool success)
        { 
            Success = success;
        }


        public bool Success { get; }

        public string Message { get; }
    }
}
