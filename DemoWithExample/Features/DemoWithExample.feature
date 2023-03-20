Feature: DemoWithExample

As a user i want to be able to register on website
and benefit from it

@tag1
Scenario Outline: Valid Registration
	Given I navigate to website "https://demo.automationtesting.in/Register.html"
	And I enter First Name "<firstname>"
	And I enter Last Name "<lastname>"
	And I enter Address "<address>"
	And I enter Email Address "<email>" 
	And I enter Phone Number "<phonenumber>"
	And I select my Gender
	And I select my Hobbies
	And I select my languages
	And I select my Skills
	And I select my Country
	And I select my Date of Birth
	And I enter my Password "<password>"
	And I enter my Confirm Password "<confirmpassword>"
	When I click on the Submit Button
	#Then I should be able to Register Succesfully

	Examples: 
	| firstname | lastname | address     | email               | phonenumber | password   | confirmpassword |
	| Tai       | Victor   | 13 gecko st | loedhso90@yahoo.com | 830489022   | Passsecure | Passsecure      |