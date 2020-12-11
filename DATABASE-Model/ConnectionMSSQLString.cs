using System;
public class ConnectionMSSQLStringBuilder : ConnectionStringBuilder
{
    public string Server { get; set; }
    public string Database { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public ConnectionMSSQLStringBuilder(string Database)
    {
        // appsettings.json 
        // 
        // "ConnectionStrings": {
        //    "Database": "Widget",
        // }

        // No server, so SQLExpress/LocalDB
        this.Server = "(LocalDB)\\MSSQLLocalDB";
        // Database always required
        this.Database = Database;
        // No Username/Password, so Windows Authentication
        this.UserName = String.Empty;
        this.Password = String.Empty;
        //this.IntegratedSecurity = true;
    }
    public ConnectionMSSQLStringBuilder(string Server, string Database)
    {
        // appsettings.json 
        // 
        // "ConnectionStrings": {
        //    "Server": "LAPTOP-QR0QPGVQ",
        //    "Database": "Widget",
        // } 

        // Server, so MS-SQL (LocalDB could be passed in if desired)
        this.Server = Server;
        // Database always required
        this.Database = Database;
        // No Username/Password, so Windows Authentication
        this.UserName = String.Empty;
        this.Password = String.Empty;
        //this.IntegratedSecurity = true;
    }
    public ConnectionMSSQLStringBuilder(string Database, string UserName, string Password)
    {
        // appsettings.json 
        // 
        // "ConnectionStrings": {
        //    "Database": "Widget",
        //    "UserName": "WidgetUser",
        //    "Password": "234c232v2",
        // } 

        // No server, so SQLExpress/LocalDB
        this.Server = "(LocalDB)\\MSSQLLocalDB";
        // Database always required
        this.Database = Database;
        // Username/Password, so SQL Server authentication
        this.UserName = UserName;
        this.Password = Password;
        //this.IntegratedSecurity = false;
    }
    public ConnectionMSSQLStringBuilder(string Server, string Database, string UserName, string Password)
    {
        // appsettings.json 
        // 
        // "ConnectionStrings": {
        //    "Server": "LAPTOP-QR0QPGVQ",
        //    "Database": "Widget",
        //    "UserName": "WidgetUser",
        //    "Password": "234c232v2",
        // } 

        // Server, so MS-SQL (LocalDB could be passed in if desired)
        this.Server = Server;
        // Database always required
        this.Database = Database;
        // Username/Password, so SQL Server authentication
        this.UserName = UserName;
        this.Password = Password;
        //this.IntegratedSecurity = false;
    }
    public override string ToString()
    {
        string s = string.Empty;
        string d = string.Empty;
        string i = string.Empty;
        string u = string.Empty;
        string p = string.Empty;
        string result = string.Empty;

        // Server
        if ((this.Server != string.Empty) && (this.Server != null) && (this.Server != ""))
            s = this.Server;
        else
            s = "(LocalDB)\\MSSQLLocalDB";

        // Database
        if ((this.Database != string.Empty) && (this.Database != null) && (this.Database != ""))
            d = this.Database;
        else
            d = "LocalDB";

        // UserName 
        u = this.UserName;

        // Password
        p = this.Password;

        // Build the final output string 
        if ((s != string.Empty) && (s != null) && (s != ""))
            result = result + String.Format("Server={0};", s);

        if ((d!= string.Empty) && (d != null) && (d != ""))
            result = result + String.Format("Database={0};", d);

        // Determine Authentication mode from presence of username & password
        if ( (this.UserName != string.Empty) && (this.UserName != null) && (this.UserName != "")
            && (this.Password != string.Empty) && (this.Password != null) && (this.Password != "") )

            // SQL Server Authentication
            result = result + String.Format(" User Id= {0}; Password={1};", u, p);
        else
            // Windows Authentication
            result = result + " Integrated Security=SSPI;";

        // Output the final string
        return result;
    }
}
