---?color=linear-gradient(to right, #4caf50, #dbff3d)
@title[Types & Variables]

@snap[midpoint announce-section-title text-white span-100]
Types & Variables
@snapend

+++
@title[Lesson objective]

@snap[span-100]
After this lesson you will know:
@snapend
<br/>
@ul[list-bullets-black](false)
- Why are types needed
- Primitive data types
- How to work with *String*
- What is a variable and scope
- How to name variables
- How variables are stored in the memory
- What is type casting
- What is **null**
@ulend

+++?image=.gitpitch/img/bg/black.jpg&position=right&size=50% 100%
@title[Static and dynamic typing]

@snap[north-west span-40 text-center]
Static typing
@snapend

@snap[west span-40]
@code[java zoom-12](presentations/types-and-variables/types.java)
@snapend

@snap[west span-45 text-08]
@box[bg-green text-white fragment](More errors detected earlier in development.)
<br/>
@box[bg-green text-white fragment](Allows for compiler optimisation which yields faster code.)
<br/>
@box[bg-orange text-white fragment](Can lead to boilerplate.) 
@snapend

@snap[north-east span-40 text-center text-white]
Dynamic typing
@snapend

@snap[east span-40]
@code[python zoom-12](presentations/types-and-variables/types.py)
@snapend

@snap[east span-45 text-08 text-white]
@box[bg-green text-white fragment](Less boilerplate for a self describing data.)
<br/>
@box[bg-orange text-white fragment](More errors detected later in development and in maintenance.)
<br/>
@box[bg-orange text-white fragment](Tends to prohibit compilation and yields poor performing code.)
@snapend

+++?image=presentations/types-and-variables/types-diagram.jpg&size=auto 90%
@title[Types]

+++
@title[Integers]

@snap[north]
Integers
@snapend

| Name | Width | Range |
| --- | --- | --- |
| long | 64 | -9 223 372 036 854 775 808 to +9 223 372 036 854 775 807 |
| int | 32 | -2 147 483 648 to +2 147 483 647 |
| short | 16 | -32 768 to +32 767 |
| byte | 8 | -128 to +127 |

@ul[list-bullets-black](false)
- The most commonly used integer type is *int*.
- If the integer values are larger than its feasible range, then an @css[text-orange](overflow) occurs.
@ulend

+++
@title[Floating point numbers]

@snap[north]
Floating point numbers
@snapend

| Name | Width | Approximate |
| --- | --- | --- |
| double | 64 | 4.9e-324 to 1.8e+308 |
| float | 32 | 1.4e-045 to 3.4e+038 |

@ul[list-bullets-black](false)
- Floats are used when evaluating expressions that require fractional precision.
- Be aware that floating-point arithmetic can only approximate real arithmetic. See [0.30000000000000004.com](https://0.30000000000000004.com).
@ulend

+++
@title[Boolean]

@snap[north]
Boolean
@snapend

@ul[list-bullets-black](false)
- The program is supposed to do decision making by itself.
- To do this, C# has the boolean-type flow controls (selections and iterations).
- This type has only two possible values, *true* and *false*.
@ulend

+++
@title[Char]

@snap[north]
Char
@snapend

@ul[list-bullets-black](false)
- A character stored by the machine is represented by a sequence of 0’s and 1’s.
- The char type is a 16-bit unsigned primitive data type.
- C# uses Unicode to represent characters. Unicode defines a fully international character set that can represent all of the characters found in all human languages.
@ulend

+++
@title[String]

@snap[north span-100]
*String* [[documentation](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)]
@snapend

@snap[midpoint]
@code[java zoom-10](presentations/types-and-variables/strings.cs)
@snapend

+++
@title[String concatenation]

@snap[north span-100]
String concatenation
@snapend

@snap[midpoint span-100]
@code[java zoom-10](presentations/types-and-variables/stringConcatenation.cs)
@snapend

+++
@title[String immutability]

@snap[north span-100]
String immutability
@snapend

@snap[midpoint span-100]
@code[java zoom-10](presentations/types-and-variables/stringImmutability.cs)
@snapend

@snap[midpoint span-100 text-12]
@box[bg-orange text-white fragment](Once created *String* cannot be changed)
<br/>
@box[bg-orange text-white fragment](If String method returns String - although it may look similar but it is a new object)
@snapend
