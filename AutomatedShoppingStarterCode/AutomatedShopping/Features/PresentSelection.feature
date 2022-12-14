Feature: PresentSelection

As an elf, I want to be able to pick out a present for each Spartan, 
so that they can be wrapped and delivered

@userjourney
Scenario: Pick out presents
	Given that I have signed in to the saucedemo site
    When I select a random present
	And I click on the shopping cart
	Then I will be on the cart page
	When I click on the checkout button
	Then I will be on the checkout step one page
	When I fill in the first name <firstName>
	And I fill in the second name <secondName>
	And I fill in the city <city>
	And I click the continue button
	Then I will be on the checkout step two page
	When I click the finish button
	Then I will be on the checkout complete page
	Examples: 
	| firstName | secondName | city       |
	| Brenda    | Maddox     | Birmingham |
	| Leyla     | Levy       | Bristol    |
	| Eliezer   | Burnett    | Birmingham |




