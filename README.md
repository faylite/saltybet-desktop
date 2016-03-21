# Saltybet Desktop Application
This is an application that saves match data from [SaltyBet](http://www.saltybet.com/)
I have planned automatic betting, etc at a later stage. Currently it only stores the match data in a database in your My Documents folder.

The application uses the Chromium Embedded Framework to keep a browser window open in the background and interacts with the JavaScript from C#. This is what I thought was the best solution so I could poll the site every second to check for updates in match statuses. 

#Legal
This project is licensed under the [Apache 2.0](https://www.apache.org/licenses/LICENSE-2.0.txt) license
