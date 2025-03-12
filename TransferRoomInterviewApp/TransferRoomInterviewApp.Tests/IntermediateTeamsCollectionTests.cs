using TransferRoomInterviewApp.Server.DataAccess.LocalStorage;

namespace TransferRoomInterviewApp.Tests
{
    public class IntermediateTeamsCollectionTests
    {
        private IntermediateTeamsCollection _collection;

        public IntermediateTeamsCollectionTests()
        {
            _collection = new IntermediateTeamsCollection();
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData("L", 13)]
        [InlineData("The Reds", 1)]
        [InlineData("Test", 0)]
        public void TeamsSearchByNameOrNickname_ShouldReturnTeams(string searchInput, int expectedTeamsCount)
        {
            // Act
            var result = _collection.GetTeamsBySearchInput(searchInput);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedTeamsCount, result.Count());
        }
    }
}