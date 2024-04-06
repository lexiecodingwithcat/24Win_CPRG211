using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Assignment3;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
namespace Assignment3.Tests
    {
    public static class SerializationHelper
        {
        /// <summary>
        /// Serializes (encodes) users
        /// </summary>
        /// <param name="users">List of users</param>
        /// <param name="fileName"></param>
        //public static void SerializeUsers(ILinkedListADT users, string fileName)
        //{
        //   DataContractSerializer serializer = new DataContractSerializer(typeof(List<User>));
        //   using (FileStream stream = File.Create(fileName))
        //   {
        //       serializer.WriteObject(stream, users);
        //        }
        //}

        public static void SerializeUsers(ILinkedListADT users, string filePath)
            {
            BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create));

            for (int i = 0; i < users.Count(); i++)
                {
                User user = users.GetValue(i);
                int id = user.Id;
                string name = user.Name;
                string email = user.Email;
                string password = user.Password;
                writer.Write(id);
                writer.Write(name);
                writer.Write(email);
                writer.Write(password);
                }
            writer.Close();

            }

        /// <summary>
        /// Deserializes (decodes) users
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>List of users</returns>
        /// 

        public static ILinkedListADT DeserializeUsers(string filePath)
            {
            SLL newlist = new SLL();
            BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open));

            using (reader)
                {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                    int id = reader.ReadInt32();
                    string name = reader.ReadString();
                    string email = reader.ReadString();
                    string password = reader.ReadString();
                    User user = new User(id, name, email, password);
                    newlist.AddLast(user);

                    }
                return newlist;
                }
            }
        }
    }
    