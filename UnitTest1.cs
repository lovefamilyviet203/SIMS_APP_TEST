/*using AssignmentApp.Data;
using AssignmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Net;
using System.Text;
namespace TestForTest
{
    public class UnitTest1 :IClassFixture<WebApplicationFactory<Program>>
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
            //Arrange
            var clien = _applicationFactory.CreateClient();
            var response = await clien.GetAsync("/Courses/Index");
            //Act
            int code = (int) response.StatusCode;
            //Assert
            Assert.Equal(200, code);
        }
        [Fact]
        public async void TestStudentIndex()
        {
            //Arrange
            var clien = _applicationFactory.CreateClient();
            var response = await clien.GetAsync("/Student/Index");
            //Act
            int code = (int)response.StatusCode;
            //Assert
            Assert.Equal(200, code);
        }
        [Fact]
        public async void TestInstructorsIndex()
        {
            //Arrange
            var clien = _applicationFactory.CreateClient();
            var response = await clien.GetAsync("/Instructors/Index");
            //Act
            int code = (int)response.StatusCode;
            //Assert
            Assert.Equal(404, code);
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
            int code = (int) response.StatusCode;  
            Assert.Equal(200, code);
        }
        [Fact]  
        public async Task Details_ReturnsViewResult_WithInValidId()
        {
            // Arrange
            var validId = 99;
            var client = _applicationFactory.CreateClient();

            // Act
            var response = await client.GetAsync($"/Courses/Details/{validId}");
            // Assert
            int code = (int)response.StatusCode;
            Assert.Equal(404, code);
        }
        //[Fact]
        //public async Task Create_ReturnsViewResult_WithValidCourse()
        //{
        //    // Arrange
        //    var course = new Course
        //    {
        //        Name = "English",
        //        StartTime = new DateTime(2022, 1, 1),
        //        EndTime = new DateTime(2022, 2, 1)
        //    };

        //    var content = new StringContent(JsonConvert.SerializeObject(course), Encoding.UTF8, "application/json");
        //    var client = _applicationFactory.CreateClient();

        //    // Act
        //    var response = await client.PostAsync("/Courses/Create", content);

        //    // Assert
        //    int code = (int)response.StatusCode;
        //    Assert.Equal(400, code);

        //    // You can further assert the view model or other aspects of the view result
        //}
        //[Fact]
        //public async Task Create_ReturnsViewResult_ForGet()
        //{
        //    // Arrange
        //    var client = _applicationFactory.CreateClient();

        //    // Act
        //    var response = await client.GetAsync("/Student/Create");

        //    // Assert
        //    response.EnsureSuccessStatusCode();
        //    Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        //}

        //[Fact]
        //public async Task Create_RedirectsToIndex_OnSuccessfulPost()
        //{
        //    // Arrange
        //    var client = _applicationFactory.CreateClient();
        //    var student = new StudentEntity
        //    {
        //        Name = "John Doe",
        //        Age = 25,
        //        Majo = "Computer Science"
        //    };

        //    // Act
        //    var response = await client.PostAsJsonAsync("/Student/Create", student);

        //    // Assert
        //    int code = (int)response.StatusCode;
        //    Assert.Equal(200, code);

        //}
        //[Fact]
        //public async Task DetailsStudent_ReturnsViewResult_WithValidId()
        //{
        //    // Arrange
        //    var validId = 1;
        //    var client = _applicationFactory.CreateClient();


        //    // Act
        //    var response = await client.GetAsync($"/Student/Details/{validId}");

        //    // Assert
        //    response.EnsureSuccessStatusCode();
        //    Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        //}
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
}*/