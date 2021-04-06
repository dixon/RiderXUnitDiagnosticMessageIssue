# RiderXUnitDiagnosticMessageIssue
Reproduces an issue with Rider's xUnit logging - filed here https://youtrack.jetbrains.com/issue/RIDER-60811

When using xUnit's extensibility classes, verbose diagnostic output is rendered incorrectly in a test session's output log file.

After running the single test in UnitTest1.cs, view the Last Launch Log via "Tests" -> "Session Options" -> "Diagnostics" -> "Show Last Launch Log"

You can see the block of output that's just the xUnit class name, like so:

```
01:36:48.671 |V| Run: 6006efe4-896c-4515-8713-b1d03ddf5319 - Discovery result processing started
01:36:48.675 |V| Run: 6006efe4-896c-4515-8713-b1d03ddf5319 - Discovery result processing finished (+0 -0 ~0)
01:36:48.679 |V| TestRunner: Discoverer Sending discovery results to server... 
01:36:48.679 |I| TestRunner: Discoverer Discovery completed 
01:36:48.695 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.695 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.695 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.695 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.695 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.695 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.695 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.695 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.695 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.695 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.743 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.743 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.743 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.743 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.743 |V| TestRunner: XUnitRunner Xunit.Sdk.DiagnosticMessage 
01:36:48.743 |I| TestRunner: XUnitRunner Execution completed 
01:36:48.762 |I| Process C:\Users\jarrod\AppData\Local\JetBrains\Toolbox\apps\Rider\ch-0\203.6682.21\lib\ReSharperHost\TestRunner\netcoreapp2.0\ReSharperTestRunner64.exe:40828 has exited with code (0)
```
