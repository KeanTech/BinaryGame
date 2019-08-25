namespace BinaryGame
{
    class Player
    {
        public string Name;
        public int Points;
        public int Rounds;
        public Player(string aName, int NumberOfRounds, int aPoint)
        {
            Name = aName;
            Rounds = NumberOfRounds;
            Points = aPoint;
        }
    }
}
