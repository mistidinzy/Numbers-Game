# GetProduct Method

The method signature of GetProduct() should contain:

- **static or instance**: static
- **return type**: integer
- **parameters**: integer array, integer sum

---

The logic within the method should:

- Ask the user the select a random number between 1 and the length of the integer array.

- Declare a new variable named product

- Multiply sum by the random number index that the user selected from the array (example: array[randomNumber]).
  - Set this value to the product variable.
  - Return the product variable.

---

Expected Exceptions:

- IndexOutOfRange
  - Output the message to the console.
  - Throw it back down the call stack so that it displays within Main.

---

[Back](/README.md)

---
