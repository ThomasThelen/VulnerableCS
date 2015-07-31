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
  Demonstrates the rare case where a C# application is vulnerable to a buffer overflow. The overflow exists in the username field.
  
