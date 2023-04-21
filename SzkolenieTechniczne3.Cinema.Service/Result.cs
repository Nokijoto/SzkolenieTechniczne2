﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne3.Cinema.Service
{
    public class Result
    {
        private Result(bool isSuccess,string message,IEnumerable<Error> errors)
        {
            IsSuccess = isSuccess;
            isFailure = !isSuccess;
            Message = message;
            Errors = errors;
        }
        
        public string Message { get; }
        public bool isFailure { get; }
        public bool isSuccess { get; }
        public IEnumerable<Error> Errors { get; }
        public static Result Fail(string message)
          => new Result(false, message, Enumerable.Empty<Error>());
        public static Result Ok()
            => new Result(true, "", Enumerable.Empty<Error>());
    }

    public class Error
    {
        public Error(string propertyName, string message)
        {
            PropertyName = propertyName;
            Message = message;
        }

        public string PropertyName { get; }
        public string Message { get; }
    }
}
