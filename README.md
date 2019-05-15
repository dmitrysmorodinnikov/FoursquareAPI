FoursquareAPI
=============
Foursquare API .NET wrapper is written in C# and provides quick access to Foursquare API v2. Supports oAuth protocol. Now Venues and Users endpoints are almost fully implemented. All the other endpoints implementations will be published as they are tested properly, it's the question of the nearest future. 

Do not hesitate and look for code examples in SamplesProject which is a part of the solution.

Installation
==============
To install FoursquareAPI with Nuget, run the following command in the Package Manager Console
```
PM> Install-Package FoursquareAPI
```

Code examples
==============
To create an instance of FoursquareApi:
```
var clientId = "Your_clientId";
var clientSecret = "Your_clientSecret";
var redirectUri = "Your_RedirectUri";
var accessToken = "Your_accessToken";
var foursquare = new Foursquare(clientId,clientSecret, redirectUri,accessToken);//if the user is authenticated
OR
var foursquare = new Foursquare(clientId,clientSecret);//if the user is not authenticated
```

After creating an instance different API methods are available, like below:
```
var venueDetail = foursquare.Venues.VenueDetail("4c263af6a852c9287537e66c");
var trendingVenues = foursquare.Venues.TrendingVenues(40.7,-74);
var userDetail = foursquare.Users.User("userId");
var userPhotos = foursquare.Users.UserPhotos("userId");
```

Authentication
==============
Start by registering your app to obtain its Foursquare API credentials.
Then send a request to foursquare authentication service which will return a code to your Redirect URI:
```
var foursquare = new Foursquare(clientId, clientSecret, redirectUri, null);
foursquare.Authenticate();
```
Finally you should use the code you received earlier to get access token which is used for authentication-sensitive features:
```
var accessToken = foursquare.GetAccessToken("code");
``` 
 
Save this access token for this user in your database.


More info
==============
More detailed information about Foursquare API, endpoints, authentication etc can be found at <a href="https://developer.foursquare.com/" target=_blank title="My Twitter">https://developer.foursquare.com/</a><br/>
