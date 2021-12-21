# Populate Method

The method signature of Populate() should contain:

- **static or instance**: static
- **return type**: integer array
- **parameters**: integer array

---

The logic within the method should:

- Iterate through the array and prompt the user to enter a specific number.
  - Example: “Please enter a number 1/6” (indicate to the user what number they are inputting).

- Utilize the Convert.ToInt32 method to convert the user’s input to an integer
  - (Remember not to directly manipulate the user’s input. Store the response into a string first).

- Add the number just entered into the array.

- Repeat this process until all numbers have been requested and the array is filled.

- Return the populated array.

---

Expected Exceptions:

- No expected exceptions.
- Not even a generic exception.
- StartSequence() will already capture your **FormatException** error.

---

[Back](/README.md)

---
