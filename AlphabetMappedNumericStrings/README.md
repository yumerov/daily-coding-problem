# Implement Decoder for Alphabet-Mapped Numeric Strings

<!-- TOC -->
* [Implement Decoder for Alphabet-Mapped Numeric Strings](#implement-decoder-for-alphabet-mapped-numeric-strings)
  * [Description](#description)
  * [Testing](#testing)
  * [Attempts](#attempts)
    * [Tree building + Leaf counting + Recursion](#tree-building--leaf-counting--recursion)
      * [Example 1](#example-1)
      * [Example 2](#example-2)
<!-- TOC -->

Issue: https://github.com/yumerov/daily-coding-problem/issues/3

## Description

Given the mapping a = 1, b = 2, ... z = 26, and an encoded message, count the number of ways it can be decoded.
For example, the message '111' would give 3, since it could be decoded as 'aaa', 'ka', and 'ak'.
You can assume that the messages are decodable. For example, '001' is not allowed.

## Testing

Simple unit tests.
Run `dotnet test AlphabetMappedNumericStrings.Tests/AlphabetMappedNumericStrings.Tests.csproj` from the repo root.
Use input that can cause performance issues. Example: 1s repeated 10 times - it will create a lot of branching. While 3 repeated 10 times will return 1 as there is not branching, more a structure like linked list.

## Performance

Run on Mac M2.

```bash
dotnet test AlphabetMappedNumericStrings.Tests/AlphabetMappedNumericStrings.Tests.csproj --filter "FullyQualifiedName~AlphabetMappedNumericStrings.Tests.AlphabetMappedNumericDecoderTests.Performance_NoMemorization"
# Test summary: total: 2, failed: 0, succeeded: 2, skipped: 0, duration: 32,1s
# Build succeeded in 33,0s
```

```bash
dotnet test AlphabetMappedNumericStrings.Tests/AlphabetMappedNumericStrings.Tests.csproj --filter "FullyQualifiedName~AlphabetMappedNumericStrings.Tests.AlphabetMappedNumericDecoderTests.Performance_Memorization"
# Test summary: total: 2, failed: 0, succeeded: 2, skipped: 0, duration: 1,1s
# Build succeeded in 1,9s
```


## Attempts

### Tree building + Leaf counting + Recursion

Using repeating 1s as 11 can be interpreted as 1 and 11.

#### Example 1

```mermaid
graph TD
    root((111)) --> 1:11
    1:11 --> 1((1:1:1))
    1:11 --> 2((1:11))
    root --> 3((11:1))
```

#### Example 2

```mermaid
graph TD
    root((11111))
    root --> 1:1111
    1:1111 --> 1:1:111
    1:1:111 --> 1:1:1:11
    1:1:1:11 --> 1((1:1:1:1:1))
    1:1:1:11 --> 2((1:1:1:11))
    1:1:111 --> 3((1:1:11:1))
    1:1111 --> 1:11:11
    1:11:11 --> 4((1:11:1:1))
    1:11:11 --> 5((1:11:11))
    
    root --> 11:111
    11:111 --> 11:1:11
    11:1:11 --> 6((11:1:1:1))
    11:1:11 --> 7((11:1:11))
    11:111 --> 8((11:11:1))
```

As we can observe, the subtrees repeat themselves in other branches, just like Fibonacci which means without caching/memorization, the time complexity is O(F(N)), where N is the lenght of input string.

## Disclaimer

Using `int` limit us up to 2,147,483,647 result count. For further results, use `long` or other bigger type.
For more information see [Integral numeric types (C# reference)](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)