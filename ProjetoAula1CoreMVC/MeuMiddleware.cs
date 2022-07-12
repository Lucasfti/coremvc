using System;

public class MeuMiddleware
{
	private readonly RequestDelegate _next;

	public MeuMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync (HttpContext context)
    {

    }
}
