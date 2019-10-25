# Open-Lab-03.07
(12 XP) A function that checks if a cake can be divided fairly.

1. Clone this repository to your GitHub account.
2. Open solution file in Visual Studio.
3. Open file `Divider.cs`.
4. Implement method `EqualSlices(int total, int people, int each)` that checks, if a cake can be divided fairly between people.
5. Run with `CTRL+F5` to test it.
6. If all tests are passed, commit & sync your repository.
7. Send a link to your repository for Lab Master (in #slack) to check it.

## Examples: 
```C#
EqualSlices(11, 5, 2) ➞ true
// 5 people x 2 slices each = 10 slices < 11 slices

EqualSlices(11, 5, 3) ➞ false
// 5 people x 3 slices each = 15 slices > 11 slices

EqualSlices(8, 3, 2) ➞ true
EqualSlices(8, 3, 3) ➞ false
EqualSlices(24, 12, 2) ➞ true
```
