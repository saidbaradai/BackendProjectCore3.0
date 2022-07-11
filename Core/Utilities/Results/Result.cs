using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool IsSuccess { get; }

        public string Message { get; }

        public Result(bool isSuccess)
        {
            isSuccess = IsSuccess;
        }

        public Result(bool isSuccess, string message) : this(isSuccess)
        {
            Message = message;
        }
    }
}
