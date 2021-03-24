﻿using SeeSharpersCinema.Models.Program;
using Xunit;

namespace SeeSharpersCinema.Tests
{
    public class PlayListTests
    {
        [Fact]
        public void CanChangeId()
        {
            // Arrange
            PlayList p = new PlayList { Id = 1 };

            // Act
            p.Id = 2;

            // Assert
            Assert.Equal(2, p.Id);
        }

        [Fact]
        public void CanChangeTimeSlotId()
        {
            // Arrange
            PlayList p = new PlayList { TimeSlotId = 1 };

            // Act
            p.Id = 2;

            // Assert
            Assert.Equal(2, p.Id);
        }

        [Fact]
        public void CanChangeMovieId()
        {
            // Arrange
            PlayList p = new PlayList { TimeSlotId = 1 };

            // Act
            p.Id = 2;

            // Assert
            Assert.Equal(2, p.Id);
        }

        [Fact]
        public void TestTypeId()
        {
            // Arrange
            PlayList p = new PlayList { Id = 1 };

            // Assert
            Assert.True(p.Id.GetType() == typeof(long));
        }

        [Fact]
        public void TestTypeTimeSlotId()
        {
            // Arrange
            PlayList p = new PlayList { TimeSlotId = 1 };

            // Assert
            Assert.True(p.TimeSlotId.GetType() == typeof(long));
        }

        [Fact]
        public void TestTypeMovieId()
        {
            // Arrange
            PlayList p = new PlayList { MovieId = 1 };

            // Assert
            Assert.True(p.MovieId.GetType() == typeof(long));
        }


    }
}
