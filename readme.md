The magic of writing .Net applications on Mac, using the new open-source CLR core.


##Building

Build using ASP .Net 5. See https://github.com/aspnet/home for instructions on how to
build on your machine.


###Downloading packages

Assuming you're got ASP .Net 5 installed, and the command line tools are available (see above), then you can restore nuget packages like this:

```
kpm restore
```

### Running

Assuming you're got ASP .Net 5 installed, and the command line tools are available (see above), then you can run the project like this (from the /src/web/ directory):

```
k kestrel
```

The webserver will be running on port 5004 (as of this writing). 

Navigate to /hello/world for a special message - here we're using an the controller in controllers/hellocontroller.cs to serve up the message.


To exit the server, hit Enter. There's currently a bug in the hosting, so if you press Ctrl-C to try and terminate the process, it'll just hang. If you do this, you can terminate the process on Mac by doing this:
- Hit Ctrl-Z
- Type `kill %1`


If you want to see exactly what's going on (including if the port has changed), look in project.json in the commands -> kestrel element.

Note that you can also run `k web` which will launch on port 5001 using a different webserver, but that server doesn't yet work on OSX. So for Mac, use the kestrel server.

##Unit tests

Navigate to test/logic.tests and run
```
k test
```


##Generating the app from scratch

Since the release of beta3, these don't seem to work anymore. Just copy the project.json file and go from there.

These instructions are for Mac OS X.

Things I already had installed:
- mono
- npm
- asp .net 5 (see https://github.com/aspnet/home for how to get setup on your platform)

Install Yeoman:

```
sudo npm install --global yo
```

Install the Yeoman asp generator
```    
npm install -g generator-aspnet
```

Run yo:
```
yo
```

Yeoman will guide you through generating the app
