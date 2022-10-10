Feature: PlanAJourney
Plan a journey feature of TFL Applcation.

# When no locations are entered.
Background: 
	Given User navigated to the TFL home page.
	And User is able to view the Plan a journey widget
#testcase1
Scenario: Verifying no location plan
	Given User is in TFL homepage
	And User is able to view from and to search fields
	And User is able to view Planajourney button
	When User Clicks on Planmyjourneybutton
	Then MandatoryUser message should be displayed.

#When Valid locations are entered.
Scenario Outline: Journey planner for valid locations.
	Given User is in TFL homepage
	And User selects the <From location>
	And User select the <To location>
	When User Clicks on Planmyjourneybutton
	Then User should be navigated to the Journey result page
	And user should be able to view the various transport options.
Examples:
	| From location | To location |
	| Piccadilly Circus             | Wembley Central            |
	| Sudbury Town Underground Station           | North Acton Underground Station            |


#Edit option in journey result page
Scenario Outline: Edit journey option in Journey result page
	Given User selects the from location as "Piccadilly Circus"
	And User selects the To location as "Sudbury Town Underground Station"
	And User clicks on Planmyjourner button
	And User is navigated to the Journey result page
	And User should be able to view the various transport options.
	Then Edit Journey link should be available.
	When User clicks on Edit journey link
	Then User should be navigated to Edit journey panel.
	When User selects the <from location> 
	And User selects the <to location>
	And User clicks on Update Journeybutton
	Then User Should be able to view journey result based on updated journey option.
Examples:
	| from location                    | to location                      |
	| Sudbury Hill Harrow Rail Station | 0                                |
	| Sudbury Hill Harrow Rail Station | Sudbury Hill Harrow Rail Station |


#Invalid journey planner
Scenario: Journey planner when invalid locations are entered.
	Given User selects the from location as "XXXSXXXXXXX"
	And User selects the To location as "WQWQWQQQQQQQQ"
	When User Clicks on Planmyjourneybutton
	Then User should be navigated to the Journey result page
	And user should be able to invaliderror message


#Recent journey 
Scenario: User should be able to view the recent journey search.
	Given User clicks on recents tab.
	Then User should be able to view the recent search journeys.


