Feature: Skills

A short summary of the feature

Background: Pre-condition
	Given I am on the Profile page
	And I am under the tab Skills

@tag9
Scenario: Add Skill
	When I click on Add New button
	And I enter Gardening in the Skill text field
	And I select Beginner in the Level select field
	And I click on Add button
	Then Gardening and Beginner should be dispalyed as a record under the Skills tab
	And A popup with message "Gardening has been added to your skills" should appear at the top right corner of the page

@tag10
Scenario: Make Skill editable
	Given I see the record with Gardening as Skill displayed
	When I click on the Pencil icon for that record
	Then The fields Skill and Level with values Gardening and Beginner should become editable

@tag11
Scenario: Save updated Skill
	Given I see the record with Gardening as Skill in editable mode
	When I change Gardening to Cooking in Skill field
	And I change Beginner to Expert in Level field
	And I click on Update button
	Then The same record should display Cooking and Expert as values
	And A popup with message "Cooking has been updated to your skills" should appear at the top right corner of the page

@tag12
Scenario: Delete Skill
	Given I see the record with Cooking as Skill displayed
	When I click on x icon for that record
	Then The record with values Cooking and Expert should disappear
	And A popup with message "Cooking is deleted from your skills" should appear at the top right corner of the page
