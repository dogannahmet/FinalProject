using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // this => class'ın kendisi demek(result)
        // :this(success) => result'un tek parametreli constructor'ına success gönder.(yani iki constructor'da çalışır.)
        public Result(bool success, string message) : this(success)
        {
            //get => readonly..
            //readonly yapılar, constructor'da set edilebilir...
            
          //Success = success;    //Don't repeat yourself..
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
