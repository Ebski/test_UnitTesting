# test_UnitTesting

## UNIT TESTS BASED ON EQUIVALENCE PARTITIONING AND BOUNDARY VALUE ANALYSIS 
The program can be found [here](https://github.com/Ebski/test_UnitTesting/blob/master/TestHandin2/TestHandin2/DaysInMonth.cs)

The tests can be found [here](https://github.com/Ebski/test_UnitTesting/blob/master/TestHandin2/TestHandin2Tests/DaysInMonthTests.cs)

## UNIT TESTS BASED ON DECISION TABLES 
The program can be found [here](https://github.com/Ebski/test_UnitTesting/blob/master/TestHandin2/TestHandin2/Reimbursement.cs)

The tests can be found [here](https://github.com/Ebski/test_UnitTesting/blob/master/TestHandin2/TestHandin2Tests/ReimbursementTests.cs)

## CODE COVERAGE
I'm using the triangle program we made earlier in the test course. The project can be found [here](https://github.com/Ebski/Test_Triangles)

### 1. How much of the code is covered by test cases to start out?
70%

![alt tag](http://i67.tinypic.com/vwx1dc.png)

### 2. Could and should the code coverage of your project be raised?
The Code covarage could be increased. Right now there is no tests for the chooseInputs method. Its also possible to make tests on the program class which runs the program, but as it only uses methods from the GenerateTriangle class which is already tested it doesn't really need to be tested

### 3. How?
By creating tests for the chooseInputs method. What makes that hard is that the method waits for inputs from the user so that would have to be mocked up somehow.
