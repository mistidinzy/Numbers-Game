# StartSequence

The method signature of StartSequence() should contain:

- static
- void return type
- no parameters

---

The logic within the method should:

- Prompt the user to “Enter a number greater than zero”.

- Utilize the Convert.ToInt32() method to convert the user’s input to an integer.

- Instantiate a new integer array that is the size the user just entered.

- Call the Populate() method.
  - arguments: integer array
  
- Capture the sum by calling the GetSum() method.
  - arguments: integer array

- Capture the product by calling the GetProduct() method.
  - integer array and integer sum

- Capture the quotient by calling the GetQuotient() method.
  - arguments: integer product

---

To complete the method, output to the console the details of all these values.

Make sure that your output contains the same information presented in the example. Pay attention to line breaks!

---

Exceptions expected:

- **Format Exception**
  - Output the message to the console

- **Overflow Exception**
  - Output the message to the console

---

[Back](/README.md)

---
