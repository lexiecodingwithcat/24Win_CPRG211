using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Components.Pages
    {
    internal class MemberManager
        {
       public static List<Member> members;

        MemberManager()
            {

            }

        //check the name of member
        private static bool CheckName(string first_name, string last_name) {
            if (string.IsNullOrEmpty(first_name) || string.IsNullOrEmpty(last_name)) 
                {
                return false;
                } else
                {
                return true;
                }
            }

        //check password
        private static bool CheckPassword(string password)
            {
            if(password.Length < 8)
                {
                return false;
                }
            else
                {
                return true;
                }
            }

        //check Email
        public static bool CheckEmail(string email) {
            if(string.IsNullOrEmpty(email))
                {
                return false;
                }
            else
                {
                return true;
                }      
            }


        public static string AddMemeber(string first_name, string last_name, string email, string password)
            {
            if(CheckName(first_name, last_name)== false)
                {
                return "First name and last name can't be empty";
                }
            else
                {
                if(CheckEmail(email) == false) {
                    return "Email cannot be empty";
                    }
                else
                    {
                    try
                       {
                        if (CheckPassword(password) == false)
                            {
                            return "Password cannot be empty and must at least have 8 characters";
                            }

                        else
                            {
                            DBhandler db = new DBhandler();
                            db.InsertMemberToDB(first_name, last_name, email, password);
                            return "Registered successfully";
                            }


                        }catch (Exception e)
                               {
                                return e.Message;
                        }


                    }
                }
            }

        //receive result from DB
        public static List<Member> RetriveMember()
            {
            DBhandler db = new DBhandler();
            members = db.LoadMemberFromDB();
            return members;
            }

        //check the validation of update information 
        public static string EditMember(string lname, string fname, string email)
            {
            string message = DBhandler.UpdateMemberToDB(lname, fname, email);
            RetriveMember();
            return message;
            }

        public static string DeleteMember(string email)
            {
            DBhandler db = new DBhandler();
            string message = db.DeleteMemberDB(email);
            RetriveMember() ;
            return message;
            }

        }
    }
