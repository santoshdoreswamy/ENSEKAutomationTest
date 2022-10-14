Feature: WebPage Login
	Login to Application WebPage

@smoke
Scenario: Perform WebPage Login operation

	Given I launch the WebPage URL
	Then I should see Find Out More option


Scenario: Verify About Us Page

	Given I launch the WebPage URL
	And I click on the About Link
	And I click on Learn More Button
	Then I should see Our purpose is to accelerate