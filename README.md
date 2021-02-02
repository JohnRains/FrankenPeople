This is a simple test of the NuGet package Bogus - Copyright (c) 2015 Brian Chavez , based on faker.js - Copyright (c) 2014-2015 Matthew Bergman & Marak Squires et al. 
See https://raw.githubusercontent.com/bchavez/Bogus/master/LICENSE for full list of credits and licensing.

As a QA Automation Engineer at Cane Bay Partners, I know all too well the value of “fresh” data to populate a system under test. Back in 2013, I created my own data generator using a ton of harvested data that I decomposed into a very large set of tables in SQL Server and then wrote a ton of stored procedures to return combinations of the data, creating what became known as “FrankenPeople”. This data was consumed by a desktop app that could POST to an API and a comprehensive continuous regression testing app that ran in all three environments, QA, Dev, UAT.

A few days ago, no longer at CBP, thinking about refining this solution, I started looking into other methods for what I know to be a critical part of Software QA. I found a NuGet package, Bogus; I was so intrigued that I had to try it out. While I work in several languages, for this, I prefer C#. So I wrote a console app to be able to play with Bogus. Much of its API is really intuitive, and a plethora of web posts exist from different developers, covering the usual suspects; Name, Address, Phone number, SSN, etc.; but there are sixteen “sections” of fake data that Bogus addresses and for much of it, there is little information. Fortunately, the code for Bogus is available on GitHub, and after slogging through the Bogus code, my app is now in a state to return data for almost every possibility on the menu.

I have made my code public at https://github.com/JohnRains/FrankenPeople; I still have some elements to resolve but the majority of the items you might want to access are exampled there. Any further changes will be made through feature branches and I will continue to research, resolve and comment examples so that it becomes a valued resource for developers.

Collaboration welcomed.

I claim no rights to the solution.

John Rains 01/27/2021
john@starfish.vi
