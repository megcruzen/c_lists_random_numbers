## Practice: Random Numbers
### C# List Practice with Random Integers
https://github.com/nashville-software-school/bangazon-inc/blob/master/book-1-orientation/chapters/DATA_STRUCTURES_LIST.md

### Instructions

1. Use the following code to create a list of random numbers. Each number will be between 0 and 9.

```Random random = new Random();
List<int> numbers = new List<int> {
    random.Next(10),
    random.Next(10),
    random.Next(10),
    random.Next(10),
    random.Next(10),
};
```

2. Use a `for` loop to iterate over all numbers between `0` and `numbers.Count - 1`.
3. Inside the body of the `for` loop determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

**Example Output in the Terminal**

```numbers list contains 0
numbers list does not contain 1
numbers list does not contain 2
numbers list contains 3
numbers list contains 4
```

**NOTE:** Each run will produce different output.
