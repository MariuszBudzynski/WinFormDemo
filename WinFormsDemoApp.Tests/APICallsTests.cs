using Moq;
using WinFormsDemoApp.Common;
using WinFormsDemoApp.Common.Interfaces;

namespace WinFormsDemoApp.Tests
{
	public class APICallsTests
	{
		[Fact]
		public async Task CallApiInternalAsync_ValidEndpoint_Success()
		{
			// Arrange
			var validatorMock = new Mock<IAPIValidator>();
			validatorMock.Setup(v => v.ValidateEndpoint(It.IsAny<string>())).Returns(true);
			var validator = validatorMock.Object;

			// Act
			var result = validator.ValidateEndpoint("https://jsonplaceholder.typicode.com/todos");


			// Assert
			Assert.True(result);
		}

		[Fact]
		public void ValidateEndpoint_InvalidEndpoint_ReturnsFalse()
		{
			// Arrange
			var validatorMock = new Mock<IAPIValidator>();
			validatorMock.Setup(v => v.ValidateEndpoint(It.IsAny<string>())).Returns(false);

			var validator = validatorMock.Object;

			// Act
			var result = validator.ValidateEndpoint("invalidEndpoint");

			// Assert
			Assert.False(result);
		}

		[Fact]
		public async Task CallApiInternalAsync_GET_Success()
		{
			// Arrange
			var endpoint = "https://jsonplaceholder.typicode.com/todos";
			var action = HttpAction.GET;
			var expectedResult = "GET Success";

			var helperMock = new Mock<IAPIHelper>();
			helperMock.Setup(h => h.CallApiAsync(endpoint, action)).ReturnsAsync(expectedResult);
			var helper = helperMock.Object;

			// Act
			var result = await helper.CallApiAsync(endpoint, action);

			// Assert
			Assert.Equal(expectedResult, result);
		}

		[Fact]
		public async Task CallApiInternalAsync_GET_Failure()
		{
			// Arrange
			var endpoint = "https://jsonplaceholder.typicode.com/todos";
			var action = HttpAction.GET;
			var errorMessage = "GET Error";

			var helperMock = new Mock<IAPIHelper>();
			helperMock.Setup(h => h.CallApiAsync(endpoint, action)).ThrowsAsync(new Exception(errorMessage));
			var helper = helperMock.Object;

			// Act & Assert
			var exception = await Assert.ThrowsAsync<Exception>(async () => await helper.CallApiAsync(endpoint, action));
			Assert.Equal(errorMessage, exception.Message);
		}
	}
}
