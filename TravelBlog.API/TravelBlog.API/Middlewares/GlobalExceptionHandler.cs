using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace TravelBlog.API_.Middlewares
{
    public class GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger) : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
        {
            // 1. Log lỗi vào hệ thống để lập trình viên kiểm tra
            logger.LogError(exception, "Một lỗi không mong muốn đã xảy ra: {Message}",
            exception.Message);

            // 2. Chuẩn bị phản hồi trả về cho Client (theo chuẩn RFC 7807)
            var problemDetails = new ProblemDetails
            {
                Status = (int)HttpStatusCode.InternalServerError,
                Title = "Lỗi máy chủ",
                Detail = "Đã có lỗi xảy ra trong quá trình xử lý. Vui lòng thử lại sau hoặc liên hệ quản trịviên."
            };
            // 3. Thiết lập mã trạng thái HTTP
            httpContext.Response.StatusCode = problemDetails.Status.Value;

            // 4. Trả về JSON lỗi cho người dùng
            await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);

            return true; // Trả về true để báo rằng lỗi đã được xử lý
        }
    }
}
