## Independent Project - Bakery Project - C#/.Net Console Application - Week 8

C# & .NET program that allows the user to order Bread/Pastries from Pierre's Bakery. The program will prompt the user for how many loaves of bread, and how many pastries they would like to buy. Then, the program takes those 2 inputs and calculates the order total for the customer - including Buy Two Get One Free discounts.

By Austin Schrader

## Description

This project was created by Austin Schrader for the week 8 of independent project using C# and uses C#/.NET. The objective was to build a console bakery console application.

## Setup

_C# and .NET needs to be installed for this project to work. If you do not have it, please go to [here for Windows](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) and [here for MacOS](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer)._

1. Download this repository by clicking the "Clone or Download" button
2. Navigate to the folder where it downloaded
3. Now open your terminal and navigate to Bakery.Solution > Bakery.Tests
4. Type in `dotnet restore` to download necessary packages
5. Then type in `dotnet run` to run the application
6. Congratulations, this is the program!
7. To get an output, enter 3 values one-at-a-time

## Specs

Describe: PastryOrderCalc()

Test: "should correctly output the total for the cost of the pastries that the customer has ordered"
Expect: (newPastry.PastryOrderCalc(3).toEqual(5));

Describe: BreadOrderCalc()

Test: "should correctly output the total for the cost of the bread that the customer has ordered"
Expect: (newPastry.BreadOrderCalc(3).toEqual(15));

## Known Bugs

At this time, there are no known bugs. If you see spot a bug feel free to make a pull request.

## Technologies Used

- C#
- .NET
- Object Oriented Programming
- MSTest

## License

This repository is licensed under the MIT license.

Copyright (c) 2020 by _Austin Schrader_
