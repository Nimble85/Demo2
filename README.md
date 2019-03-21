



Add-Migration init
Update-Database





 docker build -t aspnetapp .
 docker run -d -p 8080:80 --name myapp aspnetapp
 
 
 docker build -t bookstoreweb1 .
 docker run -it --rm -p 8000:80 bookstoreweb1
 
 
 change link in file:
 
 Demo2/bookstorev8/bookstorev8/bookstorev8/appsettings.json
 
 dockername
 bdname
 ID
 Password
 
 
 localhost:80/books/Index
 
 проверить через MySQL Manager connection to DB
 
 
 
 
 docker build -t web_2t .

