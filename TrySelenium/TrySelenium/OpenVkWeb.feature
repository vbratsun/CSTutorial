Feature: OpenVkWeb
	
Scenario: Send greeting to friend
	Given user opens messages section on VK website
	And user brings up the dialog with friend
	When some text 'Hello my friend' is typed in  
	And Send button is clicked
	Then message is displayed in message section
