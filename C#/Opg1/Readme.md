# What the Find

Implement the missing extension methods located in Extensions.cs

```c#
public static int? FindNearest(this IEnumerable<int> list, int value)

public static Node<T> FindWhere<T>(this Node<T> node, Func<Node<T>, bool> predicate, Func<Node<T>, IEnumerable<Node<T>>> next)
```

A few tests (in Tests folder) have been supplied for your testing pleasure!