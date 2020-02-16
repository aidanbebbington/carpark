# Back End

This solution provides all the pricing calculation functionality as requested by the spec, but some more time would be required to make it production ready.

I've opted to create an .NET Core Web API because I was hoping to build an Angular front end (more on that below).  The quickest way to manually test the project is through Swagger UI.

## System Requiremnts

* Visual Studio 2019
* .NET Core 3.1

## Getting Started

* Open & build Carpark.sln
* Run Web project with IIS Express
* You should now see the main Swagger UI page for the project in your defualt browser
* If not, open a browser and navigate to http://localhost:5000/swagger/index.html

## Assumptions

* All dates & times are in local time (of the carpark)
* Early Bird only applies if entry and exit occur on the same day
* "midnight on Friday" actually refers to 00:00 on Saturday morning
* If multiple rates are applicable the cheapest should apply

## Potential Improvements

* Extract pricing rate constants to configuration or a database to allow them to be updated and vary by environment or parking provider
* Add view / presentation models and data models.  The project currently has just one layer of models, which are essentially the domain models, since no presentation or data storage is required.
* If timezone support is required use a library such as Nodatime to simplify conversion
* Could extract extensions such as DateTimeExtensions to a shared Nuget, or potentially find another library if it more complex operations are required

---

# Front End

| WARNING: This project is non-functional right now! |
| --- |

It's my first attempt to begin an Angular project, and there's a several steps I've not yet found the time to complete.  I only include it here to potentially provide further discussion about Angular, and hopefully demonstrate that with a little more time I would be able to get it working.

## Completed Tasks

* Create a new Angular project using Angular CLI to setup testing, routing, SASS, linting and other commond dependencies
* Create an Angular component & service to represent the pricing calculator
* Create a form using Angular Bootstrap with data binding to allow the user to input their entry and exit date & times
* Use Angular's HttpClient to make a web request when the user clicks Calculate

## Incomplete Tasks

* Pass data from the data-bound model to the web request for pricing calculation
* Populate data-bound model with response pricing calculation request
* Present pricing calculation response to the user
* Styling

## System Requirements

* Node.js & NPM
* Angular CLI

## Getting Started

* Open a Powershell window within the "UI" directory
* Execute npm install
* Execute ng serve
* Navigate in a web browser to http://localhost:4200/