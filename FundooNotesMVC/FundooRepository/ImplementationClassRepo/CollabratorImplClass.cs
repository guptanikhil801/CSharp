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
    public class CollabratorImplClass : ICollabratorRepo
    {
        private string connectionString = ConnectionString.CName;

        public bool AddCollabrator(Collabrator model)
        {
            if (model.UserEmail != null && model.CollabratorEmail != null)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spAddCollabrator", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
                    cmdn.Parameters.AddWithValue("@UserEmail", model.UserEmail);
                    cmdn.Parameters.AddWithValue("@CollabratorEmail", model.CollabratorEmail);
                    cmdn.Parameters.AddWithValue("@NoteId", model.NoteId);
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<Collabrator> GetAllCollabrator(int noteid)
        {
            List<Collabrator> lstCollabrator = new List<Collabrator>();
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllCollabrators", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NoteId", noteid);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Collabrator collab = new Collabrator();
                    collab.NoteId = Convert.ToInt32(rdr["NoteId"]);
                    collab.UserEmail = rdr["UserEmail"].ToString();
                    collab.CollabratorEmail = rdr["CollabratorEmail"].ToString();
                    collab.CollabId = Convert.ToInt32(rdr["CollabId"]);
                    lstCollabrator.Add(collab);
                }
                con.Close();
            }

            return lstCollabrator;
        }

        public bool RemoveCollabrator(int collabeid)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmdn = new SqlCommand("spRemoveCollabrator", con);
                cmdn.CommandType = CommandType.StoredProcedure;
                cmdn.Parameters.AddWithValue("@CollabId", collabeid);
                con.Open();
                cmdn.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }
    }
}
