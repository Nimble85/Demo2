echo 'Please wait while SQL Server 2017 warms up'
sleep 10s
echo 'Restore database after 10 seconds of wait'
opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P VleDh%)yUB -Q "RESTORE DATABASE Demo_2Context FROM DISK='/var/opt/mssql/Demo_2Context.bak' WITH MOVE 'Demo_2Context' TO '/var/opt/mssql/data/Demo_2Context.MDF', MOVE 'Demo_2Context_log' TO '/var/opt/mssql/data/Demo_2Context.ldf'"

echo 'Finished restore the database'