# Scenario Instructions

## Parameters
- **Solution**: `C:\Typsy\recurly-client-dotnet\recurly.sln`
- **Target Framework**: net10.0 (.NET 10.0 LTS)
- **Source Branch**: `v3-v2021-02-25`
- **Working Branch**: `upgrade-to-NET10`

## Strategy
**Selected**: All-At-Once
**Rationale**: 2 projects, all SDK-style, all packages compatible, 1 low-impact behavioral change — straightforward upgrade.

### Execution Constraints
- Single atomic upgrade — all projects updated together
- Validate full solution build after upgrade
- Run tests after build succeeds
- No tier ordering or phased rollout

## Preferences

### Flow Mode
**Automatic** — Run end-to-end, only pause when blocked or needing user input.

### Commit Strategy
**Single Commit at End** — One atomic upgrade, one commit.

### Technical Preferences
*(none yet)*

### Execution Style
*(none yet)*

### Custom Instructions
*(none yet)*

## Key Decisions Log
*(none yet)*