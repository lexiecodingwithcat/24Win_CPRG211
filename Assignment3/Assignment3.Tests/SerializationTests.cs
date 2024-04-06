using Assignment3;
using System.Reflection.Metadata;

namespace Assignment3.Tests
{
    public class SerializationTests
    {
      
        private SLL users ;
      
        private string file_path = Path.Combine(Directory.GetCurrentDirectory(), "test_users.bin");

        [SetUp]
        public void Setup()
        {
            // Uncomment the following line
           this.users = new SLL();
       
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            users.AddLast(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));
           
            
            }

        [TearDown]
        public void TearDown()
        {
            this.users.Clear();
        }

        //test for testing the linked list is empty or not
        [Test]
        public void TestIsEmpty() {
            bool result = users.IsEmpty();
            Assert.IsTrue(result == false);
            
            }

        //test the count of current linked list
        [Test]
        public void TestCount() { 
            int result = users.Count();
            Assert.AreEqual(4, result);
            }

        //test whether it is cleared or not
        [Test]
        public void TestClear() {
            users.Clear();
            bool result = users.IsEmpty();
            Assert.AreEqual(true, result);
            }

        [Test]
        public void TestIndexOf() {
            User new_user = new User(1, "Joe Blow", "jblow@gmail.com", "password");
          int reulst = users.IndexOf(new_user);
            Assert.AreEqual(0, reulst);
        }

        [Test]
        public void TestAddFirst()
            {
            User new_user = new User(5, "Damon Smith", "damonS@gmail.com", "damon123");
            users.AddFirst(new_user);
            int reulst = users.IndexOf(new_user);
            Assert.AreEqual(0, reulst);
            }

        [Test]
        public void TestAdd()
            {
            User new_user = new User(5, "Damon Smith", "damonS@gmail.com", "damon123");
            users.Add(new_user, 1);
            int reulst = users.IndexOf(new_user);
            Assert.AreEqual(1, reulst);
            }


        [Test]
        public void TestAddLast() {
            User new_user = new User(5, "Damon Smith", "damonS@gmail.com", "damon123");
            users.AddLast(new_user);
            int reulst = users.IndexOf(new_user);
            Assert.AreEqual(4, reulst);

            }

        [Test]
        public void TestRemoveFirst()
            {
            User new_user = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            users.RemoveFirst();
            //then the second node will become the first one
            int reulst = users.IndexOf(new_user);
            Assert.AreEqual(0, reulst);

            }

        [Test]
        public void TestRemoveLast()
            {
            User new_user = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            users.RemoveLast();
            int reulst = users.IndexOf(new_user);
            Assert.AreEqual(2, reulst);
            }

        [Test]
        public void TestRemove() {
            User new_user = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            users.Remove(1);
            int result = users.IndexOf(new_user);
            Assert.AreEqual(1, result);
            }

        [Test]
        public void TestRemoveOutRange()
            {
             
            Assert.Throws<IndexOutOfRangeException>(() => users.Remove(4));
            }


        [Test]
        public void TestGetValue()
            {
            string user_name = users.GetValue(0).Name;
            Assert.AreEqual("Joe Blow", user_name);
            }

        [Test]
        public void TestReplace()
            {
            User new_user = new User(5, "Damon Smith", "damonS@gmail.com", "damon123");
            users.Replace(new_user, 1);
            string user_name = users.GetValue(1).Name;
            Assert.AreEqual("Damon Smith", user_name);
            }

        [Test]
        public void TestContain()
            {
            User new_user = new User(5, "Damon Smith", "damonS@gmail.com", "damon123");
            bool result = users.Contains(new_user);
            Assert.AreEqual(false, result);
            }

        [Test]
        public void TestArray()
            {
            User[] arr = users.TurnArray();
            int length = arr.Length;
            Assert.AreEqual(4,length);

            }

        [Test]
        public void TestFirstArray()
            {
            User[] arr = users.TurnArray();
            string name = arr[0].Name;
            Assert.AreEqual("Joe Blow", name);
            }














        /// <summary>
        /// Tests the object was serialized.
        /// </summary>
        [Test]
        public void TestSerialization()
        {
           SerializationHelper.SerializeUsers(users, file_path);
           Assert.IsTrue(File.Exists(file_path));
        }

        ///// <summary>
        ///// Tests the object was deserialized.
        ///// </summary>
        [Test]
        public void TestDeSerialization()
        {
           SerializationHelper.SerializeUsers(users, file_path);
          ILinkedListADT deserializedUsers = SerializationHelper.DeserializeUsers(file_path);
            
           Assert.IsTrue(users.Count() == deserializedUsers.Count());
            
           for (int i = 0; i < users.Count(); i++)
           {
               User expected = users.GetValue(i);
               User actual = deserializedUsers.GetValue(i);

              Assert.AreEqual(expected.Id, actual.Id);
               Assert.AreEqual(expected.Name, actual.Name);
               Assert.AreEqual(expected.Email, actual.Email);
                Assert.AreEqual(expected.Password, actual.Password);
            }
        }
       

    }
}