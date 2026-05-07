# Tennis Kata

A C#/.NET implementation of the Tennis Kata, developed using a Test Driven Development (TDD) approach.

This repository was created as part of a technical code kata assignment. It contains the tennis scoring logic implemented as a class library with a separate xUnit test project. The solution focuses on simple design, clear scoring rules, unit testing and an incremental development process.

## About the Kata

The Tennis Kata is a small programming exercise about implementing the scoring rules of a simplified tennis game.

The scoring system includes:

- Love
- Fifteen
- Thirty
- Forty
- Deuce
- Advantage
- Win

A game is won by the first player to win at least four points in total and at least two points more than the opponent.

## Implemented Rules

The implementation covers the main scoring scenarios required by the kata.

### Regular Scores

| Player One Points | Player Two Points | Score |
|---:|---:|---|
| 0 | 0 | Love-All |
| 1 | 0 | Fifteen-Love |
| 2 | 0 | Thirty-Love |
| 3 | 0 | Forty-Love |
| 0 | 1 | Love-Fifteen |
| 0 | 2 | Love-Thirty |
| 0 | 3 | Love-Forty |
| 2 | 1 | Thirty-Fifteen |
| 3 | 2 | Forty-Thirty |
| 1 | 2 | Fifteen-Thirty |

### Tied Regular Scores

| Player One Points | Player Two Points | Score |
|---:|---:|---|
| 1 | 1 | Fifteen-All |
| 2 | 2 | Thirty-All |

### Deuce

If both players have at least three points and the scores are equal, the score is Deuce.

| Player One Points | Player Two Points | Score |
|---:|---:|---|
| 3 | 3 | Deuce |
| 4 | 4 | Deuce |
| 5 | 5 | Deuce |

### Advantage

If both players have at least three points and one player leads by exactly one point, that player has Advantage.

| Player One Points | Player Two Points | Score |
|---:|---:|---|
| 4 | 3 | Advantage Player One |
| 3 | 4 | Advantage Player Two |
| 5 | 4 | Advantage Player One |
| 4 | 5 | Advantage Player Two |

### Win

A player wins when they have at least four points and lead by at least two points.

| Player One Points | Player Two Points | Score |
|---:|---:|---|
| 4 | 0 | Win for Player One |
| 4 | 2 | Win for Player One |
| 5 | 3 | Win for Player One |
| 0 | 4 | Win for Player Two |
| 2 | 4 | Win for Player Two |
| 3 | 5 | Win for Player Two |

## Technology Stack

- C#
- .NET 8
- xUnit
- Git
- GitHub

## Project Structure

```text
TennisKata/
├── src/
│   └── TennisKata/
│       ├── TennisKata.csproj
│       └── TennisGame.cs
├── tests/
│   └── TennisKata.Tests/
│       ├── TennisKata.Tests.csproj
│       └── TennisGameTests.cs
├── README.md
├── .gitignore
└── TennisKata.slnx
```

## How to Run

### Prerequisites

Make sure the .NET SDK is installed.

This project targets .NET 8.

You can check your installed SDK version with:

```bash
dotnet --version
```

### Clone the Repository

```bash
git clone https://github.com/mikepapanik/TennisKata.git
cd TennisKata
```

### Restore Dependencies

```bash
dotnet restore
```

### Build the Solution

```bash
dotnet build
```

### Run the Tests

```bash
dotnet test
```

## Expected Result

The test suite should complete successfully with all tests passing.

Example:

```text
Test summary: total: 25; failed: 0; succeeded: 25
```

## Running from Visual Studio

Open the solution file in Visual Studio:

```text
TennisKata.slnx
```

Then run the tests from:

```text
Test > Run All Tests
```

You can also open the Test Explorer and run all tests from there.

## Design Notes

The project is intentionally implemented as a class library with a separate test project.

The kata focuses on domain logic and scoring rules, so a console application, web API, database or user interface was not necessary.

The main class is:

```csharp
TennisGame
```

It stores the raw point count for each player as integers and derives the display score from those values.

This keeps the internal state simple and makes the scoring rules explicit.

The public API is intentionally small:

```csharp
public void PlayerOneScores()
public void PlayerTwoScores()
public string GetScore()
```

The score calculation is organized around small private methods:

```csharp
HasWinner()
IsDeuce()
HasAdvantage()
GetLeadingPlayerName()
GetPointName()
```

The implementation also uses named constants instead of magic numbers:

```csharp
MinimumPointsToWin
MinimumPointsForDeuce
RequiredLeadToWin
RequiredLeadForAdvantage
```

This improves readability and makes the tennis rules easier to understand from the code.

## TDD Approach

The solution was developed incrementally using Test Driven Development.

The workflow followed the Red-Green-Refactor cycle:

1. Write a failing test.
2. Implement the minimum code needed to pass the test.
3. Refactor while keeping all tests green.
4. Commit each meaningful step.

The implementation was built step by step:

1. Initial solution and test project setup
2. First test for a new game returning `Love-All`
3. Basic scoring for Player One
4. Basic scoring for Player Two
5. Tied regular scores
6. Mixed regular scores
7. Deuce scenarios
8. Advantage scenarios
9. Winning scenarios
10. Test refactoring with helper methods
11. Production code refactoring

Each meaningful step was committed separately so the development process can be followed through the Git history.

## Git History

The repository contains a step-by-step commit history showing the development process.

Example commit sequence:

```text
Initial solution structure with test project
Add initial tennis game score test
Add basic scoring for player one
Add basic scoring for player two
Handle tied regular scores
Add mixed regular score tests
Handle deuce scores
Handle advantage scores
Handle winning scores
Refactor tests with score helper methods
Refactor tennis score calculation
```

## Test Coverage

The test suite covers:

- New game initial score
- Basic scoring for both players
- Regular tied scores
- Mixed regular scores
- Deuce
- Repeated deuce
- Advantage for both players
- Repeated advantage scenarios
- Winning scenarios for both players

The current test suite contains 25 tests.

## Why There Is No Console App or Web API

This assignment is a code kata focused on logic, tests and design decisions.

For that reason, the solution is kept as:

- a class library for the tennis scoring logic
- a unit test project for validating the behavior

This keeps the project focused, simple and easy to review.

Adding a console application, web API, frontend or database would not add value to this specific kata and would introduce unnecessary complexity.

## Example Usage

```csharp
var game = new TennisGame();

game.PlayerOneScores();
game.PlayerTwoScores();

var score = game.GetScore();
```

For this example, the score would be:

```text
Fifteen-All
```
