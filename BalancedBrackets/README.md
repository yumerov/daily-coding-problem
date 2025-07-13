# Balanced Brackets

Issue: https://github.com/yumerov/daily-coding-problem/issues/4

## Descriptions

Given a string of round, curly, and square open and closing brackets, return whether the brackets are balanced (well-formed).
For example, given the string "([])", you should return true.
Given the string "([)]" or "((()", you should return false.

## Testing

Simple unit tests.
Run `dotnet test BalancedBrackets.Tests/BalancedBrackets.Tests.csproj` from the repo root.

## Attempts

### Using a stack to keep the track

Going a character by a character and keeping the track of open brackets. If there is a closed bracket and not matching the last open bracket, then the string is invalid.
The solution gives us O(n) for time complexity and O(n) for space complexity as we can have a string of only open brackets, where n is the string's length.

## Disclaimer

Depends on already solved my solution for python: https://github.com/yumerov/codewars/blob/f3a2e3547b8f86153391f705fd134b9c3c6d320e/Python/Kyu6/pairing-brackets.py