Feature: Certifications

As a Seller
I want to create and update Certifications on my Profile page
So that the people seeking for some skills can look into my certification details


Scenario: Add Certification
	Given I am on the Profile page
	When I go to the tab Certifications
	And I add a new Certification record
	Then The record should be created successfully


Scenario Outline: Edit existing Certification record
	Given I am on the Profile page
	When I go to the tab Certifications
	And I update '<Certified From>' on an existing Certifications record
	Then The record should have the updated '<Certified From>'

Examples: 
| Certified From |
| Wertu          |
| Nebula         |


@tag4
Scenario: Delete Certification
	Given I am on the Profile page
	When I go to the tab Certifications
	And I delete an existing Certification record
	Then The record should be deleted successfully
