Feature: UnregisteredVehiclePermit

Background: User navigates to Unregistered Vehicle Permit URL
	Given User navigates to Unregistered Vehicle Permit URL

@Step2Verification
Scenario Outline: Enter vehicle permit details
	Then 'Step 1 of 7 : Calculate fee' step is displayed
	When User enters the mandatory details <VehicleType>, <SubTypeOrCapacity>, <Address>, <PermitStartDate> and <PermitDurationInDays> in Step 1 of 7: Calculate Fee
	And User Clicks on Calculate
	And  Clicks on Next
	Then  'Step 2 of 7 : Select permit type' step is displayed

	Examples:
	| VehicleType			| SubTypeOrCapacity										| Address                                       | PermitStartDate	| PermitDurationInDays	|
	| PassengerVehicle		| Sedan													| Unit 711 Sample Street Broadmeadows VIC 3047	| 05/10/2021		| 18					|


	| PassengerVehicle		| StationWagon											| 12 Test Street Docklands VIC 3008				| 01/09/2021		| 28					|
	| PassengerVehicle		| Coupe													| VIC 3000										| 01/02/2022		| 6						|
	| PassengerVehicle		| Roadster												| Melbourne VIC 3000							| 01/09/2021		| 3						|
	| PassengerVehicle		| SelfPropelledCaravan									| Unit 7 11 Sample Street Broadmeadows VIC 3047	| 01/09/2021		| 2						|
	| PassengerVehicle		| BusOrVanSeatingUpToNine								| 12 Test Street Docklands VIC 3008				| 29/09/2021		| 10					|
	| PassengerVehicle		| BusOrVanSeatingTenOrMore								| VIC 3003										| 11/11/2021		| 1						|
	| PrimeMover			|														| 12 Test Street Docklands VIC 3008				| 02/09/2021		| 14					|
	| Trailer				| 														| VIC 3004										| 07/09/2021		| 5						|
