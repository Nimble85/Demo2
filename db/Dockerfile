FROM microsoft/mssql-server-linux
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=VleDh23byUB

COPY BS1Context.bak     /var/opt/mssql/data/BS1Context.bak
COPY dbo.books-all.sql  /var/opt/mssql/data/dbo.books-all.sql


##works with backup
#HEALTHCHECK --interval=30s CMD opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P VleDh23byUB -Q "RESTORE DATABASE BS1Context FROM DISK='/var/opt/mssql/data/BS1Context.bak' WITH MOVE 'BS1Context' TO '/var/opt/mssql/data/BS1Context.mdf', MOVE 'BS1Context_log' TO '/var/opt/mssql/data/BS1Context_log.ldf' "

##works with request
HEALTHCHECK --interval=30s CMD /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P VleDh23byUB -i /var/opt/mssql/data/dbo.books-all.sql
