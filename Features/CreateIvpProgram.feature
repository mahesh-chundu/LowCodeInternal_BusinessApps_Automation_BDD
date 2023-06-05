Feature: CreateIvpProgram

Create a new IVP program

@CreateProgram
Scenario: Create New IVP Program
	Given Navigate to the IVP Dashboard Page
	When Click On Add New Program Button
	Then Create a New Program and Save
@AddNotes
Scenario: Search a program in Dashboard and add notes
	Given Navigate to Dashboard Page
	When Search for a program
	Then Add notes to that program
