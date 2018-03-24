READ ME FILE FOR THE TWO APLLICATIONS



They are two C# applications.

1, Its a calculator that simply adds,subtracts and multiplys.
   There are no number pads, u can change the numbers, found
   in "testForm.cs" file, by changing the arguments of the
   object being created.
   I am using a command design pattern.
   
   Command design - talks about encapsulating all the requests
   coming from the invoker in Objects, pass then to the 
   reciever and let the reciever take the actions.It 
   encapsulates a request as an object, thereby letting you
   parameterize clients with different requests, queue or log
   requests, and support undoable operations.

   Command pattern is usually used to decrease the coupling
   between sender and receiver.

   
   Command Pattern in its design has five main parts 
   
   Command: This is an interface for executing an action

   ConcreteCommand: This object specifies the binding between
                   a Receiver/action taker and an action 
		   invoker. This object is responsible for 
                   executing corresponding operationon 
                   Receiver.

   Client: creates a ConcreteCommand object and sets its 
           receiver.

   Invoker: It will use Command object to carry out the 
            request.

   Receiver: It contains the real operational logic that 
             need to be performed on the data. 


   The most important thing to remember while implementing 
   the command pattern is that the Command is just a link 
   between sender and reciever. It should only tell the 
   reciever what the sender is expecting. It should never 
   alter the logic of sender and reciever in any way. 

   Explanation 
	
   ACommand.cs - an interface for execution of commands.

   Calculator.cs - the actions are defined in.

   Commands.cs - classes that will inherit the ACommand class
		 (Concrete command).

   IReceiver.cs - an interface to represent the 
		  major functionalities of the reciever.

   Calculator.cs - implementation of the reciever class.

   testForm.cs - class which executes the client,its UI
		 (invoker).

   References Internet,Forms in c#.
   Use - To see how to do the radio buttons and how to bind
	 the actions needed to each single button.


2,Its a simple csharp console application that displays a
  car's name nd its color by your input. This simple application
  is done by an MVC pattern.

  Model - represents an object carrying data.
  View - represents the visualization of the data the model 
	 contains.
  Controller - controls the data flow into model object and
	       updatesthe view whenever data changes.

  References SE Bookj
  Use - Know more about MVC

	
				  Name	Yohannes Fassil 
				  ID	ATR/4122/08
				  Date  3/23/2018	 