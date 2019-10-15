# Design-by-Contract

<h2>**Introduction**</h2>

Consider an Account class. It should have two methods:

- Deposit(double amount) which should increase the account’s balance
with the amount, the amount should always be positive

- Withdraw(double amount) which on the other hand should decrease the
account’s balance. 

Also this amount should be positive. If the amount
exceeds the balance, the balance should be left untouched and an exception
should be thrown.

<h2>Assignment</h2>
Create a C# class that implements the behaviour mentioned in 1 Introduction.
Use Code Contracts to enforce Design by ContractTM principles. Also create a
small program, that uses the account class.
The report should besides from a git url to the project include a short textual
description on how the code contract should be interpreted.
Hand in
A link to the github repository including a short textual description on how the
code contract should be interpreted (README.md). In groups on peergrade
by TBD

**Install guide**

- Download Visuel studio 15 (requried 2017/2019 does not support code contracts)
- Download project.
- Open project with visuel studio 15.

**Run program**

1. Look in Account class and see how code contact is implemented.

2. in the class, program, outcomment the example you would like to se run and run it.
have fun :)
