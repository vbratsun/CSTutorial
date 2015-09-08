Feature: AddCustomer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: HappyPath
Given a user has entered information about a customer
And she has provided a first name and a last name as required
When she completes entering more information
Then that customer should be stored in the system

Scenario: Missing Required Data
Given a user has entered information about a customer
And she has not provided the first name and last name
When she completes entering more information
Then that user will be notified about the missing data
And the customer will not be stored into the system