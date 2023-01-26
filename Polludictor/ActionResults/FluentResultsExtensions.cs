using Microsoft.AspNetCore.Mvc;

namespace Polludictor.API.ActionResults
{
    public static class FluentResultsExtensions
    {
        public static ActionResult ToActionResult<T>(this FluentResults.Result<T> result)
        {

            if (result.IsSuccess)
                return new OkObjectResult(result.Value);

//            if (result.HasError<ValidationError>())
//                return new BadRequestObjectResult(result.ToProblemDetails(StatusCodes.Status400BadRequest));

//            if (result.HasError<NotFoundError>())
//                return new NotFoundObjectResult(result.ToProblemDetails(StatusCodes.Status404NotFound));

//            if (result.HasError<UnauthorizedError>())
//                return new UnauthorizedObjectResult(result.ToProblemDetails(StatusCodes.Status401Unauthorized));

//            if (result.HasError<ExceptionalError>())
//            {
//#if DEBUG
//                throw (result.Errors[0] as ExceptionalError)!.Exception;
//#else
//                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
//#endif
//            }

            throw new NotImplementedException();
        }

//        public static ActionResult ToAttachmentContentResult<T>(this FluentResults.Result<T> result) where T : FileContent
//        {
//            if (result.IsSuccess)
//            {
//                return new AttachmentContentResult(result.Value.FileContents, result.Value.ContentType)
//                {
//                    FileDownloadName = result.Value.FileName,
//                };
//            }

//            if (result.HasError<ValidationError>())
//                return new BadRequestObjectResult(result.ToProblemDetails(StatusCodes.Status400BadRequest));

//            if (result.HasError<NotFoundError>())
//                return new NotFoundObjectResult(result.ToProblemDetails(StatusCodes.Status404NotFound));

//            if (result.HasError<UnauthorizedError>())
//                return new UnauthorizedObjectResult(result.ToProblemDetails(StatusCodes.Status401Unauthorized));

//            if (result.HasError<ExceptionalError>())
//            {
//#if DEBUG
//                throw (result.Errors[0] as ExceptionalError)!.Exception;
//#else
//                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
//#endif
//            }

//            throw new NotImplementedException();
//        }

        //private static ProblemDetails ToProblemDetails<T>(this FluentResults.Result<T> result, int statusCode)
        //{
        //    var problemDetails = new ProblemDetails
        //    {
        //        Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
        //        Title = "One or more validation errors occurred.",
        //        Status = statusCode
        //    };
        //    problemDetails.Extensions["errors"] = TransformErrors(result.Errors);
        //    return problemDetails;
        //}

    //    private static Dictionary<string, List<string>> TransformErrors(List<FluentResults.IError> errors)
    //    {
    //        var idsConverter = (IdsConverter)Program.Host?.Services.GetService(typeof(IdsConverter))!;

    //        var result = new Dictionary<string, List<string>>();
    //        foreach (var error in errors)
    //        {
    //            var message = error.Message;
    //            var objectName = "_";
    //            if (error.Metadata.TryGetValue("ObjectName", out object? objName))
    //                objectName = (string)objName;

    //            if (error is NotFoundError)
    //            {
    //                if (error.Metadata.TryGetValue("ObjectId", out object? objId))
    //                {
    //                    string objIdStr = objId switch
    //                    {
    //                        int intval => idsConverter?.EncodeInt(intval) ?? "NOT ENCODED",
    //                        long longval => idsConverter?.EncodeLong(longval) ?? "NOT ENCODED",
    //                        string stringVal => stringVal,
    //                        _ => (string)objId,
    //                    };
    //                    message += $" ('{objIdStr}')";
    //                }
    //            }

    //            if (!result.ContainsKey(objectName))
    //                result[objectName] = new List<string>();

    //            result[objectName].Add(message);
    //        }
    //        return result;
    //    }
    //}
}
}
