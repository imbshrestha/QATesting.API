using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using QATesting.API.Models;

namespace QATesting.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestResultsController : ControllerBase
    {
        private readonly IQARepository _repository;

        public TestResultsController(IQARepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TestResult>> GetTestResults()
        {
            var testResults = _repository.GetAllTestResults();
            return Ok(testResults);
        }

        [HttpGet("{id}")]
        public ActionResult<TestResult> GetTestResult(int id)
        {
            var testResult = _repository.GetTestResultById(id);
            if (testResult == null)
            {
                return NotFound();
            }
            return Ok(testResult);
        }

        [HttpPost]
        public ActionResult<TestResult> CreateTestResult(TestResult testResult)
        {
            _repository.AddTestResult(testResult);
            return CreatedAtAction(nameof(GetTestResult), new { id = testResult.Id }, testResult);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTestResult(int id, TestResult testResult)
        {
            if (id != testResult.Id)
            {
                return BadRequest();
            }

            _repository.UpdateTestResult(testResult);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestResult(int id)
        {
            _repository.DeleteTestResult(id);
            return NoContent();
        }
    }
}
