
# AGENDA

* SUMMARY
* TECHNOLOGY STACK
* DEPLOYMENT VIEW
* QUESTIONS
* REFERENCES

# SUMMARY

>  This is a simple Internet book store. You Can make order the some books just to fill a registration form.
>	 This is not big web application which was wrote on the best language - C#
>  You Can feeling all amazing this webapp just do some simple steps.

>  In this project you Can create virtual environments, with virtual machines used to Docker-Compose file.
>  And some scripts  which will make all of deployment work for you!
>  You can relax and enjoy process


# TECHNOLOGY STACK

- [x]  Docker;	Docker-Compose;
- [x]  MicrosoftVisualBuildTools2017;
- [x]  Microsoft.NETFrimework.4.7.1; 	
- [x]  MicrosoftSQLServer2017; 			
- [x]  MicrosoftWebDeploy10.0.1973; 	
- [x]  Haproxyv1.7; 
- [x]  mssql server linux;


# DEPLOYMENT VIEW

![image](https://github.com/Nimble85/Demo2/blob/master/Untitled Diagram.png)


# STEP BY STEP

* Installing Docker on Ubuntu 18.04

> sudo apt update

> sudo apt install apt-transport-https ca-certificates curl software-properties-common

> curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo apt-key add 

> sudo add-apt-repository "deb [arch=amd64] https://download.docker.com/linux/ubuntu bionic stable"

> sudo apt update

> apt-cache policy docker-ce

> sudo apt install docker-ce

> sudo systemctl status docker

* Executing the Docker Command Without Sudo 

> sudo usermod -aG docker ${USER}

> su - ${USER}

> id -nG

> sudo usermod -aG docker username

* Install git

> apt-get update

> apt-get install git-core

> git --version

> git clone https://github.com/Nimble85/Demo2.git

* Lounch project

`` Going to folder with project
``
> docker-compose up --build

``` wait some times and check result on adress```
> http://localhost/books

# QUESTIONS
- [ ] How to create the BD
```
Add-Migration init
Update-Database
```
- [ ] How to build web app
```
 docker build -t aspnetapp .
 docker run -d -p 8080:80 --name myapp aspnetapp
 
 docker build -t bookstoreweb1 .
 docker run -it --rm -p 8000:80 bookstoreweb1
```
 
 
# REFERENCES
 
> https://www.digitalocean.com/community/tutorials/how-to-install-and-use-docker-on-ubuntu-18-04 
> https://hub.docker.com/r/dockercloud/haproxy/
