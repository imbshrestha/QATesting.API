using System.Collections.Generic;

namespace QATesting.API.Models
{
    public interface IQARepository
    {
        IEnumerable<TestResult> GetAllTestResults();
        TestResult GetTestResultById(int id);
        void AddTestResult(TestResult testResult);
        void UpdateTestResult(TestResult testResult);
        void DeleteTestResult(int id);
    }
}
