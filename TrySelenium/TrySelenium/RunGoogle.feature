Feature: RunGoogle

Scenario: open google page
	Given open the google web site
	When the text 'cheers' is typed in search box
	And search button is clicked
	Then opened page contains 'About 191,000,000 results' text