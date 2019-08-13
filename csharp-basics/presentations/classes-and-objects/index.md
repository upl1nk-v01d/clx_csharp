---?color=linear-gradient(to right, #4caf50, #dbff3d) @title[Classes and objects]

@snap[midpoint announce-section-title text-white span-100] Classes and Objects @snapend

+++ @title[Lesson objective]

@snap After this lesson you will know: @snapend <br/> @ullist-bullets-black - What is a Class - What is an Object - What is a Method - What is an instance - What is static - What is a constructor @ulend

+++ @title[What is a Class?]

@snap[north span-100] What is a Class? @snapend

@snap[midpoint]
    A class, in the context of C#, are templates that are used to create objects. 
@snapend

+++ @title[What is an Object?]

@snap[north span-100] What is an Object? @snapend

@snap[span-100]
Object refers to a particular instance of a class, where the object can be a combination of variables, functions, and data structures.
In C# object is a direct or indirect base of every data type
@snapend

+++?image=presentation/classes-and-objects/class-object.png&size=auto 40% @title[Class and object example]

+++ @title[What is a Method?]

@snap[north span-100] What is a Method? @snapend

@snap
 A C# method is a collection of instructions that are grouped together to perform an operation. 
 @snapend

+++?color=#1E1F21 @title[Class]

@snap[midpoint] @codejava zoom-10 @snapend

+++ @title[Constructor]

@snap[span-100] C# allows two types of constructors: @snapend <br/> @ullist-bullets-black - No argument Constructors - Parameterized Constructors @ulend

+++?color=#1E1F21 @title[Class instance]

@snap[midpoint] @codejava zoom-10 @snapend

+++ @title[static]

@snap[north span-100] static @snapend

@ullist-bullets-black - applies to fields and methods - means that field/method - is @csstext-orange - is @csstext-orange unique @ulend

+++?color=#1E1F21 @title[Example]

@snap[midpoint] @codejava zoom-10 @snapend

+++?color=#1E1F21 @title[Example]

@snap[midpoint] @codejava zoom-10 @snapend

+++ @title[Static variable initialization]

@snap[north span-100] Static variable are initialized @snapend

@ollist-bullets-black - When class is loaded - Before any object of that class is created. - Before any static method of the class executes. @olend

+++ @title[this keyword]

@snap[north span-100] this keyword @snapend

@ullist-bullets-black - can be used inside a constructor or @csstext-orange - this works as a reference to the current Object, whose Method or constructor is being invoked @ulend

+++?color=#1E1F21 @title[Example]

@snap[midpoint] @codejava zoom-10 @snapend

+++ @title[this & static]

@snap[north span-100] this & static @snapend

@snap[midpoint span-100 text-20] @boxbg-orange text-white fragment @snapend

+++ @title[When to use static?]

@snap[north span-100] When to use static? @snapend

@snap One rule-of-thumb: ask yourself does it make sense to call this method, even if no Object has been constructed yet? If so, it should definitely be static. @snapend

+++ @title[When to use static data?]

@snap[north span-100] When to use static data? @snapend

@snap[midpoint span-100] @codejava zoom-10 @snapend

+++ @title[When to use static methods?]

@snap[north span-100] When to use static methods? @snapend

@snap[midpoint span-100] @codejava zoom-10 @snapend

+++?color=linear-gradient(to top, #ffb347, #ffcc33) @title[Quiz]

@snap[midpoint announce-quiz text-white] QUIZ @snapend

+++ @title[Question #1]

@snap[midpoint span-100] @codejava zoom-10 @snapend

+++ @title[Question #2]

@snap Which statements are false? @snapend <br/> @ollist-bullets-black - class is like a blueprint, but instance is an object based on this blueprint - instance is like a blueprint, but class is an object based on this blueprint - instance variables can be accessed from a static context - class variables can be accessed from an instance context @olend

+++ @title[Question #3]

@snap Which of these applies to static? @snapend <br/> @ollist-bullets-black - is unique for each instance - it not unique for each instance - this is accessible in a static context - this is not accessible in a static context - once static field is changed all instances see the change - once static field is changed only current instance see the change @olend

+++ @title[Question #4]

@snap[midpoint span-100] @codejava zoom-10 @snapend

+++ @title[Must read]

@snap[span-100 text-center] Head First Java @snapend @ullist-bullets-black span-100 - A Trip to Objectville [Chapter 2] - How Objects Behave [Chapter 4] - Life and Death of an Object [Chapter 9] @ulend

<br/>

@snap[span-100 text-center] Java for beginners @snapend @ullist-bullets-black span-100 - Classes & Methods [72 - 94] @ulend

<br/>

@snap[span-100 text-center] Java SE 8 Certification Guide @snapend @ullist-bullets-black span-100 - Methods and encapsulation [147 - 212] @ulend

+++ @title[Further reading]

@snap Further reading and tutorials: @snapend <br/> @ullist-bullets-black - Using the this keyword @docs.oracle - this keyword @javabeginnerstutorial - static keyword @stackoverflow - class vs object vs instance @alfredjava - Constructors @docs.oracle - Why static may be evil? @stackoverflow.com @ulend