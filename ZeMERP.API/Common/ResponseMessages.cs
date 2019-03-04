using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ZeMERP.DTO.Shared;

namespace Erp.Api.Common
{
    //public class ErrorModel
    //{
    //    public string ValidatorKey { get; private set; }
    //    public string Message { get; private set; }

    //    public ErrorModel(string message, string validatorKey = "")
    //    {
    //        ValidatorKey = validatorKey;
    //        Message = message;
    //    }
    //}
    public static class ResponseMessages
    {
        public static BaseResponseViewModel ModelValidate(ModelStateDictionary modelState)
        {
            var errorsToAdd = new List<ErrorViewModel>();
            foreach (var keyModelStatePair in modelState)
            {
                var key = keyModelStatePair.Key;
                var errors = keyModelStatePair.Value.Errors;
                if (errors != null && errors.Count > 0)
                {

                    foreach (var error in errors)
                    {
                        // split the message to get the validator key
                        var keyAndMessage = error.ErrorMessage.Split('|');

                        // if there's no validator key, just return the error message,
                        // otherwise add the validatorkey
                        if (keyAndMessage.Count() > 1)
                        {
                            errorsToAdd.Add(new ErrorViewModel(
                                keyAndMessage[1],
                                keyAndMessage[0]));
                        }
                        else
                        {
                            errorsToAdd.Add(new ErrorViewModel(
                                keyAndMessage[0], key));
                        }
                    }
                    //Add(key, errorsToAdd);
                }
            }

            return new BaseResponseViewModel()
            {
                HasErrors = "TRUE",
                ResultCode = "UnprocessableEntity",
                StatusCode = "422",
                Error = errorsToAdd.ToList(),
                HasWarnings = "NO",
                ReferenceNumber = "NO",
                Trace = ""
            };

        }
        public static BaseResponseViewModel NotFound()
        {
            return new BaseResponseViewModel()
            {
                HasErrors = "FALSE",
                ResultCode = "NotFound",
                StatusCode = "404",
                Error = null,
                HasWarnings = "NO",
                ReferenceNumber = "NO",
                Trace = ""
            };

        }

        public static BaseResponseViewModel BadRequest()
        {
            return new BaseResponseViewModel()
            {
                HasErrors = "TRUE",
                ResultCode = "BadRequest",
                StatusCode = "400",
                Error = null,
                HasWarnings = "NO",
                ReferenceNumber = "NO",
                Trace = ""
            };
        }

        public static BaseResponseViewModel Custom(string errorMessage)
        {
            return new BaseResponseViewModel()
            {
                ResultDescription=errorMessage,
                HasErrors = "TRUE",
                ResultCode = "BadRequest",
                StatusCode = "400",
                Error = null,
                HasWarnings = "NO",
                ReferenceNumber = "NO",
                Trace = ""
            };
        }

        public static BaseResponseViewModel InternalServerError(string ex)
        {
            return new BaseResponseViewModel()
            {
                HasErrors = "TRUE",
                ResultCode = "InternalServerError",
                StatusCode = "500",
                ResultDescription = ex,
                Error = null,
                HasWarnings = "NO",
                ReferenceNumber = "NO",
                Trace = ""
            };
        }
        public static BaseResponseViewModel Success()
        {
            return new BaseResponseViewModel()
            {
                HasErrors = "FALSE",
                ResultCode = "SUCCESS",
                StatusCode = "200",
                Error = null,
                HasWarnings = "NO",
                ReferenceNumber = "NO",
                Trace = ""
            };
        }

        public static BaseResponseViewModel Created()
        {
            return new BaseResponseViewModel()
            {
                HasErrors = "FALSE",
                ResultCode = "Created",
                StatusCode = "201",
                Error = null,
                HasWarnings = "NO",
                ReferenceNumber = "NO",
                Trace = ""
            };
        }

    }
}
