
# AGENDA

* SUMMARY
* TECHNOLOGY STACK
* DEPLOYMENT VIEW
* QUESTIONS
* REFERENCES

# SUMMARY

> This is a simple Internet book store. You Can make order the some books just to fill a registration form.
>	This is not big web application which was wrote on the best language - C#
> You Can feeling all amazing this webapp just do some simple steps.

> In this project you Can create virtual environments, with virtual machines used to Docker-Compose file.
> And some scripts  which will make all of deployment work for you!
> You can relax and enjoy process


# TECHNOLOGY STACK

- [ ] * Docker;	Docker-Compose;
- [ ] * MicrosoftVisualBuildTools2017;
- [ ] * Microsoft.NETFrimework.4.7.1; 	
- [ ] * MicrosoftSQLServer2017; 			
- [ ] * MicrosoftWebDeploy10.0.1973; 	
- [ ] * Haproxyv1.7; 
- [ ] * mssql server linux;


# DEPLOYMENT VIEW

(link)


STEP BY STEP






Add-Migration init
Update-Database





 docker build -t aspnetapp .
 docker run -d -p 8080:80 --name myapp aspnetapp
 
 
 docker build -t bookstoreweb1 .
 docker run -it --rm -p 8000:80 bookstoreweb1
 
 
 
