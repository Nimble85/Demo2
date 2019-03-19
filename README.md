



Add-Migration init
Update-Database





 docker build -t aspnetapp .
 docker run -d -p 8080:80 --name myapp aspnetapp
 
 
 docker build -t bookstoreweb1 .
 docker run -it --rm -p 8000:80 bookstoreweb1