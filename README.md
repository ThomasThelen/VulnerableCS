# VulnerableCS
A collection of proof-of-concept exploitable applications in C#

SQL Injections

1. SimpleSqlInjection
<br>
  An application that connects to a MySQL database and checks if the username and password supplied by the user is valid. Can be exploited by essentially any injection vector.
2. HexEncodedInjection
<br>
  An application that filters regular ascii however, fails to consider injections coded in hex.
  
Buffer Overflow

1. SimpleOverflow
<br>
  Demonstrates the rare case where a C# application is vulnerable to a buffer overflow. A couple of conditions must be met inorder to perform a buffer overflow. This is due to CRL's garbage colelction! It is well knownthat c# creates space on the heap instead of the stack. In order to order to force CRL to create the variable on the stack, 


stackalloc

must be used in the variable's definition. BEcause this is considered unsafe, you must first allow unsafe code in the project settings. The metod must also be declared unsafe.

Before entering the loop, the memory location of the variable "number" is displayed...

![](http://imgur.com/pCu8tFD.jpg)


After running through the loop a single time, the memory looks like.

![](http://imgur.com/MW7SrMQ.jpg)

Running through a second time displays a memory profile of
![](http://imgur.com/8Q57e5k.jpg)

Note that the end of allocated memory has been reached. Any further addition will overrun the stack and cause a segmentation fault.

![](http://imgur.com/sDZwBdR.jpg)


  
