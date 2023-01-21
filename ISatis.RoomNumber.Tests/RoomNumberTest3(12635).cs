namespace ISatis.RoomNumber.Tests
{
    public class RoomNumberTest3
    {
        [Fact]
        public void numberOfSets_GivenRoomNumber_ReturnsCorrectNumberOfSets()
        {
            var roomNumber = 888888;
            var expectedNumberOfSets = 6;

            var actualNumberOfSets = new RoomNumber().numberOfSets(roomNumber);

            Assert.Equal(expectedNumberOfSets, actualNumberOfSets);
        }
    }
}