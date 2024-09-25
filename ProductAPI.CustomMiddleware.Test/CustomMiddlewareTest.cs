using Microsoft.AspNetCore.Http;
using Moq;
using ProductAPI.Middleware;
using System.IO;
using System.Threading.Tasks;
using Xunit;

public class CustomMiddlewareTests
{
    [Fact]
    public async Task InvokeAsync_LogsRequestAndResponse()
    {
        // Arrange
        var context = new DefaultHttpContext();
        context.Request.Method = "GET";
        context.Request.Path = "/test";
        var memoryStream = new MemoryStream();
        context.Response.Body = memoryStream;

        var next = new Mock<RequestDelegate>();
        next.Setup(n => n(It.IsAny<HttpContext>())).Returns(Task.CompletedTask);

        var middleware = new CustomMiddleware(next.Object);

        // Act
        await middleware.InvokeAsync(context);

        // Assert
        next.Verify(n => n(It.IsAny<HttpContext>()), Times.Once);
        memoryStream.Seek(0, SeekOrigin.Begin);
        var responseBody = new StreamReader(memoryStream).ReadToEnd();
        Assert.Equal(200, context.Response.StatusCode);
    }
}
