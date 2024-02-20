# Question: How can you calculate the number of islands in a 2D grid map? C# Summary

The provided C# program calculates the number of islands in a 2D grid map. An island is defined as a group of '1's (representing land) that are connected either horizontally or vertically, and surrounded by '0's (representing water). The program uses a Depth-First Search (DFS) algorithm to traverse the grid. It starts by iterating over each cell in the grid. If a cell contains a '1', the program increments a counter representing the number of islands and then uses DFS to traverse all connected cells containing '1's, marking them as '0's. This marking process ensures that any visited land cells are not counted as new islands when encountered again during the iteration process. If the grid is null or has no elements, the program returns 0. The final count of islands is then output to the console.

---

# Python Differences

Both the C# and Python versions solve the problem in a similar way using Depth-First Search (DFS). They both iterate over each cell in the grid, and if the cell is land (represented by '1'), they increment a count and then use DFS to mark all the connected land cells as water (represented by '0' in C# and '#' in Python). This way, when they encounter the same land cell again, they won't count it as a new island.

The main differences between the two versions are due to the differences in the languages themselves:

1. Syntax: Python uses indentation to denote blocks of code, while C# uses braces {}. Python also doesn't require semicolons at the end of statements, while C# does.

2. Class and Method Definitions: In Python, methods are defined inside a class using the 'def' keyword and the 'self' keyword is used to refer to the instance of the class. In C#, methods are defined inside a class using the 'public static' keywords and there's no need for a 'self' equivalent.

3. Main Function: In C#, the program starts from a 'Main' method in a class, while in Python, the program starts from the top-level code.

4. Null/None Checks: In C#, 'null' is used to represent the absence of a value, while in Python, 'None' is used. However, in this specific problem, the Python version uses 'not grid' to check if the grid is empty, which is more Pythonic.

5. Array Length: In C#, the length of an array is obtained using the 'Length' property, while in Python, the built-in 'len' function is used.

6. Print Statements: In C#, 'Console.WriteLine' is used to print to the console, while in Python, the 'print' function is used.

---

# Java Differences

Both the C# and Java versions solve the problem in a similar way using Depth-First Search (DFS). They both iterate over each cell in the grid, and if the cell is land ('1' in C# and 1 in Java), they increment the island count and use DFS to mark all connected land cells as water ('0' in C# and 0 in Java). This way, when the same land cell is encountered again, it won't be counted as a new island.

The main differences between the two versions are:

1. Input: The C# version has a hardcoded grid, while the Java version reads the size of the grid and the grid itself from the console using a Scanner.

2. Data Types: The C# version uses a 2D array of characters to represent the grid, while the Java version uses a 2D array of integers. This difference is reflected in the condition checks in the DFS method and the main loop in the NumIslands/numIslands method.

3. Output: The C# version outputs the result using Console.WriteLine, while the Java version uses System.out.println.

4. Language Syntax: The syntax of the two languages is slightly different, for example, array declaration and length checking. In C#, the length of an array is accessed using the Length property, while in Java, it's accessed using the length field. 

Overall, the logic of the solution is the same in both languages, and the differences are mainly due to the languages' syntax and conventions.

---
