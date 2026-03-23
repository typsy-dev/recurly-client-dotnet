# .NET Version Upgrade Plan

## Overview

**Target**: Upgrade all projects to .NET 10.0 (net10.0)
**Scope**: 2 projects, ~27k LOC — straightforward upgrade with no breaking API changes

### Selected Strategy
**All-At-Once** — All projects upgraded simultaneously in a single operation.
**Rationale**: 2 projects, all SDK-style, all packages compatible, 1 low-impact behavioral change.

## Tasks

### 01-upgrade-all-projects: Upgrade all projects to net10.0

Update the target framework for both projects from their current versions to net10.0, update NuGet package references as needed, and address the `System.Uri` behavioral change in Recurly.csproj. Build the solution and fix any compilation errors.

Affected projects:
- `Recurly\Recurly.csproj` (netstandard2.0 → net10.0)
- `ConsoleApp1\ConsoleApp1.csproj` (net9.0 → net10.0)

**Done when**: All project files target net10.0, all packages are restored, and the solution builds with zero errors.

---

### 02-run-tests: Validate upgrade with tests

Run all tests in the solution to verify that the upgrade has not introduced regressions, particularly around the `System.Uri` behavioral change.

**Done when**: All tests pass, or any failures are documented with root cause analysis.
