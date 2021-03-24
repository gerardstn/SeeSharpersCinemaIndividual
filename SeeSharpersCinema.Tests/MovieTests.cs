using SeeSharpersCinema.Models.Film;
using Xunit;

namespace SeeSharpersCinema.Tests
{
    public class MovieTests
    {
        [Fact]
        public void CanChangeId()
        {
            // Arrange
            Movie m = new Movie { Id = 1 };

            // Act
            m.Id = 2;

            // Assert
            Assert.Equal(2, m.Id);
        }

        [Fact]
        public void TestTypeId()
        {
            // Arrange
            Movie m = new Movie { Id = 1 };

            // Assert
            Assert.True(m.Id.GetType() == typeof(long));
        }

        [Fact]
        public void CanChangeTitle()
        {
            // Arrange
            Movie m = new Movie { Title = "Test" };

            // Act
            m.Title = "NewName";

            // Assert
            Assert.Equal("NewName", m.Title);
        }

        [Fact]
        public void TestTypeTitle()
        {
            // Arrange
            Movie m = new Movie { Title = "Test" };

            // Assert
            Assert.True(m.Title.GetType() == typeof(string));
        }

        [Fact]
        public void CanChangePosterUrl()
        {
            // Arrange
            Movie m = new Movie { PosterUrl = "https://www.nos.nl" };

            // Act
            m.PosterUrl = "https://www.nu.nl";

            // Assert
            Assert.Equal("https://www.nu.nl", m.PosterUrl);
        }

        [Fact]
        public void TestTypePosterUrl()
        {
            // Arrange
            Movie m = new Movie { PosterUrl = "https://www.nos.nl" };

            // Assert
            Assert.True(m.PosterUrl.GetType() == typeof(string));
        }

        [Fact]
        public void CanChangeDuration()
        {
            // Arrange
            Movie m = new Movie { Duration = 120 };

            // Act
            m.Duration = 130;

            // Assert
            Assert.Equal(130, m.Duration);
        }

        [Fact]
        public void TestTypeDuration()
        {
            // Arrange
            Movie m = new Movie { Duration = 120 };

            // Assert
            Assert.True(m.Duration.GetType() == typeof(int));
        }

        [Fact]
        public void CanChangeLanguage()
        {
            // Arrange
            Movie m = new Movie { Language = "Original" };

            // Act
            m.Language = "Nederlands";

            // Assert
            Assert.Equal("Nederlands", m.Language);
        }

        [Fact]
        public void TestTypeLanguage()
        {
            // Arrange
            Movie m = new Movie { Language = "Original" };

            // Assert
            Assert.True(m.Language.GetType() == typeof(string));
        }

        [Fact]
        public void CanChangeTechnique()
        {
            // Arrange
            Movie m = new Movie { Technique = "2D" };

            // Act
            m.Technique = "3D";

            // Assert
            Assert.Equal("3D", m.Technique);
        }

        [Fact]
        public void TestTypeTechnique()
        {
            // Arrange
            Movie m = new Movie { Technique = "2D" };

            // Assert
            Assert.True(m.Technique.GetType() == typeof(string));
        }

        [Fact]
        public void CanChangeDescription()
        {
            // Arrange
            Movie m = new Movie { Description = "Lorem Ipsum" };

            // Act
            m.Description = "Ipsum Lorem";

            // Assert
            Assert.Equal("Ipsum Lorem", m.Description);
        }

        [Fact]
        public void TestTypeDescription()
        {
            // Arrange
            Movie m = new Movie { Description = "Lorem Ipsum" };

            // Assert
            Assert.True(m.Description.GetType() == typeof(string));
        }

        [Fact]
        public void CanChangeViewIndication()
        {
            // Arrange
            Movie m = new Movie { ViewIndication = ViewIndication.Fourteen };

            // Act
            m.ViewIndication = ViewIndication.Six;

            // Assert
            Assert.Equal(ViewIndication.Six, m.ViewIndication);
        }

