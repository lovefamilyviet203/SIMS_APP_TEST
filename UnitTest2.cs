using AssignmentApp.Data;
using AssignmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using Xunit;

namespace TestForTest
{
    public class UnitTest1 : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _applicationFactory;

        public UnitTest1()
        {
            var app = new WebApplicationFactory<Program>();
            _applicationFactory = app;
        }

        [Fact]
        public async void TestCourseIndex()
        {
            // Arrange
            var client = _applicationFactory.CreateClient();

            // Act
            var response = await client.GetAsync("/Courses/Index");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async void TestStudentIndex()
        {
            // Arrange
            var client = _applicationFactory.CreateClient();

            // Act
            var response = await client.GetAsync("/Student/Index");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async void TestInstructorsIndex()
        {
            // Arrange
            var client = _applicationFactory.CreateClient();

            // Act
            var response = await client.GetAsync("/Instructors/Index");

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task Details_ReturnsViewResult_WithValidId()
        {
            // Arrange
            var validId = 1;
            var client = _applicationFactory.CreateClient();

            // Act
            var response = await client.GetAsync($"/Courses/Details/{validId}");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Details_ReturnsViewResult_WithInvalidId()
        {
            // Arrange
            var invalidId = 99;
            var client = _applicationFactory.CreateClient();

            // Act
            var response = await client.GetAsync($"/Courses/Details/{invalidId}");

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task Edit_ReturnsViewResult_WithValidId()
        {
            // Arrange
            var validId = 1;
            var client = _applicationFactory.CreateClient();

            // Act
            var response = await client.GetAsync($"/Courses/Edit/{validId}");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Edit_ReturnsNotFound_WithInvalidId()
        {
            // Arrange
            var invalidId = 99;
            var client = _applicationFactory.CreateClient();

            // Act
            var response = await client.GetAsync($"/Courses/Edit/{invalidId}");

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}