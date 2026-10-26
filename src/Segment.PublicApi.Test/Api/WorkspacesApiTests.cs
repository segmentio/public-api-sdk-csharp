using System;
using Xunit;
using Segment.PublicApi.Api;
using Moq;
using Segment.PublicApi.Model;

namespace Segment.PublicApi.Test.Api
{
    public class WorkspacesApiTests : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test GetWorkspace
        /// </summary>
        [Fact]
        public void GetWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value

            // Arrange
            var mockApi = new Mock<IWorkspacesApi>();
            
            var expectedResponse = new GetWorkspace200Response(
                 new GetWorkspaceV1Output(
                    new WorkspaceV1(
                        "123",
                        "Public API C# Workspace",
                        "Test"
                    )
                 )
            );
            mockApi.Setup(x => x.GetWorkspace(0)).Returns(expectedResponse);
            var instance = mockApi.Object;

            // Act
            var response = instance.GetWorkspace(0);

            // Assert
            Assert.IsType<GetWorkspace200Response>(response);
            Assert.Equal(expectedResponse, response);
        }
    }
}
