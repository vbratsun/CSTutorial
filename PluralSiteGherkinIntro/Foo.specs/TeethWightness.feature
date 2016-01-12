Feature: TeethWightness
	
Scenario Outline: Teeth whiteness
Given I'm using "<brand>" brand toothpaste
When i brush  for <mins> minutes
Then the teeth look <percent> white

Examples: 
	| brand  | mins | percent |
	| brand1 | 1    | 80      |
	| brand2 | 3    | 100     |
	| brand3 | 10   | 50      |
