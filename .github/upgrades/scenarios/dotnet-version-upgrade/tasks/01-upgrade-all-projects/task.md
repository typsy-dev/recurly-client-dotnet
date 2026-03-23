# 01-upgrade-all-projects: Upgrade all projects to net10.0

Update the target framework for both projects from their current versions to net10.0, update NuGet package references as needed, and address the `System.Uri` behavioral change in Recurly.csproj. Build the solution and fix any compilation errors.

Affected projects:
- `Recurly\Recurly.csproj` (netstandard2.0 → net10.0)
- `ConsoleApp1\ConsoleApp1.csproj` (net9.0 → net10.0)

**Done when**: All project files target net10.0, all packages are restored, and the solution builds with zero errors.
