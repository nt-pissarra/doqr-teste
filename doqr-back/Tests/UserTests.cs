using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dtos;
using Application.Services;
using Domain.Models;
using Domain.Models.Enums;
using Infrastructure.Interfaces;
using Moq;
using Xunit;

namespace Application.Tests
{
    public class UserServiceTests
    {
        private readonly Mock<IUserRepository> _userRepositoryMock;
        private readonly UserService _userService;

        public UserServiceTests()
        {
            _userRepositoryMock = new Mock<IUserRepository>();
            _userService = new UserService(_userRepositoryMock.Object);
        }

        [Fact]
        public async Task GetAllUsersAsync_ReturnsListOfUserDtos()
        {
            // Arrange
            var users = new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john@example.com" },
                new User { Id = 2, Name = "Jane Smith", Email = "jane@example.com" }
            };

            _userRepositoryMock.Setup(repo => repo.GetAllUsersAsync()).ReturnsAsync(users);

            // Act
            var result = await _userService.GetAllUsersAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("John Doe", result[0].Name);
            Assert.Equal("Jane Smith", result[1].Name);
        }

        [Fact]
        public async Task GetUsersByNameAsync_ReturnsFilteredUserDtos()
        {
            // Arrange
            var users = new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john@example.com" }
            };

            _userRepositoryMock.Setup(repo => repo.GetUsersByNameAsync("John")).ReturnsAsync(users);

            // Act
            var result = await _userService.GetUsersByNameAsync("John");

            // Assert
            Assert.Single(result);
            Assert.Equal("John Doe", result[0].Name);
        }

        [Fact]
        public async Task GetUserAsync_ReturnsUserDto_WhenUserExists()
        {
            // Arrange
            var user = new User { Id = 1, Name = "John Doe", Email = "john@example.com" };

            _userRepositoryMock.Setup(repo => repo.GetUserAsync(1)).ReturnsAsync(user);

            // Act
            var result = await _userService.GetUserAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("John Doe", result.Name);
        }

        [Fact]
        public async Task GetUserAsync_ReturnsNull_WhenUserDoesNotExist()
        {
            // Arrange
            _userRepositoryMock.Setup(repo => repo.GetUserAsync(1)).ReturnsAsync((User)null);

            // Act
            var result = await _userService.GetUserAsync(1);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task CreateUserAsync_CreatesAndReturnsUserDto()
        {
            // Arrange
            var createUserDto = new CreateUserDto
            {
                Name = "John Doe",
                Email = "john@example.com",
                CPF = "12345678901",
                Phone = "1234567890",
                BirthDate = new DateTime(1990, 1, 1),
                EmploymentType = EmploymentType.CLT,
                Status = Status.Inativo
            };

            var createdUser = new User
            {
                Id = 1,
                Name = "John Doe",
                Email = "john@example.com",
                CPF = "12345678901",
                Phone = "1234567890",
                BirthDate = new DateTime(1990, 1, 1),
                EmploymentType = EmploymentType.CLT,
                Status = Status.Inativo
            };

            _userRepositoryMock.Setup(repo => repo.CreateUserAsync(It.IsAny<User>())).ReturnsAsync(createdUser);

            // Act
            var result = await _userService.CreateUserAsync(createUserDto);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("John Doe", result.Name);
        }

        [Fact]
        public async Task UpdateUserAsync_ReturnsNull_WhenUserDoesNotExist()
        {
            // Arrange
            _userRepositoryMock.Setup(repo => repo.GetUserAsync(1)).ReturnsAsync((User)null);

            // Act
            var result = await _userService.UpdateUserAsync(1, new UpdateUserDto());

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task DeleteUserAsync_ReturnsFalse_WhenUserDoesNotExist()
        {
            // Arrange
            _userRepositoryMock.Setup(repo => repo.GetUserAsync(1)).ReturnsAsync((User)null);

            // Act
            var result = await _userService.DeleteUserAsync(1);

            // Assert
            Assert.False(result);
        }
    }
}
