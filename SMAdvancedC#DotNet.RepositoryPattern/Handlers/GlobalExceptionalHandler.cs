using Microsoft.AspNetCore.Diagnostics;
using SMAdvancedC_DotNet.Utlis.Enums;
using SMAdvancedC_DotNet.Utlis;
using Newtonsoft.Json;

namespace SMAdvancedC_DotNet.RepositoryPattern.Handlers
{
    public class GlobalExceptionalHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            var result = Result<object>.Fail(exception);
            httpContext.Response.StatusCode = (int)EnumHttpStatusCode.Success;
            await httpContext.Response.WriteAsync(
                JsonConvert.SerializeObject(result),
                cancellationToken
            );
            return true;
        }
    }
}
