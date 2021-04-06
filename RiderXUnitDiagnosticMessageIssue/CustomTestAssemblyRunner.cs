using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace RiderXUnitDiagnosticMessageIssue
{
    public class CustomTestAssemblyRunner : XunitTestAssemblyRunner
    {
        public CustomTestAssemblyRunner(ITestAssembly testAssembly,
            IEnumerable<IXunitTestCase> testCases,
            IMessageSink diagnosticMessageSink,
            IMessageSink executionMessageSink,
            ITestFrameworkExecutionOptions executionOptions) : base(testAssembly,
            testCases,
            diagnosticMessageSink,
            executionMessageSink,
            executionOptions)
        {
        }

        protected override Task AfterTestAssemblyStartingAsync()
        {
            // these messages incorrectly appear in the run's log; after running the tests, from the top menu
            // "Tests" -> "Session Options" -> "Diagnostics" -> "Show Last Launch Log"
            for (var i = 0; i < 10; i++)
            {
                DiagnosticMessageSink.OnMessage(
                    new DiagnosticMessage($"{nameof(CustomTestAssemblyRunner)}.{nameof(AfterTestAssemblyStartingAsync)} called # {i}"));

                /*
                 * These messages all seem to just have been a simple .ToString() call on the DiagnosticMessage object, which
                 * doesn't override ToString :(
                 *
                 * I think DiagnosticMessage.Message should be what's outputted to the log.
                 *
                 * Search the log output for these:
                 *
                 *  01:14:27.165 |I| TestRunner: Discoverer Discovery completed 
                    01:14:27.180 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
                    01:14:27.180 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
                    01:14:27.180 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
                    01:14:27.180 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
                    01:14:27.180 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
                    01:14:27.180 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
                    01:14:27.180 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
                    01:14:27.180 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
                    01:14:27.180 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
                    01:14:27.181 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
                    01:14:27.215 |I| TestRunner: XUnitRunner Execution completed 
                 * 
                 */
            }

            return base.AfterTestAssemblyStartingAsync();
        }

        protected override Task BeforeTestAssemblyFinishedAsync()
        {
            // a few more to illustrate the logging issue
            for (var i = 0; i < 5; i++)
            {
                DiagnosticMessageSink.OnMessage(
                    new DiagnosticMessage($"{nameof(CustomTestAssemblyRunner)}.{nameof(AfterTestAssemblyStartingAsync)} called # {i}"));
            }

            return base.BeforeTestAssemblyFinishedAsync();
        }
    }
}