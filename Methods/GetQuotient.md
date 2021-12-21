# GetQuotient Method

The method signature of GetQuotient() should contain:

- **static or instance**: static
- **return type**: decimal
- **parameters**: integer product

---

The logic within the method should:

- Prompt the user to enter a number to divide the product by.

  - Display the current product to the user during this prompt.

- Retrieve the input and divide the inputted number by the product.

- Utilize the decimal.Divide() method to divide the product by the dividend to receive the quotient.

- Return the quotient

---

Expected Exceptions:

- Divide by Zero Exception
  - Output the message to the console
  - Do not throw it back to Main
  - Return 0 if the catch gets called

---

[Back](/README.md)

---
