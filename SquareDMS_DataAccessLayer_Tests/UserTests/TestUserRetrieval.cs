﻿using SquareDMS_DataAccessLayer;
using System.Linq;
using Xunit;

namespace SquareDMS_DataAccessLayer_Tests.UserTests
{
    [Collection("Sequential")]
    public class TestUserRetrieval : IClassFixture<TestFixture>
    {
        private readonly SquareDbMsSql _squareDbMsSql = new SquareDbMsSql(Globals.SqlConnectionstring);
        private readonly TestFixture _fixture;

        /// <param name="fixture">Class wide fixture</param>
        public TestUserRetrieval(TestFixture fixture)
        {
            _fixture = fixture;
        }

        /// <summary>
        /// Admin gets all users.
        /// </summary>
        [Fact]
        public async void Admin_Get_AllUsers()
        {
            var readResult = await _squareDbMsSql.RetrieveUserAsync(1);

            Assert.Equal(0, readResult.ErrorCode);
            Assert.Equal(5, readResult.Resultset.Count());
        }

        /// <summary>
        /// Admin gets one user.
        /// </summary>
        [Fact]
        public async void Admin_Get_OneUser()
        {
            var readResult = await _squareDbMsSql.RetrieveUserAsync(1, 2);

            var user = readResult.Resultset.ToList()[0];

            Assert.Equal(0, readResult.ErrorCode);
            Assert.Single(readResult.Resultset);
            Assert.Equal("quentin", user.LastName);
            Assert.Equal("tarantino", user.FirstName);
            Assert.Equal("grindhouser", user.UserName);
        }
    }
}
