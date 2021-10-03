# Build a Maze

We would like you to write a short console application that creates a random maze and prints it to the screen.

You can print the output as hash (#) characters for walls and empty spaces for walkways

The maze must:

- have a start and a finish on different edges of the window
- have at least one valid path through the maze
- be generated at runtime with a new randomised output each time

Ideally the solution will be written in C#.

## Solution

- Eller's algorithm is adapted from the following [article](http://www.neocomputer.org/projects/eller.html).
- The width and height properties depend on the width of the console window.
