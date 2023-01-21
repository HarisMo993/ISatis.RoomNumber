namespace ISatis.RoomNumber.Tests
{
    public class RoomNumberTest6
    {
        [Fact]
        public void numberOfSets_GivenRoomNumber_ReturnsCorrectNumberOfSets()
        {
            var roomNumber = 10000000;
            var expectedNumberOfSets = 7;

            var actualNumberOfSets = new RoomNumber().numberOfSets(roomNumber);

            Assert.Equal(expectedNumberOfSets, actualNumberOfSets);
        }
    }
}