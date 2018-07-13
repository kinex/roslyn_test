# roslyn_test
Roslyn test app

Test app for reproducing the issue described here:
https://stackoverflow.com/questions/51261637/using-microsoft-codeanalysis-nuget-package-causes-wack-to-fail

Steps to repdoruce:
1. Open the solution RoslynTest.sln in Visual Studio 2017
2. Right-click on project "Package" and select Store => Create App Packages
3. Select "I want to create packages for sideloading" and click Next
4. Click "Create" to create packages
5. Wait until "Package creation completed" dialog is shown and click the "Launch WACK" -button
6. Select all tests and run it
7. Open the results to see the failures
