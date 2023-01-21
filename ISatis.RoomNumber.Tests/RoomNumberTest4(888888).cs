namespace ISatis.RoomNumber.Tests
{
    public class RoomNumberTest4
    {
        [Fact]
        public void numberOfSets_GivenRoomNumber_ReturnsCorrectNumberOfSets()
        {
            var roomNumber = 8888888;
            var expectedNumberOfSets = 7;

            var actualNumberOfSets = new RoomNumber().numberOfSets(roomNumber);

            Assert.Equal(expectedNumberOfSets, actualNumberOfSets);
        }
    }
}