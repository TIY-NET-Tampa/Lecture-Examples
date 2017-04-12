using HomeworkReview_TIYGift.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HomeworkReview_TIYGift.Services
{
    public static class GiftService
    {
        private static List<Gift> Gifts = new List<Gift> {
            new Gift{ Id = 1, Contents = "Puppy", Hints ="Waggy Tail", Depth =2, Weight =5, Height= 2, Width =4, IsOpened=false },
            new Gift{ Id = 2, Contents = "Candy Cane", Hints ="red & white", Depth =2, Weight =5, Height= 2, Width =4, IsOpened=false },
            new Gift{ Id = 3, Contents = "Train", Hints ="Woot Woot", Depth =2, Weight =5, Height= 2, Width =4, IsOpened=false },
            new Gift{ Id = 4, Contents = "Teddy", Hints ="Cuddly", Depth =2, Weight =5, Height= 2, Width =4, IsOpened=false }


        };

        public static object GetGift(int id)
        {
           return Gifts.First( f => f.Id == id);
        }

        public static List<Gift> GetAllGifts()
        {
            return Gifts;
        }

        public static void AddGift(Gift gift)
        {
            if (gift != null)
            {
                Gifts.Add(gift);
            }
            else
                throw new ArgumentNullException();
        }

        public static Gift UpdateGift(Gift gift)
        {
            const string connectionString = "";

            using (var conn = new SqlConnection(connectionString))
            {
                var query = @"UPDATE Gifts (Content = @Content, Hint = @Hint) WHERE @Id = Id";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Content", gift.Contents);
                cmd.Parameters.AddWithValue("@Hint", gift.Hints);
                cmd.Parameters.AddWithValue("@Id", gift.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            return gift;
        }

        public static void OpenGift(int id)
        {
            //const string connectionString = "";

            //using (var conn = new SqlConnection(connectionString))
            //{
            //    var query = @"UPDATE Gifts (IsOpened = @IsOpened) WHERE @Id = Id";
            //    var cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@IsOpened", true);
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}
            //return gift;

            Gifts.First(f => f.Id == id).IsOpened = true;
        }
    }
}