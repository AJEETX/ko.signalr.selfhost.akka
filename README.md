# A simple Reactive system with message-passing ![GitHub release](https://img.shields.io/github/release/ajeetx/ko.signalr.selfhost.akka.svg?style=for-the-badge)

> akka.net based highly scalable reactive web-application

| Version | Build | DotNet | Dependency |
| --- | --- | --- | --- |
| ![Wrapper](https://img.shields.io/badge/ko.signalr.selfhost.akka-stable-brightgreen.svg)  | [![Build Status](https://travis-ci.org/AJEETX/ko.signalr.selfhost.akka.png?branch=master&style=for-the-badge)](https://travis-ci.org/AJEETX/ko.signalr.selfhost.akka) | [![.Net Framework](https://img.shields.io/badge/DotNet-4.6.1-blue.svg?style=plastic)](https://www.microsoft.com/en-au/download/details.aspx?id=49981) | [![dependencies Status](https://img.shields.io/badge/dependency-none-brightgreen.svg?style=plastic)](https://img.shields.io/badge/dependency-none-brightgreen.svg) |


<img width="1469" alt="reactivesystem" src="https://user-images.githubusercontent.com/16511837/30899573-bfa516e0-a3a3-11e7-9783-1cfd3a4934fd.png">


 #### (a) knockooutjs = [front-end website]
 #### (b) api =[selfhosted console-based api]
 #### (c) Actor-model akka.net = [message-passing]
 #### (d) signalr = push data to front-end

```
 clients[ computer-browser/mobile app] --> 
 (a) html website [nodejs/iis]  --> 
 (b) self hosted api [console application]  -->  
 (c) akka.net [console application]--> 
 (d) signalr
 ```

 ## Setup and run the application:
```

1. Environment:  VS2015 + MSSql Server
2. Create Database by name="AkkaData" 
3. Restore nugets
4. Build Solution
```

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

	### Support or Contact

Having any trouble? Check out our [documentation](https://github.com/AJEETX/ko.signalr.selfhost.akka/edit/master/README.md) or [contact support](mailto:ajeetkumar@email.com) and we’ll help you sort it out.


> [![HitCount](http://hits.dwyl.io/ajeetx//ko.signalr.selfhost.akka/projects/1.svg)](http://hits.dwyl.io/ajeetx//ko.signalr.selfhost.akka/projects/1)

cheers...

