using Common.NotesModels;
using FundooRepository.InterfaceRepo;
using FundooRepository.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace FundooRepository.ImplementationClassRepo
{
    public class LabelImpl : ILabel
    {
        private string connectionString = ConnectionString.CName;

        public bool AddLabel(string Email, string Details)
        {
            if (Email != null && Details != null )
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spAddLabel", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
                    cmdn.Parameters.AddWithValue("@Email", Email);
                    cmdn.Parameters.AddWithValue("@Details", Details);
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteLabel(string Email, int LabelId)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmdn = new SqlCommand("spDeleteLabel", con);
                cmdn.CommandType = CommandType.StoredProcedure;
                cmdn.Parameters.AddWithValue("@Email", Email);
                cmdn.Parameters.AddWithValue("@LabelId", LabelId);
                con.Open();
                cmdn.ExecuteNonQuery();
                con.Close();
            }

            return true;
        }

        public IEnumerable<Label> GetAllLabels(string Email, int LabelId)
        {
            List<Label> lstlabel = new List<Label>();
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllLabels", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", Email);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Label label = new Label();
                    label.LabelId = Convert.ToInt32(rdr["LabelId"]);
                    label.Email = rdr["Email"].ToString();
                    label.Details = rdr["Details"].ToString();
                }

                con.Close();
            }

            return lstlabel;
        }

        public bool UpdateLabel(int LabelId, string Email, string Details)
        {
            if (Details != null )
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spUpdateLabel", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
                    cmdn.Parameters.AddWithValue("@LabelId", LabelId);
                    cmdn.Parameters.AddWithValue("@Emaile", Email);
                    cmdn.Parameters.AddWithValue("@Details", Details);
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }

            return false;
        }
    }
}
