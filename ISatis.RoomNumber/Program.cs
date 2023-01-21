namespace ISatis.RoomNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            int roomNumber;
            RoomNumber room = new RoomNumber();
            Console.WriteLine("Opseg za broj soba je od 1 do 1000000");
            Console.WriteLine("--------------------------------------");
            while (true)
            {
                Console.WriteLine("Unesite broj sobe");
                string inputRoomNumber = Console.ReadLine();
                if (int.TryParse(inputRoomNumber, out roomNumber) && roomNumber >= 1 && roomNumber <= 1000000)
                {
                    Console.WriteLine("Broj: " + room.numberOfSets(roomNumber));
                    break;
                }
                Console.WriteLine("Unesena vrijednost nije ispravna. Molim unesite ponovno.");
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}