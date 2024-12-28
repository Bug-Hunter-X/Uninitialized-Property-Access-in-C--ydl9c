# Uninitialized Property Access in C#

This repository demonstrates a common issue in C#: accessing a property before it's explicitly initialized.  Uninitialized properties can lead to unexpected behavior, such as default values (0 for integers, false for booleans, null for reference types) or exceptions depending on the context and the property's usage.

The `bug.cs` file showcases the problem, while `bugSolution.cs` demonstrates the solution.

**Problem:**
Accessing a property before assigning a value might return a default value or throw a `NullReferenceException` if the property is a reference type and not initialized to a default value.