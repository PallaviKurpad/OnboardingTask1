Feature: Languages

A short summary of the feature

Background: Pre-condition
	Given I am on the Profile page
	And I am under the tab Languages

@tag5
Scenario: Add Language
	
	When I click on Add New button
	And I enter "<Language>" in the Language text field
	And I select "<Level>" in the Level select field
	And I click on Add button
	Then "<Language>" and "<Level>" should be dispalyed as a record under the Language tab
	And A popup with message ' "<Language>" has been added to your languages' should appear at the top right corner of the page

Examples: 
| Language | Level          | New language | New level        |
| English  | Fluent         | French       | Basic            |
| Hindi    | Conversational | Telugu       | Native/Bilingual |
| French   | Basic          | Spanish      | Conversational   |

@tag6
Scenario: Make Language editable
	Given I see the record with "<Language>" displayed
	When I click on the Pencil icon for that record
	Then The fields with values "<Language>" and "<Level>" should become editable

Examples: 
| Language | Level          | New language | New level        |
| English  | Fluent         | French       | Basic            |
| Hindi    | Conversational | Telugu       | Native/Bilingual |
| French   | Basic          | Spanish      | Conversational   |

@tag7
Scenario: Save updated Language
	Given I see the record "<Language>" in editable mode
	When I change "<Language>" to "<New language>"
	And I change "<Level>" to "<New level>"
	And I click on Update button
	Then The record should be updated with "<New language>" and "<New level>"
	And A popup with message ' "<New language>" has been updated to your languages" should appear at the top right corner of the page

Examples: 
| Language | Level          | New language | New level        |
| English  | Fluent         | French       | Basic            |
| Hindi    | Conversational | Telugu       | Native/Bilingual |
| French   | Basic          | Spanish      | Conversational   |

@tag8
Scenario: Delete Language
	Given I see the record with "<New language>" as Language displayed
	When I click on x icon for that record
	Then The record with values "<New language>" and "<New Level>" should disappear
	And A popup with message ' "<New language>" is deleted from your languages' should appear at the top right corner of the page


Examples: 
| Language | Level          | New language | New level        |
| English  | Fluent         | French       | Basic            |
| Hindi    | Conversational | Telugu       | Native/Bilingual |
| French   | Basic          | Spanish      | Conversational   |