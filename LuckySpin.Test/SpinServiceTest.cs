using System;
using Xunit;
using Moq;
using LuckySpin.Models;
using LuckySpin.Services;
using LuckySpin.Repositories;
using LuckySpin.Test.TestData;

namespace LuckySpin.Test
{
    public class SpinServiceTest
    {
        [Fact]
        public void SpinService_averageWins()
        {
            //Arrange - create your Mock elements; setup the for the test
            var mockRepo = new Mock<SpinRepository>();
            var service = new SpinService(mockRepo.Object);

            //Act - run the method that you are testing and get a result
            var result = service.averageWins();

            //Assert - check to see if the result is what was expected based on our setup
            Assert.Equal(4/10d, result);

        }
    }
}
