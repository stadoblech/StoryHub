using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DatabaseConnector
/// </summary>
public class DatabaseConnector
{
    private static string _connectionString = "Data Source=mssql02.qsh.eu,1481;Initial Catalog = db1002584-storyhub; Persist Security Info=True;User ID = db1002584-storyhub; Password=HubityHub153";

    private static SqlConnection connection = null;

    public static SqlConnection Connection
    {
        get
        {
            return connection;
        }

        set
        {
            connection = value;
        }
    }

    public static void Connect()
    {
        try
        {
            Connection = new SqlConnection(_connectionString);
            Connection.Open();
        }
        catch (Exception)
        {

            throw;
        }
    }

    public static void Disconnect()
    {
        try
        {
            Connection.Close();
        }
        catch (Exception)
        {

            throw;
        }
    }
}