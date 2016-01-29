Feature: LoginVK

Background: 
	Given user opens vk start page 

Scenario: login to vk with correct credentials	
	And email field is filled in with 'bratsun@rambler.ru' 
	And password field is filled in with 'siemenssk65' 
	When sign in button is clicked 
	Then user loged in 
	And url contains account id '18744588'
	And close browser window

Scenario: login to vk with incorrect credentials
	And email field is filled in with 'bratsun@rambler.ru' 
	And password field is filled in with 'password' 
	When sign in button is clicked 
	Then the 'Не удается войти.' text is displayed
	And close browser window

Scenario: try click messages link 
	And user opens messages link

#Scenario Outline: Click over the left bar menus
#Given user opens vk start page
#When user opens <leftBarTab>
#Then the page contains <tabName>
#
#Examples: 
#	| leftBarTab | tabName             |
#	| My Page    | Smile Станиславович |
#	| My Friends | Все друзья          |
