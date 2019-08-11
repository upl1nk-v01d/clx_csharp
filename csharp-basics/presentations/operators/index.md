---?color=linear-gradient(to right, #4caf50, #dbff3d)
@title[Operators]

@snap[midpoint announce-section-title text-white span-100]
Operators
@snapend

+++
@title[Lesson objective]

@snap
After this lesson you will know:
@snapend

@ul[list-bullets-black](false)
- What are and how to apply: 
  - arithmetic operators
  - comparison operators
  - boolean operators
  - arithmetic compound operators
- In which order arithmetic operations are being executed
@ulend

+++
@title[Arithmetic operators]

@snap[north]
Arithmetic operators
@snapend

| Name | Meaning | Example | Result |
| --- | --- | --- | --- |
| ```+``` | Addition | ```4 + 3``` | ```7``` | 
| ```-``` | Subtraction | ```9 - 4``` | ```5``` | 
| ```*``` | Multiplication | ```2 * 6``` | ```12``` | 
| ```/``` | Division | ```9 / 3``` | ```3``` | 
| ```%``` | Remainder | ```20 % 3``` | ```2``` |

@snap[south span-100]
@css[text-orange](Integer division throws away reminder)
@snapend

Note:

/ is the division operator. If the types of the operands are double, then "real" division is performed. Real division is normal division. Division is approximate on a computer because you can't do infinitely precise division (recall that double values have finite precision, so there is usually a tiny, but unavoidable error representing real numbers). The result of dividing a double by a double is a double.
However, if both expressions have type int, then the result is an int.

C# does integer division, which basically is the same as regular real division, but you throw away the remainder (or fraction). Thus, 7 / 3 is 2 with a remainder of 1. Throw away the remainder, and the result is 2.
