echo 'Please wait while SQL Server 2017 warms up'
sleep 10s
echo 'Restore database after 10 seconds of wait'
opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P VleDh23byUB -Q "RESTORE DATABASE BS1Context FROM DISK='/var/opt/mssql/BS1Context.bak' WITH MOVE 'BS1Context' TO '/var/opt/mssql/data/BS1Context.MDF', MOVE 'BS1Context_log' TO '/var/opt/mssql/data/BS1Context.ldf'"

echo 'Finished restore the database'