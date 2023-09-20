using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace WebApiEF.Helper
{
    public class TestActionFilterAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("Pasa por OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("Pasa por OnActionExecuting");
        }
    }
}
