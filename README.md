# To-Do List Manager (C# Console App)

## Description
A console-based **To-Do List Manager** built in C# as part of my software engineering learning journey. This project allows users to manage tasks through an interactive menu, supporting adding, removing, marking tasks as completed, and viewing the list. Key features include:

- **Add Task**: Enter a task name to append to the list (e.g., "Buy groceries").
- **Remove Task**: Select a task by number with a confirmation step ("Yes" or "No") before deletion.
- **Mark Task as Complete**: Append "[Completed]" to a task, with a check to avoid duplicates.
- **View Tasks**: Display all tasks with 1-based numbering (e.g., "1. Buy groceries [Completed]").

The program runs in a loop, refreshing the menu after each action with a clean interface using `Console.Clear()`.

## Features
- Interactive menu with five options: Add, Remove, Complete, View, Exit.
- Robust input validation with `int.TryParse` for menu choices and task selections.
- Bounds checking to prevent out-of-range errors (e.g., "Please enter a valid task number").
- Empty list handling with friendly messages ("No tasks in list to remove").
- Confirmation step in `removeTask` for user control.
- Dynamic task marking with "[Completed]" and duplicate prevention using `EndsWith`.

## Skills Learned
- **C# Basics**: Variables, loops (`while`, `for`), conditionals (`switch`, `if`), and console I/O.
- **Collections**: Used `List<string>` for dynamic task storage (`Add`, `RemoveAt`, indexing).
- **Error Handling**: Implemented `int.TryParse` and bounds checks to handle invalid inputs.
- **String Manipulation**: Concatenation (e.g., appending "[Completed]") and `EndsWith` for status checks.
- **Static Members**: Learned when to use `static` for fields and methods in a console app.

## How to Run
1. Clone this repository.
2. Open the project in a C# IDE (e.g., Visual Studio or VS Code with C# extension).
3. Build and run `Program.cs`.
4. Follow the menu prompts to manage your tasks!

## Example Loop
To-Do List Manager
What would you like to do?
1. Add task to list
2. Remove task from list
3. Mark task as complete
4. View task list
5. Exit

## Future Enhancements
- Save tasks to a file and load them on startup (e.g., using `File.WriteAllLines`).
- Add a "Pause" feature after actions with `Console.ReadKey()` for better feedback visibility.
- Include a task counter in the view (e.g., "Task List (3 tasks)").

## Author
Geoff Walsh

**Date**: March 2025

