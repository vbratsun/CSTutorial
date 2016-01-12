Feature: Brushing Of Teeth

Scenario: Sucsessfull brushing 
Given there is 1 gram of brand 'X' toothpaste on the brush 
And the mouth is open 
When the back teeth are brushed 
And the front teeth are brushed 
Then the teeth look clean 
And the mouth feels fresh 
But the braces aren't damaged

Scenario: Sucsessfull brushing with tools 
Given i have the following tools:
	| ToolName | ToolQuality |
	| paste    | medium      |
	| water    | low         |
	| brush    | high        |
And the mouth is open 
When the back teeth are brushed 
And the front teeth are brushed 
Then the teeth look clean 
And the mouth feels fresh 
But the braces aren't damaged