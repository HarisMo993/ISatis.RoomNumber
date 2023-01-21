namespace ISatis.RoomNumber.Tests
{
    public class RoomNumberTest2
    {
        [Fact]
        public void numberOfSets_GivenRoomNumber_ReturnsCorrectNumberOfSets()
        {
            var roomNumber = 9999;
            var expectedNumberOfSets = 2;

            var actualNumberOfSets = new RoomNumber().numberOfSets(roomNumber);

            Assert.Equal(expectedNumberOfSets, actualNumberOfSets);
        }
    }
}