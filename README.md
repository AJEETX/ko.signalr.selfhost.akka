# A simple Reactive system with message-passing 

> [![start with why](https://img.shields.io/badge/start%20with-why%3F-brightgreen.svg?style=flat)](http://www.ted.com/talks/simon_sinek_how_great_leaders_inspire_action)

> [![Build Status](https://travis-ci.org/AJEETX/ko.signalr.selfhost.akka.png?branch=master)](https://travis-ci.org/AJEETX/ko.signalr.selfhost.akka)

> [![dependencies Status](https://david-dm.org/dwyl/esta/status.svg)](https://david-dm.org/dwyl/esta)

### Support or Contact

Having trouble with Pages? Check out our [documentation](https://github.com/AJEETX/ko.signalr.selfhost.akka/edit/master/README.md) or [contact support](mailto:ajeetkumar@email.com) and we’ll help you sort it out.


> [![HitCount](http://hits.dwyl.io/ajeetx//ko.signalr.selfhost.akka/projects/1.svg)](http://hits.dwyl.io/ajeetx//ko.signalr.selfhost.akka/projects/1)



<img width="1469" alt="reactivesystem" src="https://user-images.githubusercontent.com/16511837/30899573-bfa516e0-a3a3-11e7-9783-1cfd3a4934fd.png">


 (a) knockooutjs = [front-end website] 
 (b) api =[selfhosted console-based api]
 (c) Actor-model akka.net = [message-passing]
 (d) signalr = push data to front-end

## clients[ computer-browser/mobile app] --> (a) html website [nodejs/iis]  --> (b) self hosted api [console application]  -->  (c) akka.net [console application]--> (d) signalr

# Setup and run the application:

1. Environment:  VS2015 + MSSql Server
2. Create Database by name="AkkaData" 
3. Restore nugets
4. Build Solution

If all goes good, then we need to run the projects one by one in sequence as listed in order below:
1. Run the Akka.DB console project [in non admin mode, in case of issue]

	Database actor system is up-and running

2. Then run Akka.Service console project

	Service actor system is up-and running

3. Run the SelfHostedapi console project in admin mode

	Self hosted api is up-and running

4. Run WebAPIClient

	home.html page displays the data.

	![Alt text](/page.png?raw=true "Home page")
	
	Please do CRUD operation and have play around.

cheers...

