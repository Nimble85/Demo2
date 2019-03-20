FROM microsoft/mssql-server-linux
ENV ACCEPT_EULA=sa
ENV SA_PASSWORD=VleDh%)yUB
COPY Demo_2Context.bak /var/opt/mssql/Demo_2Context.bak
HEALTHCHECK --interval=10s CMD opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P VleDh%)yUB -Q "RESTORE DATABASE Demo_2Context FROM DISK='/var/opt/mssql/Demo_2Context.bak' WITH MOVE 'Demo_2Context' TO '/var/opt/mssql/data/Demo_2Context.MDF', MOVE 'Demo_2Context_log' TO '/var/opt/mssql/data/Demo_2Context.ldf'"


##ConnectionStrings     "Server=mysql;Database=bookstorev8Context;User Id=sa;Password=VleDh%)yUB"