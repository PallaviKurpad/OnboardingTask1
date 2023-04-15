Feature: Certifications

A short summary of the feature

Background: Pre-condition
	Given I am on the Profile page
	And I am under the tab Certifications

@tag1
Scenario: Add Certification
	
	When I click on Add New button
	And I enter SSDD in the Certificate text field
	And I enter Wert in the Certified From text field
	And I select 2020 in the Year select field
	And I click on Add button
	Then the record should be displayed under the Certifications tab
	And A popup with message "SSDD has been added to your Certification" should appear at the top right corner of the page

@tag2
Scenario: Make Certification editable
	Given I see the record with SSDD as Certificate displayed
	When I click on the Pencil icon for that record
	Then All fields for that record should become editable

@tag3
Scenario: Save updated Certification
	Given I see the record with SSDD as Certificate in editable mode
	When I change Wert to Wertu in Certified From field
	And I click on Update button
	Then The same record should be updated with new values
	And A popup with message "SSDD has been updated to your Certification" should appear at the top right corner of the page

@tag4
Scenario: Delete Certification
	Given I see the record with SSDD as Certificate displayed
	When I click on x icon for that record
	Then The record should disappear
	And A popup with message "SSDD has been deleted from your Certification" should appear at the top right corner of the page
