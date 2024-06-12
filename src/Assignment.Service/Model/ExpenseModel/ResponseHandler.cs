using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Assignment.Service.Model.ExpenseModel.ResponseHandler;

namespace Assignment.Service.Model.ExpenseModel
{
    public class Response<T>
    {

        public bool Success { get; set; }

        public string StatusCode { get; set; }

        public string Message { get; set; }

        public T Content { get; set; }
    }

    public class ResponseHandler
    {

        public static Response<T> HandleSuccess<T>()
        {
            Response<T> response = new Response<T>()
            {
                Success = true,
                StatusCode = HttpStatusCode.OK.ToString(),
            };
            return response;
        }

        public static Response<T> HandleSuccess<T>(string message)
        {
            Response<T> response = new Response<T>()
            {
                Success = true,
                StatusCode = HttpStatusCode.OK.ToString(),
                Message = message
            };
            return response;
        }

        public static Response<T> HandleSuccess<T>(string message, T content)
        {
            Response<T> response = new Response<T>()
            {
                Success = true,
                StatusCode = HttpStatusCode.OK.ToString(),
                Message = message,
                Content = content
            };
            return response;
        }
        public static Response<T> HandleError<T>(string statusCode, string message)
        {
            Response<T> response = new Response<T>()
            {
                Success = false,
                StatusCode = statusCode,
                Message = message
            };
            return response;
        }
    }
}
