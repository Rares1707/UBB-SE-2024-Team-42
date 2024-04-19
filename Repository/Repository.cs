using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using UBB_SE_2024_Team_42.Domain;
using System.Drawing;
using System.IO;

namespace UBB_SE_2024_Team_42.Repository
{
    public class Repository
    {
        private string sqlConnectionString = "Data Source=CamFrigLaCluj;Initial Catalog=Team42DB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        // no other fields required
        // when you need something, just create public functions which insert/update/retrieve data directly
        // from the database by calling functions/procedures DEFINED IN THE DB

        public Repository(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
        }

        public List<Notification> getNotificationsOfUser(long userId)
        {
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from dbo.getNotificationsOfUser(" + userId + ")", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            List<Notification> notificationList = new List<Notification>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                notificationList.Add(new Notification(
                    Convert.ToInt64(dataTable.Rows[i]["id"]),
                    "Placeholder text", //this should be created in the constructor without needing this parameter
                    Convert.ToInt64(dataTable.Rows[i]["postId"]),
                    Convert.ToInt64(dataTable.Rows[i]["badgeId"])
                    ));
            }
            connection.Close();

            return notificationList;
        }

        public List<Category> getCategoriesModeratedByUser(long userId)
        {
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from dbo.getCategoriesModeratedByUser(" + userId + ")", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            List<Category> categoryList = new List<Category>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                categoryList.Add(new Category(
                    Convert.ToInt64(dataTable.Rows[i]["id"]),
                    dataTable.Rows[i]["name"].ToString()
                    ));
            }
            connection.Close();

            return categoryList;
        }

        public List<Badge> getBadgesOfUser(long userId)
        {
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from dbo.getBadgesOfUser(" + userId + ")", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            List<Badge> badgeList = new List<Badge>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Image badgeImage;
                byte[] imageBytes = (byte[])dataTable.Rows[i]["image"];
                using (MemoryStream stream = new MemoryStream(imageBytes))
                {
                    badgeImage = Image.FromStream(stream);
                }
                badgeList.Add(new Badge(
                    Convert.ToInt64(dataTable.Rows[i]["id"]),
                    dataTable.Rows[i]["name"].ToString(),
                    dataTable.Rows[i]["description"].ToString(),
                    badgeImage
                    ));
            }
            connection.Close();

            return badgeList;
        }


        public User getUser(long userId)
        {
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from dbo.getUser(" + userId + ")", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            User user = new User(
                    userId,
                    dataTable.Rows[0]["name"].ToString(),
                    getNotificationsOfUser(userId),
                    getCategoriesModeratedByUser(userId),
                    getBadgesOfUser(userId)
                    );
        
             connection.Close();
             return user;
        }

    public List<User> getAllUsers()
    {
        SqlConnection connection = new SqlConnection(sqlConnectionString);
        connection.Open();
        SqlCommand command = new SqlCommand("select * from dbo.getAllUsers()", connection);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        DataTable dataTable = new DataTable();
        dataAdapter.Fill(dataTable);

        List<User> userList = new List<User>();
        for (int i = 0; i < dataTable.Rows.Count; i++)
        {
            long userId = Convert.ToInt64(dataTable.Rows[i]["id"]);
            userList.Add(getUser(userId));
            /*userList.Add(new User(
                userId,
                dataTable.Rows[i]["name"].ToString(),
                getNotificationsOfUser(userId),
                getCategoriesModeratedByUser(userId),
                getBadgesOfUser(userId)
                ));*/
        }
        connection.Close();

        return userList;
    }


    public List<Vote> getVotesOfPost(long postId)
    {
        SqlConnection connection = new SqlConnection(sqlConnectionString);
        connection.Open();
        SqlCommand command = new SqlCommand("select * from dbo.getVotesOfPost(" + postId + ")", connection);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        DataTable dataTable = new DataTable();
        dataAdapter.Fill(dataTable);

        List<Vote> voteList = new List<Vote>();
        for (int i = 0; i < dataTable.Rows.Count; i++)
        {
            voteList.Add(new Vote(
                Convert.ToInt32(dataTable.Rows[i]["value"]),
                Convert.ToInt64(dataTable.Rows[i]["userId"])
                ));
        }
        connection.Close();

        return voteList;
    }

}
}
