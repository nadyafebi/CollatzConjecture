# The Collatz Conjecture

The Collatz conjecture is a conjecture in mathematics named after Lothar Collatz, who first proposed it in 1937.

The conjecture can be summarized as follows:

- Take any positive integer n. 
  - If n is even, divide it by 2 to get n / 2. 
  - If n is odd, multiply it by 3 and add 1 to obtain 3n + 1.
- Repeat the process indefinitely.

The conjecture is that no matter what number you start with, you will always eventually reach 1.

The sequence of numbers involved is referred to as the hailstone sequence or hailstone numbers because the values are usually subject to multiple descents and ascents like hailstones in a cloud.

# What This Program Does

This is a console app that can take input up to 7.9 x 10<sup>28</sup> and will show you:

- The hailstone sequence (will stop at 1).
- The number of steps taken.
- The largest number in the sequence.
