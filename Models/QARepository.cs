using System.Collections.Generic;
using System.Linq;

namespace QATesting.API.Models
{
    public class QARepository : IQARepository
    {
        private readonly QAContext _context;

        public QARepository(QAContext context)
        {
            _context = context;
        }

        public IEnumerable<TestResult> GetAllTestResults()
        {
            return _context.TestResults.ToList();
        }

        public TestResult GetTestResultById(int id)
        {
            return _context.TestResults.Find(id);
        }

        public void AddTestResult(TestResult testResult)
        {
            _context.TestResults.Add(testResult);
            _context.SaveChanges();
        }

        public void UpdateTestResult(TestResult testResult)
        {
            _context.TestResults.Update(testResult);
            _context.SaveChanges();
        }

        public void DeleteTestResult(int id)
        {
            var testResult = _context.TestResults.Find(id);
            if (testResult != null)
            {
                _context.TestResults.Remove(testResult);
                _context.SaveChanges();
            }
        }
    }
}
