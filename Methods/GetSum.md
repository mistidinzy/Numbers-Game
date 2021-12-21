# GetSum Method

The method signature of GetSum() should contain:

- **static or instance**: static
- **return type**: integer
- **parameters**: integer array

---

The logic within the method should:

- Declare an integer variable named **sum**

- Iterate through the array and populate the **sum** variable with the sum of all the numbers together.

- Add the capability to throw a custom exception if the sum is less than 20, with the message
  - “Value of {sum} is too low”. (replace {sum} with the actual sum of the variable).

- Return the sum.

---

Expected Exceptions:

- No Try/Catch required, since no expected exceptions will be caught.
- We will have our custom exception be caught in lower levels of the callstack.

---

[Back](/README.md)

---
