Self-Assessment: Onion Architecture, MVC, and Web API (.NET Core) with Bottlenecks (Encountered)

Conceptual Understanding: 
1. Onion Architecture: (Yes/No) 
Have you heard of the Onion Architecture principle in software design?
Answer: Yes
 
3. MVC Pattern: (Yes/No) 
Are you familiar with the Model-View-Controller (MVC) pattern for building web applications?
Answer: Yes
 
4. Web API: (Yes/No) 
Do you understand the concept of building RESTful APIs using ASP.NET Core Web API?
Answer: No


Application & Bottlenecks:
Onion Architecture:
1. Benefits: (1-3 keywords)
Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability)
Answer: Flexibility, Maintainability, Modularity and Extensibility
 
2. Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s). (e.g., Increased complexity for simple projects, difficulty finding developers familiar with the pattern) 
Answer: Yes, it was challenging for me especially that I am a beginner and unfamiliar with software design patters. I encountered many complications during the process of development because of improper implementation. I also encountered hardships in setting up the architecture initially.


MVC:
1. Components: (1-3 keywords each)
Briefly describe the roles of the Model, View, and Controller in the MVC pattern.
Answer: The Model manages the data or information of the application. The View displays the data that can be visible to the users. The Controller receives user input from the view or process user input and interacting with the model.


2. Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s). (e.g., Difficulty in unit testing controllers, logic changes rippling through the application)
Answer: Yes, when changing the model logic because it hinders the testing and changes to the model that often necessitate changes in the controller.

 
Web API:
1. Differences from MVC: (Yes/No and Briefly Explain)
Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.
Answer: The traditional MVC applications is designed to build a web applications with both user interface and data processing cabpabilities while Web APIs is focused solely on data exchange and do not directly render user interfaces.

2. Bottlenecks (Encountered): (Yes/No and Briefly Explain) 
Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If so, briefly describe the scenario(s). (e.g., Frequent page refreshes causing performance overhead, complex data exchange requiring a more lightweight approach)
Answer: No, because I am more familiar with the MVC application but I still encountered challenges in it like scaling to handle large numbers of concurrent users.
