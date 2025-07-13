# Implement Decoder for Alphabet-Mapped Numeric Strings

Issue: https://github.com/yumerov/daily-coding-problem/issues/3

## Description

Given the mapping a = 1, b = 2, ... z = 26, and an encoded message, count the number of ways it can be decoded.
For example, the message '111' would give 3, since it could be decoded as 'aaa', 'ka', and 'ak'.
You can assume that the messages are decodable. For example, '001' is not allowed.

## Testing

Simple unit tests.
Run `dotnet test AlphabetMappedNumericStrings.Tests/AlphabetMappedNumericStrings.Tests.csproj` from the repo root.

## Attempts

### Recursion

Example 1:
We begin with `111`. We have two points to work: 1:11 and 11:1. 1:11 branches out as 1:1:1 and 1:11. So we have aaa, ak and ka.