using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace CS_131_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> Instagram = new List<User>();

            User UserName = new User();
            Roles myRoles = new Roles();
            Images Picutures = new Images();
            Post FavoritePost = new Post();
            Comments LikedComments = new Comments();

            Instagram.Add(UserName);
            



            List<User> newList = Instagram.Where(User => User.UserName == "List of Comments").ToList();

            foreach (var item in newList)
            {
                Console.Write("User Nane: ");
            }


        }
    }
}
public class User
{
    public string UserName { get; set; } = string.Empty;
  
}
public class Roles
{
    public string MyRole { get; set; }
}
public class Images
{
    public string Pictures { get; set; }
}
public class Post
{
    public string FavoritePost { get; set; } = string.Empty;
}
public class Comments
{
    public string LikedComment { get; set; }

}


}

