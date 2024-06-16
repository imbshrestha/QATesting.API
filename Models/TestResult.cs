namespace QATesting.API.Models
{
    public class TestResult
    {
        public int Id { get; set; }
        public string TestName { get; set; }
        public string Notes { get; set; }
        public bool Passed { get; set; }
    }
}
