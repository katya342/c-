using Ekzamen.Data;
using Ekzamen.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Ekzamen
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Scaffold-DbContext 'Data Source=DESKTOP-B19C890\MSSQLSERVER03;Initial Catalog=ChatDb;Trusted_Connection=true;Encrypt=false' Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models
            User user = new User();
            Menu(user);
          
      
          
           
         
        }
        public static void UserRegistration(User usr)
        {
                
                Console.WriteLine("Enter login please: ");
                usr.Login = Console.ReadLine();
                Console.WriteLine("Enter password please: ");
                usr.Password = Console.ReadLine();
                Console.WriteLine("------------->");
                ChatDbContext userContext = new ChatDbContext();
                if(userContext.Users.Any(f => f.Login == usr.Login))
                Console.WriteLine("User already exists");
                
                userContext.Add(usr);          
                userContext.SaveChanges();
         
            
                Console.WriteLine("User registrated successfully");
                    
        }
        public static void SendMessages(int userId, int fromUserId)
        {
               
                PrivateMessage privateMessage = new PrivateMessage();
                privateMessage.FromUserId = fromUserId;
                privateMessage.ToUserId = userId;
                Console.WriteLine("Enter message please");

            privateMessage.Message = Console.ReadLine();
              
                ChatDbContext messagesContext = new ChatDbContext();
                messagesContext.Add(privateMessage);
                messagesContext.SaveChanges();
                Console.WriteLine("Message registred");
          
                
 
        }
       
        public static void DisplayUsers()
        {
            string Path = "Server=DESKTOP-B19C890\\MSSQLSERVER03;Database=ChatDb;Trusted_Connection=true;Encrypt=false";
            var query = "SELECT * FROM Users";
            using (SqlConnection connection = new SqlConnection(Path))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var login = reader.GetValue(1);
                    var id = reader.GetValue(0);
                    Console.WriteLine("User login --- {0}, id --- {1}", login, id);
                }
            }
        }
        public static void GroupCreate(User user)
        {
           // User user = new User();
            Group group = new Group();
            Console.WriteLine("Enter group name please");
            group.Name = Console.ReadLine();
            group.OwnerId = user.Id;
           
            ChatDbContext dbContext = new ChatDbContext();
            dbContext.Groups.Add(group);
            dbContext.SaveChanges();
            Console.WriteLine("Group successfully created");

            
        }
        public static void Menu(User user)
        {
            DisplayUsers();
            Console.WriteLine("1/ Registration");
            Console.WriteLine("2/ GroupCreation");
            Console.WriteLine("3/ Displaying all users");
            Console.WriteLine("4/ Send messages");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1: UserRegistration(user); break;
                case 2: GroupCreate(user); break;
                case 3: DisplayUsers(); break;
                case 4:
                    Console.WriteLine("Enter which user from id please");
                    int idFrom = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter which user to id please");
                    int idTo = Convert.ToInt32(Console.ReadLine());


                    SendMessages(idFrom, idTo); break;
                default:
                    break;
            }
        }
       
    }

}