# Rand using another Rand

<!-- TOC -->
* [Rand using another Rand](#rand-using-another-rand)
  * [Description](#description)
  * [The problem](#the-problem)
  * [Testing](#testing)
  * [Attempts](#attempts)
    * [Split to 5 sections](#split-to-5-sections)
    * [Run it 5 times](#run-it-5-times)
    * [Re-rolling](#re-rolling)
    * [Multiple dice and re-roll(aiming to minimalize the chance to re-roll)](#multiple-dice-and-re-rollaiming-to-minimalize-the-chance-to-re-roll)
  * [Alternative thinking](#alternative-thinking)
<!-- TOC -->

## Description

Using a function `rand7()` that returns an integer from 1 to 7 (inclusive) with uniform probability, implement a function `rand5()` that returns an integer from 1 to 5 (inclusive).

## The problem

The number `7` and `5` are prime numbers.

## Testing

Calling the new function `rand5` enough times(big number) to check the frequency distributions with an acceptable delta/offset.

## Attempts

### Split to 5 sections

Divide the result of `rand7` to 1.4(7 / 5). It generates an uneven distributions:
```
[0.7143, 1.4286, 2.1429, 2.8571, 3.5714, 4.2857, 5.0000]
```
Rounding(floor, ceil, closer) does not give equal frequency.

### Run it 5 times

Calling `rand7` 5 times to divide to 7 as theoretical max is 35 is not a solution. It produces a distribution bell curve where sum 20 has the highest frequency and edges like 1 and 35 lowest.

### Re-rolling

Call `rand7()`. If the result is 6 or 7, re-roll it.
It works on the first call on 71%(5/7).

### Multiple dice and re-roll(aiming to minimalize the chance to re-roll)

$7 + \sum_{n=2}^{N} 6 \cdot 7^{n - 1} \quad \text{where } N \text{ is the dimension count}$


| Dice | Max value | Closest | Chance              |
|------|-----------|---------|---------------------|
| 1    | 7         | 5       | 71.42%(5/7)         |
| 2    | 49        | 45      | 91.84%(85/98)       |
| 3    | 343       | 340     | 99.12%(340/343)     |
| 4    | 2401      | 2400    | 99.96%(2400/2401)   |
| 5    | 16807     | 16805   | 99.98%(16805/16807) |

## Alternative thinking

Think about it as a selecting of a random point in N-dimensioned space with axis from 1 to 7. If we want an equal distribution, then we should create a formula to converting(X value, Y value, Z value, ...) to a number between 1 and 7 ^ N.
For example, for N = 2, it is a range from 1 to 49.
For N = 3, it is range between from 1 to 343.
etc.