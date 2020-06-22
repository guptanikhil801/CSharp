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

        public bool AddLabel(int NoteId, string Details)
        {
            if (Details != null )
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spAddLabel", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
                    cmdn.Parameters.AddWithValue("@NoteId", NoteId);
                    cmdn.Parameters.AddWithValue("@Details", Details);
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            return false;
        }

        public Label GetLabelByNoteId(int NotelId)
        {
            Label label = new Label();
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {

                SqlCommand cmd = new SqlCommand("spGetLabelByNoteId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NoteId", NotelId);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    label.LabelId = Convert.ToInt32(rdr["LabelId"]);
                    label.NoteId = Convert.ToInt32(rdr["NoteId"]);
                    label.Details = rdr["Details"].ToString();
                }

                con.Close();
            }

            return label;
        }

         public bool DeleteLabel(int LabelId)
         {
             using (SqlConnection con = new SqlConnection(this.connectionString))
             {
                 SqlCommand cmdn = new SqlCommand("spDeleteLabel", con);
                 cmdn.CommandType = CommandType.StoredProcedure;
                 cmdn.Parameters.AddWithValue("@LabelId", LabelId);
                 con.Open();
                 cmdn.ExecuteNonQuery();
                 con.Close();
             }

             return true;
         }



          public bool UpdateLabel(int LabelId, string Details)
          {
              if (Details != null )
              {
                  using (SqlConnection con = new SqlConnection(this.connectionString))
                  {
                      SqlCommand cmdn = new SqlCommand("spUpdateLabel", con);
                      cmdn.CommandType = CommandType.StoredProcedure;
                      cmdn.Parameters.AddWithValue("@LabelId", LabelId);
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
