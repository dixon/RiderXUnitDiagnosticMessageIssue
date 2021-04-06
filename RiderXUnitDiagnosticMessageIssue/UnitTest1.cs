using Xunit;
using Xunit.Abstractions;

namespace RiderXUnitDiagnosticMessageIssue
{
    public class UnitTest1
    {
        public UnitTest1(ITestOutputHelper log)
        {
            log.WriteLine("constructor");   // this will correctly appear in the individual test's output, inside 
                                            // the "Unit Tests" window
        }
        
        [Fact]
        public void Test1()
        {
        }
    }
}