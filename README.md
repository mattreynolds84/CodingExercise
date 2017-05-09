# CodingExercise
Note the two objects defined 'Person.cs' and the enum for 'Gender'. There is also a service mocked up to serv up data called PersonService.cs. All api calls should go through the ValuesController.

1. Get the app to run. :)

2. Create a static extension method for the type 'Person' that will set the gender based on the following logic:
  A. If the Id property equals 0 or 20 then the gender type should be 'Unknown'.
  B. If the Id property is an even number the gender type should be 'Female'.
  C. If the Id property is an odd number the gender type should be 'Male'.
  
3. Ensure that the GetAllPeople() method returns only 20 results and at least one result has the gender type 'Unknown'. 

4. Create an api call that returns only persons who are either the age of 10 or at least 20 by adding a new service call to the PersonService.
