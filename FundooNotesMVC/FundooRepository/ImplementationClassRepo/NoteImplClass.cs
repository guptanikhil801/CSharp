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
    public class NoteImplClass : INote
    {
        private string connectionString = ConnectionString.CName;

        public IEnumerable<Note> AllNotes()
        {
            List<Note> lstnote = new List<Note>();
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAllNotes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Note note = new Note();
                    note.NoteId = Convert.ToInt32(rdr["NoteId"]);
                    note.Title = rdr["Title"].ToString();
                    note.Colour = rdr["Colour"].ToString();
                    note.Email = rdr["Email"].ToString();
                    note.Description = rdr["Description"].ToString();
                    note.Image = rdr["Image"].ToString();
                    note.IsPin = Convert.ToBoolean(rdr["IsPin"]);
                    note.CreatedDate = Convert.ToDateTime(rdr["CreatedDate"]);
                    note.ModifiedDate = Convert.ToDateTime(rdr["ModifiedDate"]);
                    note.IsArchive = Convert.ToBoolean(rdr["IsArchive"]);
                    note.IsTrash = Convert.ToBoolean(rdr["IsTrash"]);
                    note.Reminder = rdr["Reminder"].ToString();
                    lstnote.Add(note);
                }
                con.Close();
            }

            return lstnote;
        }

        public bool AddNote(AddNoteModel note)
        {
            if (note.Description != null && note.Email!=null && note.Title!=null)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spAddNotes", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
                    cmdn.Parameters.AddWithValue("@Email", note.Email);
                    cmdn.Parameters.AddWithValue("@Title", note.Title);
                    cmdn.Parameters.AddWithValue("@Description", note.Description);
                    if(note.Color==null)
                    {
                        cmdn.Parameters.AddWithValue("@Colour", "white");
                    }
                    if(note.Color!=null)
                    {
                        cmdn.Parameters.AddWithValue("@Colour",note.Color);
                    }
                    if (note.Reminder == null)
                    {
                        cmdn.Parameters.AddWithValue("@Reminder", "");
                    }
                    if (note.Reminder != null)
                    {
                        cmdn.Parameters.AddWithValue("@Reminder", note.Reminder);
                    }
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }

            return false;
        }

        public bool Archive(int NoteId)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                string sqlQuery = "SELECT * FROM Notes WHERE IsArchive=0 and NoteId =" + NoteId;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.HasRows)
                    {
                        MakeArchive(NoteId);
                        con.Close();
                        return true;
                    }
                    else 
                    {
                        MakeUnArchive(NoteId);
                        con.Close();
                        return true;
                    }
                }
            }         
        }

        public bool DeleteNote(int NoteId)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmdn = new SqlCommand("spDeleteNote", con);
                cmdn.CommandType = CommandType.StoredProcedure;
                cmdn.Parameters.AddWithValue("@NoteId", NoteId);
                con.Open();
                cmdn.ExecuteNonQuery();
                con.Close();
            }

            return true;
        }

        public IEnumerable<Note> GetAllNotes(string Email)
        {
            List<Note> lstnote = new List<Note>();
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllNotes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", Email);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Note note = new Note();
                    note.NoteId = Convert.ToInt32(rdr["NoteId"]);
                    note.Title = rdr["Title"].ToString();
                    note.Colour = rdr["Colour"].ToString();
                    note.Email = rdr["Email"].ToString();
                    note.Description = rdr["Description"].ToString();
                    note.Image = rdr["Image"].ToString();
                    note.IsPin = Convert.ToBoolean(rdr["IsPin"]);
                    note.CreatedDate = Convert.ToDateTime(rdr["CreatedDate"]);
                    note.ModifiedDate = Convert.ToDateTime(rdr["ModifiedDate"]);
                    note.IsArchive = Convert.ToBoolean(rdr["IsArchive"]);
                    note.IsTrash = Convert.ToBoolean(rdr["IsTrash"]);
                    note.Reminder = rdr["Reminder"].ToString();
                    lstnote.Add(note);
                }

                con.Close();
            }

            return lstnote;
        }

        public bool TrashAndUnTrash(int NoteId)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                string sqlQuery = "SELECT * FROM Notes WHERE IsTrash=0 and NoteId =" + NoteId;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.HasRows)
                    {
                        MakeTrash(NoteId);
                        con.Close();
                        return true;
                    }
                    else
                    {
                        MakeUnTrash(NoteId);
                        con.Close();
                        return true;
                    }
                }
            }
        }

        private void MakeArchive(int NoteId)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {                
                SqlCommand cmdn = new SqlCommand("spArchiveNote", con);
                cmdn.CommandType = CommandType.StoredProcedure;
                cmdn.Parameters.AddWithValue("@NoteId", NoteId);
                con.Open();
                cmdn.ExecuteNonQuery();
                con.Close();
            }
        }
        private void MakeUnArchive(int NoteId)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmdn = new SqlCommand("spUnArchiveNote", con);
                cmdn.CommandType = CommandType.StoredProcedure;
                cmdn.Parameters.AddWithValue("@NoteId", NoteId);
                con.Open();
                cmdn.ExecuteNonQuery();
                con.Close();
            }
        }
        private void MakeTrash(int NoteId)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmdn = new SqlCommand("spTrashNote", con);
                cmdn.CommandType = CommandType.StoredProcedure;
                cmdn.Parameters.AddWithValue("@NoteId", NoteId);
                con.Open();
                cmdn.ExecuteNonQuery();
                con.Close();
            }
        }
        private void MakeUnTrash(int NoteId)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmdn = new SqlCommand("spUnTrashNote", con);
                cmdn.CommandType = CommandType.StoredProcedure;
                cmdn.Parameters.AddWithValue("@NoteId", NoteId);
                con.Open();
                cmdn.ExecuteNonQuery();
                con.Close();
            }
        }

        public bool NoteImage(int NoteId, string Imageurl)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmdn = new SqlCommand("spNoteImage", con);
                cmdn.CommandType = CommandType.StoredProcedure;
                cmdn.Parameters.AddWithValue("@NoteId", NoteId);
                cmdn.Parameters.AddWithValue("@Image", Imageurl);
                con.Open();
                cmdn.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }

        public bool ProfilePicture(string Email, string Imageurl)
        {
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmdn = new SqlCommand("spProfilePictureUpload", con);
                cmdn.CommandType = CommandType.StoredProcedure;
                cmdn.Parameters.AddWithValue("@Email", Email);
                cmdn.Parameters.AddWithValue("@Image", Imageurl);
                con.Open();
                cmdn.ExecuteNonQuery();
                con.Close();
                return true;
            }

        }

        public bool UpdateNote(int noteid, string title, string description)
        {
            if (description != null  && title != null)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spUpdateNote", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
                    cmdn.Parameters.AddWithValue("@NoteId", noteid);
                    cmdn.Parameters.AddWithValue("@Title", title);
                    cmdn.Parameters.AddWithValue("@Description", description);
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }

            return false;
        }

        public IEnumerable<Note> GetAllArchivedNotes(string Email)
        {
            List<Note> lstnote = new List<Note>();
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllArchivedNotes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", Email);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Note note = new Note();
                    note.NoteId = Convert.ToInt32(rdr["NoteId"]);
                    note.Title = rdr["Title"].ToString();
                    note.Colour = rdr["Colour"].ToString();
                    note.Email = rdr["Email"].ToString();
                    note.Description = rdr["Description"].ToString();
                    note.Image = rdr["Image"].ToString();
                    note.IsPin = Convert.ToBoolean(rdr["IsPin"]);
                    note.CreatedDate = Convert.ToDateTime(rdr["CreatedDate"]);
                    note.ModifiedDate = Convert.ToDateTime(rdr["ModifiedDate"]);
                    note.IsArchive = Convert.ToBoolean(rdr["IsArchive"]);
                    note.IsTrash = Convert.ToBoolean(rdr["IsTrash"]);
                    note.Reminder = rdr["Reminder"].ToString();
                    lstnote.Add(note);
                }

                con.Close();
            }

            return lstnote;
        }

        public IEnumerable<Note> GetAllTrashedNotes(string Email)
        {
            List<Note> lstnote = new List<Note>();
            using (SqlConnection con = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllTrashedNotes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", Email);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Note note = new Note();
                    note.NoteId = Convert.ToInt32(rdr["NoteId"]);
                    note.Title = rdr["Title"].ToString();
                    note.Colour = rdr["Colour"].ToString();
                    note.Email = rdr["Email"].ToString();
                    note.Description = rdr["Description"].ToString();
                    note.Image = rdr["Image"].ToString();
                    note.IsPin = Convert.ToBoolean(rdr["IsPin"]);
                    note.CreatedDate = Convert.ToDateTime(rdr["CreatedDate"]);
                    note.ModifiedDate = Convert.ToDateTime(rdr["ModifiedDate"]);
                    note.IsArchive = Convert.ToBoolean(rdr["IsArchive"]);
                    note.IsTrash = Convert.ToBoolean(rdr["IsTrash"]);
                    note.Reminder = rdr["Reminder"].ToString();
                    lstnote.Add(note);
                }

                con.Close();
            }

            return lstnote;
        }
    }
}
