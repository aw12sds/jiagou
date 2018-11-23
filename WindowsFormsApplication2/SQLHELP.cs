using NetWork.util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class SQLHELP
    {
        private static readonly string connStr = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public static DataTable GetDataTable(string sql, CommandType type, params SqlParameter[] pars)
        {
            //using (SqlConnection conn = new SqlConnection(connStr))
            //{
            //    using (SqlDataAdapter apter = new SqlDataAdapter(sql, conn))
            //    {
            //        if (pars != null)
            //        {
            //            apter.SelectCommand.Parameters.AddRange(pars);
            //        }
            //        apter.SelectCommand.CommandType = type;
            //        DataTable da = new DataTable();
            //        apter.Fill(da);

            //        return da;

            //    }
            //}
            DataTable dt = getData.getdata(sql, "db_office");
            return dt;
        }

        public static int ExecuteNonquery(string sql, CommandType type, byte[] files, params SqlParameter[] pars)
        {
            //using (SqlConnection conn = new SqlConnection(connStr))
            //{
            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        //if (pars != null)
            //        //{
            //        //    cmd.Parameters.AddRange(pars);
            //        //}
            //        conn.Open();
            //        cmd.Parameters.Clear();

            //        cmd.Parameters.Add("@pic", SqlDbType.VarBinary).Value = files;
            //        return cmd.ExecuteNonQuery();
            //    }
            //}
            return getData.ExecuteNonquery(sql, "db_office", files);
        }
        public static object ExecuteScalar(string sql, CommandType type, params SqlParameter[] pars)
        {
            //using (SqlConnection conn = new SqlConnection(connStr))
            //{
            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        if (pars != null)
            //        {
            //            cmd.Parameters.AddRange(pars);
            //        }
            //        cmd.CommandType = type;
            //        conn.Open();
            //        return cmd.ExecuteScalar();
            //    }
            //}
            return getData.ExecuteScalar(sql, "db_office");
        }
        public static int innn(string sql, CommandType type, params SqlParameter[] pars)
        {
            //using (SqlConnection conn = new SqlConnection(connStr))
            //{
            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        if (pars != null)
            //        {
            //            cmd.Parameters.AddRange(pars);
            //        }
            //        cmd.CommandType = type;
            //        conn.Open();
            //        return cmd.ExecuteNonQuery();
            //    }
            //}
            return getData.innn(sql, "db_office");
        }
        public static byte[] duqu(string sql, CommandType type, params SqlParameter[] pars)
        {

            //using (SqlConnection conn = new SqlConnection(connStr))
            //{
            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        if (pars != null)
            //        {
            //            cmd.Parameters.AddRange(pars);
            //        }
            //        cmd.CommandType = type;
            //        conn.Open();
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        byte[] mybuffer = null;
            //        while (dr.Read())
            //        {
            //            mybuffer = (byte[])dr.GetValue(0);

            //        }
            //        return mybuffer;

            //    }
            //}
            byte[] bt = getData.duqu(sql, "db_office");
            return bt;

        }

    }
}
