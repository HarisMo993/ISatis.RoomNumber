namespace ISatis.RoomNumber.Tests
{
    public class RoomNumberTest
    {
        [Fact]
        public void numberOfSets_GivenRoomNumber_ReturnsCorrectNumberOfSets()
        {
            var roomNumber = 122;
            var expectedNumberOfSets = 2;

            var actualNumberOfSets = new RoomNumber().numberOfSets(roomNumber);

            Assert.Equal(expectedNumberOfSets, actualNumberOfSets);
        }
    }
}