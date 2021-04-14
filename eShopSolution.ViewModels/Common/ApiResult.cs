using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Common
{
    public class ApiResult<T>
    {
        //public ApiResult(bool isSuccessed, string message)
        //{
        //    IsSuccessed = isSuccessed;
        //    Message = message;
        //}

        //public ApiResult(bool isSuccessed, string message, T resultObj)
        //{
        //    IsSuccessed = isSuccessed;
        //    Message = message;
        //}
        public bool IsSuccessed { set; get; }

        public string Message  { get; set; }

        public T ResultObj { get; set; }
    }
}
