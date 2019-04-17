namespace LinqPart3
{
    public class TestResults
    {
        public string Id { get; set; }
        public string FamilyId { get; set; }
        public int Score { get; set; }

        public TestResults(string Id, string FamilyId, int Score)
        {
            this.Id = Id;
            this.FamilyId = FamilyId;
            this.Score = Score;
        }

        public override bool Equals(object obj)
        {
            var other = obj as TestResults;
            if (other == null)
                return false;
            return this.Id == other.Id && this.FamilyId == other.FamilyId && this.Score == other.Score;
        }
    }
}