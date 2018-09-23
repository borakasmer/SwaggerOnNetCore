using System;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

public class TokenFilter : IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
        
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        string Token = context.HttpContext.Request.Headers["Authorization"];
        Console.Write($"Token Değeri : {Token}");
    }
}