FROM microsoft/mssql-server-linux
ENV ACCEPT_EULA=${ACCEPT_EULA}
ENV SA_PASSWORD=${SA_PASSWORD}
ENV USER_ID=${USER_ID}

COPY BS1Context.bak     /var/opt/mssql/data/BS1Context.bak
COPY dbo.books-all.sql  /var/opt/mssql/data/dbo.books-all.sql

##works with request
HEALTHCHECK --interval=30s CMD /opt/mssql-tools/bin/sqlcmd -S localhost -U ${USER_ID} -P ${SA_PASSWORD} -i /var/opt/mssql/data/dbo.books-all.sql

##works with backup
#HEALTHCHECK --interval=30s CMD opt/mssql-tools/bin/sqlcmd -S localhost -U ${USER_ID} -P ${SA_PASSWORD} -Q "RESTORE DATABASE BS1Context FROM DISK='/var/opt/mssql/data/BS1Context.bak' WITH MOVE 'BS1Context' TO '/var/opt/mssql/data/BS1Context.mdf', MOVE 'BS1Context_log' TO '/var/opt/mssql/data/BS1Context_log.ldf' "


