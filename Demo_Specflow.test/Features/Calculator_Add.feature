Feature: Calculator_Add
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add two numbers
	Given I have entered 50 and 70 into the calculator
	Then the result should be 120
