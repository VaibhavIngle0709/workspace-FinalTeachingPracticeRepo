// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
using System;
using System.Data;



//Show();
//AddRecord();
//Console.WriteLine(" ");
//Console.WriteLine("====================>>>After Adding Records");
//Show();

ShowDisconnectedArchitecture();
//AddDiconnectedArchitecture();













void AddDiconnectedArchitecture()
{ 
    string Connectionstring="User ID=sa;password=examlyMssql@123; server=localhost;Database=DemoDatabase;trusted_connection=false;Persist Security Info=False;Encrypt=False";
    SqlConnection connection=null;
    SqlDataAdapter adapter=null;
    DataSet ds=null;
    DataTable prodTable=null;

    Console.Write("Enter Id: ");
    int id =Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Name: ");
    string name=Console.ReadLine();
    Console.Write("Enter Price: ");
    int price=Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Stock: ");
    int stock=int.Parse(Console.ReadLine());

    try
    {
        ds =new DataSet();
        connection=new SqlConnection(Connectionstring);
        adapter=new SqlDataAdapter("select * from product",connection);
        adapter.Fill(ds,"Prods");
        prodTable=ds.Tables["Prods"];

        DataRow prodRow=prodTable.NewRow();
        prodRow["id"]=id;
        prodRow["Name"]=name;
        prodRow["price"]=price;
        prodRow["stock"]=stock;
        prodTable.Rows.Add(prodRow);

        SqlCommandBuilder scb=new SqlCommandBuilder(adapter);
        //Console.WriteLine(scb.GetInsertCommand().CommandText);

        adapter.Update(prodTable);
        Console.WriteLine("Row Added");
        connection.Close();
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }

}




void ShowDisconnectedArchitecture()
{
    string Connectionstring="User ID=sa;password=examlyMssql@123; server=localhost;Database=DemoDatabase;trusted_connection=false;Persist Security Info=False;Encrypt=False";
    string cmdtext="insert into product values(@id,@name,@price,@stock)";
    SqlConnection connection=null;
    SqlDataAdapter adapter=null;
    DataSet ds=null;
    DataTable prodTable=null;

    try
    {
        ds =new DataSet();
        connection=new SqlConnection(Connectionstring);
        adapter=new SqlDataAdapter("select * from product",connection);

        adapter.Fill(ds,"Prods");

        prodTable=ds.Tables["Prods"];
        Console.WriteLine($"Rows = {prodTable.Rows.Count}");
        Console.WriteLine($"Colums={prodTable.Columns.Count}");

        foreach(DataRow row in prodTable.Rows)
        {
            Console.WriteLine($"{row["id"]}  {row["Name"]}  {row["price"]}  {row["stock"]}");
        }

    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void AddRecord()
{
string Connectionstring="User ID=sa;password=examlyMssql@123; server=localhost;Database=DemoDatabase;trusted_connection=false;Persist Security Info=False;Encrypt=False";
try
{
    SqlConnection con=new SqlConnection(Connectionstring);
    con.Open();
   
    Console.Write("Enter Id: ");
    int id =Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Name: ");
    string name=Console.ReadLine();
    Console.Write("Enter Price: ");
    int price=Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Stock: ");
    int stock=int.Parse(Console.ReadLine());

    string cmdtext="Insert into Product values(@id,@name,@price,@stock)";
    SqlCommand sqlcommand=new SqlCommand(cmdtext,con);
    sqlcommand.Parameters.AddWithValue("@id",id);
    sqlcommand.Parameters.AddWithValue("@name",name);
    sqlcommand.Parameters.AddWithValue("@price",price);
    sqlcommand.Parameters.AddWithValue("@stock",stock);
    sqlcommand.ExecuteNonQuery();


    con.Close();
}
catch(Exception e)
{   
    Console.WriteLine(e.Message);
}

finally
{
    //con.Close();
}
}




void Show()
{
string Connectionstring="User ID=sa;password=examlyMssql@123; server=localhost;Database=DemoDatabase;trusted_connection=false;Persist Security Info=False;Encrypt=False";
string cmdtext="select * from Product";

try
{

    SqlConnection con=new SqlConnection(Connectionstring);
    con.Open();
    Console.WriteLine("Connection Opened Successfully");
    SqlCommand command=new SqlCommand(cmdtext,con);
    SqlDataReader reader=command.ExecuteReader();


    while(reader.Read())
    {
        Console.WriteLine($"ID=> {reader["id"]} Name=> {reader["Name"]} Price=> {reader["Price"]}");
    }
    con.Close();
}
catch (Exception ex)
{
    
    Console.WriteLine(ex.Message);
}
}