        [Fact]
        public void TestTypeViewIndication()
        {
            // Arrange
            Movie m = new Movie { ViewIndication = ViewIndication.Fourteen };

            // Assert
            Assert.True(m.ViewIndication.GetType() == typeof(ViewIndication));
        }

        [Fact]
        public void CanChangeGenre()
        {
            // Arrange
            Movie m = new Movie { Genre = Genre.Action };

            // Act
            m.Genre = Genre.Animation;

            // Assert
            Assert.Equal(Genre.Animation, m.Genre);
        }

        [Fact]
        public void TestTypeGenre()
        {
            // Arrange
            Movie m = new Movie { Genre = Genre.Action };

            // Assert
            Assert.True(m.Genre.GetType() == typeof(Genre));
        }

        [Fact]
        public void CanChangeYear()
        {
            // Arrange
            Movie m = new Movie { Year = 2021 };

            // Act
            m.Year = 2020;

            // Assert
            Assert.Equal(2020, m.Year);
        }

        [Fact]
        public void TestTypeYear()
        {
            // Arrange
            Movie m = new Movie { Year = 2021 };

            // Assert
            Assert.True(m.Year.GetType() == typeof(int));
        }

        [Fact]
        public void CanChangeDirector()
        {
            // Arrange
            Movie m = new Movie { Director = "Stephen King" };

            // Act
            m.Director = "SeeSharpers";

            // Assert
            Assert.Equal("SeeSharpers", m.Director);
        }

        [Fact]
        public void TestTypeDirector()
        {
            // Arrange
            Movie m = new Movie { Director = "Stephen King" };

            // Act
            m.Director = "SeeSharpers";

            // Assert
            Assert.True(m.Director.GetType() == typeof(string));
        }

        [Fact]
        public void CanChangeCountry()
        {
            // Arrange
            Movie m = new Movie { Country = "United States" };

            // Act
            m.Country = "United Kingdom";

            // Assert
            Assert.Equal("United Kingdom", m.Country);
        }

        [Fact]
        public void TestTypeCountry()
        {
            // Arrange
            Movie m = new Movie { Country = "United States" };

            // Assert
            Assert.True(m.Country.GetType() == typeof(string));
        }

        [Fact]
        public void CanChangeIsLongMovie()
        {
            // Arrange
            Movie m = new Movie { Duration = 130 };

            // Assert
            Assert.True(m.IsLongMovie);
        }

        [Fact]
        public void TestTypeIsLongMovie()
        {
            // Arrange
            Movie m = new Movie { Duration = 130 };

            // Assert
            Assert.True(m.IsLongMovie.GetType() == typeof(bool));
        }

        [Fact]
        public void CanChangeIsGenreChild()
        {
            // Arrange
            Movie m = new Movie { Genre = Genre.Children };
            Movie m1 = new Movie { Genre = Genre.Animation };

            // Assert
            Assert.True(m.IsGenreChild);
            Assert.False(m1.IsGenreChild);
        }

        [Fact]
        public void TestTypeIsGenreChild()
        {
            // Arrange
            Movie m = new Movie { Genre = Genre.Children };

            // Assert
            Assert.True(m.IsGenreChild.GetType() == typeof(bool));
        }

        [Fact]
        public void CanChangeIsThreeDimensional()
        {
            // Arrange
            Movie m = new Movie { Technique = "3D" };
            Movie m1 = new Movie { Technique = "2D" };

            // Assert
            Assert.True(m.IsThreeDimensional);
            Assert.False(m1.IsThreeDimensional);
        }

        [Fact]
        public void TestTypeIsThreeDimensional()
        {
            // Arrange
            Movie m = new Movie { Technique = "3D" };

            // Assert
            Assert.True(m.IsThreeDimensional.GetType() == typeof(bool));
        }
    }
}
