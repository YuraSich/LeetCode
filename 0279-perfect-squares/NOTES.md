# Intuition
There are several basic approaches to solving the problem, the most effective is mathematical. for this it is important to know the three-square Lejandre Theorem, that any number can be expanded into a sum of three squares unless it has the following form $n=4^a(8b+7)$, where $a$ and $b$ are integers.
So for the number $x$ we have several options:
1) $x$ is already a square => return 1
2) for $x$ it is possible to find the coefficients of $a$ and $b$ that $x=4^a(8b+7)$=> return 4
3) for $x$ there is a number a such that $x$ - $a^2$ = $b^2$ => return 2
4) => return 3

# Complexity
- Time complexity:
$O(\sqrt{x} * \log(x))$

- Space complexity:
$O(1)$
