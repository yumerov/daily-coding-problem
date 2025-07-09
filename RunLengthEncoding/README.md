# Run-length encoding

<!-- TOC -->
* [Run-length encoding](#run-length-encoding)
  * [Description](#description)
  * [Testing](#testing)
  * [Attempts](#attempts)
    * [Cell by cell](#cell-by-cell)
      * [Encode](#encode)
      * [Decode](#decode)
<!-- TOC -->

Issue: https://github.com/yumerov/daily-coding-problem/issues/1

## Description

Convert "AAAABBBCCDAA" to "4A3B2C1D2A" and otherwise.

## Testing

Simple unit tests.
Run `dotnet test RunLengthEncoding.Tests/RunLengthEncoding.Tests.csproj` from the repo root.

## Attempts

### Cell by cell

Approach giving us O(n) efficiency.

#### Encode

Going character by character. If the character is matching the last one, we increase its numbers. If it not, we add to the output in format "{times}{last character}" and begin to count the new one.
Using variables for accumulated count, previous character and a StringBuilder instance.

#### Decode

Going character by character. If the character is a digit, we add it count holder(previous number * 10 + current one). If not, we add to the output the character repeated N times and continue with the next one.

