using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace RequestResponseEditingMiddleware.Middlewares
{
     public class RequestEditingMiddleware
    {
        private RequestDelegate _requestDelegate;
        public RequestEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            //ysk.com.tr/yavuz
            if (context.Request.Path.ToString() == "/yavuz")
            /*await _requestDelegate.Invoke(context);*/  // istek middleware e geldi bu isteği sonraki middleware e gönderen yapı invoke.
            context.Response.WriteAsync("Hosgeldin yavuz");
            else
            {
                await _requestDelegate.Invoke(context);
            }
        }
    }
}
