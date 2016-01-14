Feature: LoginVK

Scenario: login to vk with correct credentials
	Given user opens vk start page 
	And email field is filled in with 'bratsun@rambler.ru' 
	And password field is filled in with 'siemenssk65' 
	When sign in button is clicked 
	Then user loged in 
	And url contains account id '18744588'
	And close browser window

Scenario: login to vk with incorrect credentials
	Given user opens vk start page 
	And email field is filled in with 'bratsun@rambler.ru' 
	And password field is filled in with 'password' 
	When sign in button is clicked 
	Then the 'Не удается войти.' text is displayed
	And close browser window