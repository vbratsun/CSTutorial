Feature: LoginVK

Scenario: login to vk
	Given user opens vk start page 
	And email field is filled in with 'brasun@rambler.ru' 
	And password field is filled in with 'siemenssk65' 
	When sign in button is clicked 
	Then user loged in 
	And url contains account id '18744588'