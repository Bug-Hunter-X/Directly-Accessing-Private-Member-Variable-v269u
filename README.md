# Directly Accessing Private Member Variable in C#

This example demonstrates the issue of directly accessing a private member variable of a class.  While technically possible, it's generally considered bad practice and can lead to maintainability problems.  The preferred approach is to use public properties or methods to interact with the class's internal state.

## Bug Description

The `bug.cs` file shows a class with a private integer variable `_value` and a public property `Value`. The `MyMethod` function directly modifies `_value`, bypassing the property. This practice can make the code harder to understand, debug, and maintain.