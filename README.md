----------- CORE
Core will run under visual studio as default on http://localhost:49904
 	
	- Swagger for api calls http://localhost:49904/swagger
	- Must be running for angular to make its calls to.

---------- ANGULAR
The angular project is run separately I'd recommend using visual studio code as your dev environment. https://code.visualstudio.com/

	- You will also need the angular cli https://github.com/angular/angular-cli
    - I’d also recommend YARN https://yarnpkg.com/en/

	- “yarn start” or “npm start” will then run the angular project.
    - Check out the RestService and app.component to see how calls are made to the core service.







