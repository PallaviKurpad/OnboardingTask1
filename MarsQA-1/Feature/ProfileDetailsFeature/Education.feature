Feature: Education

A short summary of the feature

Background: Pre-condition
	Given I am on the Profile page
	And I am under the tab Education

@tag13
Scenario: Add Education
	
	When I click on Add New button
	And I enter AIT in the Education text field
	And I select India in the Country of College/University select field
	And I select B.Tech in the Title select field
	And I enter Bachelor in the Degree text field
	And I select 2007 in the Year of Graduation select field
	And I click on Add button
	Then the record should be displayed under the Educaion tab
	And A popup with message "Education has been added" should appear at the top right corner of the page

@tag14
Scenario: Make Education editable
	Given I see the record with AIT as Education displayed
	When I click on the Pencil icon for that record
	Then All fields for that record should become editable

@tag15
Scenario: Save updated Education
	Given I see the record with AIT as Education in editable mode
	When I change AIT to BHU in Education field
	And I change B.Tech to M.Tech in Title field
	And I click on Update button
	Then The same record should be updated with new values
	And A popup with message "Education has been updated" should appear at the top right corner of the page

@tag16
Scenario: Delete Education
	Given I see the record with BHU as Education displayed
	When I click on x icon for that record
	Then The record should disappear
	And A popup with message "Education entry successfully removed" should appear at the top right corner of the page
