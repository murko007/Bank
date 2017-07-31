using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;
using System.Configuration;

namespace Bank
{
    class Dal
    {   //строка соединения
        string connectionstring = ConfigurationManager.ConnectionStrings["Bank"].ConnectionString;
        public ArrayList getAlDebitors()
        {
            ArrayList allDebitors = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Debits", con);
                con.Open();
                try
                {
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                        {
                            allDebitors.Add(result);
                        }
                }
                catch { }
            }
            return allDebitors;
        }


        internal ArrayList getAlCredits(string DebitorID)
        {
            ArrayList allCredits = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
               // string query = String.Format("GetAllCredits", DebitorID);
                SqlCommand com = new SqlCommand("dbo.GetAllCreditsProc", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@debitorID";
                param.Value = new Guid(DebitorID);
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                param.Direction = System.Data.ParameterDirection.Input;
                
                com.Parameters.Add(param);

                con.Open();
                try
                {
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                        {
                            allCredits.Add(result);
                        }
                }
                catch { }
            }
            return allCredits;
        }
        internal object getAlPayments(string CreditorID)
        {
            ArrayList allPayments = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                string query = String.Format("SELECT * FROM Payment WHERE CreditsId = '{0}'", CreditorID);
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                try
                {
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                        {
                            allPayments.Add(result);
                        }
                }
                catch { }
            }

            return allPayments;

        }
        public bool SaveNewDebitor(string Id, string Name, string PostNumber, string PhoneNymber)
        {
            bool flagResult = false;
            string query = String.Format("INSERT INTO Debits (Id, Name,PostNumber, PhoneNumber) VALUES ('{0}','{1}','{2}','{3}')",Id,Name,PostNumber,PhoneNymber);
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand com = new SqlCommand(query,con);
                try { 
                    con.Open();
                   if(com.ExecuteNonQuery()==1)
                       flagResult=true;
                                
                    }
                catch { }

            }
            return flagResult;
                    
            
        }

        public bool SaveNewCredit(Guid id, Guid DebitsID, int  amount, int  balance, DateTime data)
        {

            bool flagResult = false;
            string query = String.Format("INSERT INTO Credits (Id, DebitsId, Amount, Balance, OpenDate) VALUES ('{0}','{1}','{2}','{3}','{4}')", id, DebitsID, amount, balance, data.ToString("yyyy.MM.dd"));
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                

                SqlCommand com = new SqlCommand(query, con);
                //com.Parameters.AddWithValue("dd.MM.yyyy", data);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;

                }
                catch { }

            }
            return flagResult;
                    
        }

        internal bool SaveNewPayment(Guid Id, Guid creditId, decimal payamount, DateTime datepay)
        {
            bool flag = true;
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                SqlTransaction sqlTransaction = con.BeginTransaction();
                SqlCommand com = con.CreateCommand();
                com.Transaction = sqlTransaction;
                try 
                {
                    string query = string.Format("INSERT INTO Payment (Id, CreditsId, Amount, PaymentDate) VALUES" +
                        " ('{0}', '{1}', '{2}', '{3}')",Id,creditId,payamount,datepay.ToString("yyyy.MM.dd"));
                    com.CommandText = query;
                    com.ExecuteNonQuery();


                    query = string.Format("UPDATE Credits Set Balance=(Balance-'{0}') WHERE Idddd='{1}'",payamount,creditId);
                    com.CommandText = query;
                    com.ExecuteNonQuery();
                    sqlTransaction.Commit();
                }
                catch
                {
                    sqlTransaction.Rollback();
                    flag = false;
                }
                finally
                {

                }

                return flag;
            }
        }

        internal bool DBSaveToCSVLocalFile()
        {
            bool result=true;
            //if (File.Exists())
            //DateTime currentDate = DateTime.Now;
            StreamWriter file ;
            
            string query;
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                try
                {
                    file = new StreamWriter(new FileStream("Debitors.csv", FileMode.Create), Encoding.GetEncoding(1251));
                    query = "SELECT * FROM Debits";
                    SqlCommand com = new SqlCommand(query,con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine(@"""Id"";""Name"";""PostNumber"";""PhoneNumber""");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" +
                                                  reader.GetString(1) + @""";""" +
                                                  reader[2].ToString() + @""";""" +
                                                  reader.GetString(3) + @"""", Encoding.ASCII);
                        }
                    }
                    else
                    {
                        file.WriteLine("no one row to save");
                    }
                    file.WriteLine("End of file");
                    result = true;
                    file.Dispose();
                   
                }

            catch 
                {
                        result = false;
                       // return result;
                 }
                
            }

             

            
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                try
                {
                    file = new StreamWriter(new FileStream("Credits.csv", FileMode.Create), Encoding.GetEncoding(1251));
                    query = "SELECT * FROM Credits";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine(@"""Id"";""DebitsId"";""Amount"";""Balance"";""OpenDate""");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader[0].ToString() + @""";""" +
                                                  reader[1].ToString() + @""";""" +
                                                  reader[2].ToString() + @""";""" +
                                                  reader[3].ToString() + @""";""" +
                                                  reader[4].ToString() + @"""", Encoding.ASCII);
                        }
                    }
                    else
                    {
                        file.WriteLine("no one row to save");
                    }
                    file.WriteLine("End of file");
                    result = true;
                    file.Dispose();

                }

                catch
                {
                    result = false;
                    //return result;
                }

            }


            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                try
                {
                    file = new StreamWriter(new FileStream("Payment.csv", FileMode.Create), Encoding.GetEncoding(1251));
                    query = "SELECT * FROM Payment";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine(@"""Id"";""CreditsId"";""Amount"";""PaymentDate""");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader[0].ToString() + @""";""" +
                                                  reader[1].ToString() + @""";""" +
                                                  reader[2].ToString() + @""";""" +
                                                  reader[3].ToString() + @"""", Encoding.ASCII);
                        }
                    }
                    else
                    {
                        file.WriteLine("no one row to save");
                    }
                    file.WriteLine("End of file");
                    result = true;
                    file.Dispose();

                }

                catch
                {
                    result = false;
                    //return result;
                }

            }
            return result;
        }


        internal ArrayList Search(string debName, string debPhone, string debPost)
        {
            ArrayList serchedDeb = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                
                SqlCommand com = new SqlCommand("dbo.Procedure", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@debName";
                param.Value = debName;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;

                com.Parameters.Add(param);

                 param = new SqlParameter();
                 param.ParameterName = "@debPhone";
                 param.Value = debPhone;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;

                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@debPost";
                param.Value = debPost;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;

                com.Parameters.Add(param);



                con.Open();
                try
                {
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                        {
                            serchedDeb.Add(result);
                        }
                }
                catch { }
            }
            return serchedDeb;
        }
    }
}
