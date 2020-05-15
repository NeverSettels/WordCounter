# _Scrabble_

#### _Epicodus Project May 14, 2020_

#### By _**Eric Settels**_

## Description

_A project to introduce the C# language and the .NET Core framework. The console application will act as Word finder retrung how many times a given word appears in the text. The progream is meant to practice creating automated testing methods using MSTest and behavior driven development._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the command dotnet run.

## Known Bugs

There are no known bugs at the time of this update.

## Technologies Used

* C#
* .NET Core
* Git and GitHub

## Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User enters a word and program verifies that there are no special charcters** | User Input: ”dog” | Output: True|
| **User enters a sentence program verfies that is longer than 1 word** | User Input: ”dogs are great companions” | Output: True |
| **Program takes user input and fliter out special characters** | User Input: ”dogs, are great. companions!” | Output: ”dogs are great companions” |
| **Program takes user word and count them in the updated sentence!** | User Input: "dogs", ”dogs, are great. companions! and dogs make me happy” | Output: "2”  |
| **Program takes user word and count them in the updated sentence and prints what percentage of that sentence is that word** | User Input: "dogs", ”dogs, are great. companions! and dogs make me happy” | Output: "dogs appears 2 times and makes up 22.22% of the total sentence"|

## License
This software is licensed under the MIT license.

Copyright (c) 2020 **_Eric Settels_**
