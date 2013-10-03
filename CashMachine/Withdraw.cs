namespace CashMachine
{
    public struct Withdraw
    {
        private readonly int _tenNotes;
        private readonly int _twentyNotes;
        private readonly int _fiftyNotes;
        private readonly int _hundredNotes;

        public Withdraw(int tenNotes, int twentyNotes, int fiftyNotes, int hundredNotes)
        {
            _tenNotes = tenNotes;
            _twentyNotes = twentyNotes;
            _fiftyNotes = fiftyNotes;
            _hundredNotes = hundredNotes;
        }

        public int TenNotes { get { return _tenNotes; } }

        public int TwentyNotes { get { return _twentyNotes; } }

        public int FiftyNotes { get { return _fiftyNotes; } }

        public int HundredNotes { get { return _hundredNotes; } }
    }
}
