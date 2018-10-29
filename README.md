## Full Stack Project

### Welcome
Thanks for speaking with the team at StaffCircle, and agreeing to show us your awesome dev skills.

This project is a opportunity to show us your strengths and demonstrate what you feel you can bring to the team and product. 

The aim of this project is to help you demostrate your C\#, ASP.NET, front-end skills. If you are struggling on a particular area, try to move on and focus on the areas that will best demonstrate your abilities.

Rather than prescribe a list of tasks, we are keen to see how you approach a real world set of requirements. With this in mind the project has a set of documented requirements (detailed below) with some minor guidance around approach as we don't want this to take you all night.

Complete as many of the requirements as you can, and then we will review the code, giving you the opportunity to share your reasoning behind your implementation and for our team to share any feedback they have.

### Setup
1. [Visual Studio](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=15) or [Visual Code](https://code.visualstudio.com/docs?dv=win&wt.mc_id=DX_841432&sku=codewin)
2. [NodeJs](https://nodejs.org/en/)
3. [Twilio Account](https://www.twilio.com/try-twilio)

All resources required are available for free.

### Solution
1. Api Project
A dotnet core api project being used to host a restful api. To run the project, either click debug in Visual Studio or VS Code or run the following from the command line in the api directory: 
    ```
	dotnet restore
	dotnet run
	```
2. UI Website
A VueJs single page application (SPA) being used to host the user interface. To run the project, run the following commands from the command line in the ui directory:
    ```bash
	npm i
	npm run serve
	```
3. Api Test Project
A xUnit test project used to test the Api Project. To run the project, either use Visual Studio Test Explorer or run the following commands from the command line in the api.tests directory:
    ```
	dotnet restore
	dotnet test
	```
### Requirements
#### Background
StaffCircle focuses a large proportion of our efforts on engaging with users via their mobile devices. 
With the average person checking their phone between 50-75 times a day, it is a vital channel to better engagement with the workforce. 
SMS messaging is a extremely simple and effective method of providing our users with information and a key area of functionality for our platform.
We would like to provide our users with the ability to send a sms with their own content from our web application to a specific mobile number and view a list of sent messages.
We utilise Twilio to provide our messaging services and would like to use their services for this as well.

#### Stories
1. As a user I must be able to compose a sms message to a mobile number with some custom content.
2. As a user I must be able to send the composeed sms to the specified mobile number.
3. As a user I must be able to view a list of the sms messages sent so far.
4. As a user I should be able to filter list of the messages sent by date and time they were sent.
5. As a user I should only be able to send a message of no more than 160 characters.

#### Resources
We know there may be a few new bits of tech in here so here are a set of resources that should help you fulfill the users requirements.
1. [Twilio Send SMS](https://www.twilio.com/docs/sms/send-messages)
2. [Twilio Read All SMS](https://www.twilio.com/docs/sms/api/message#read-multiple-message-resources)
3. [VueJs](https://vuejs.org/)
4. [Vuetify](https://vuetifyjs.com/)
5. [dotnet Core Web Api](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-2.1)
6. [xUnit](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing?view=aspnetcore-2.1)
        
### Complete
When your complete bundle up your project and send it to our team.
1. Commit all changes locally
2. Bundle up your repository using the following command:
    ```bash
    git bundle create full-stack-project.bundle --all
    ```
3. Upload the file you just created **"full-stack-project.bundle"** to a file sharing provider
4. Finally, email our team the download link: devrecruitment@staffcircle.com
 
