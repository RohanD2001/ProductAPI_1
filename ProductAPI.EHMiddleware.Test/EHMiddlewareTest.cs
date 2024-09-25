using Microsoft.AspNetCore.Http;
using Moq;
using Newtonsoft.Json;
using ProductAPI.Middleware;
public class ExceptionHandlingMiddlewareTests
{
    [Fact]
    public async Task InvokeAsync_CatchesExceptionAndReturnsInternalServerError()
    {
        // Arrange
        var context = new DefaultHttpContext();
        context.Response.Body = new MemoryStream();
        var next = new Mock<RequestDelegate>();
        next.Setup(n => n(It.IsAny<HttpContext>())).Throws(new Exception("Test exception"));

        var middleware = new ExceptionHandlingMiddleware(next.Object);

        // Act
        await middleware.InvokeAsync(context);

        // Assert
        Assert.Equal(500, context.Response.StatusCode);
        context.Response.Body.Seek(0, SeekOrigin.Begin);
        var responseBody = new StreamReader(context.Response.Body).ReadToEnd();
        var responseJson = JsonConvert.DeserializeObject<dynamic>(responseBody);
        Assert.Contains("Test exception", (string)responseJson.message);
    }
}
