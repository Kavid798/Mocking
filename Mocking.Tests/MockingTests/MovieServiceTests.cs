using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mocking.Mocking;
using Moq;
using NUnit.Framework;
namespace Mocking.Tests.MockingTests
{
  [TestFixture]
    class MovieServiceTests
    {
        [Test]
        public void ReadView_IfVideoIsNull_ReturnErrorMessageWithMoq()
        {
            //Arrange
            var mockMovieService = new Mock<IFileReader>();
            var movieService = new MovieService();

            //Act
            mockMovieService.Setup(f => f.ReadFile(It.IsAny<string>())).Returns("");
            string expected = movieService.ReadVideoTitle(mockMovieService.Object);
            //Assert
            Assert.That(expected, Does.Contain("error").IgnoreCase);
        }
        [Test]
        public void ReadView_IfVideoIsNotNull_ReturnVideoTitleWithMoq()
        {
            //Arrange
            var mockMovieService = new Mock<IFileReader>();
            var movieService = new MovieService();

            //Act
            mockMovieService.Setup(f => f.ReadFile(It.IsAny<string>())).Returns("{\"Title\":\"Young Sheldon\"}\n");
            string expected = movieService.ReadVideoTitle(mockMovieService.Object);
            //Assert
            Assert.That(expected, Does.Contain("Young Sheldon").IgnoreCase);
        }
    }
}
