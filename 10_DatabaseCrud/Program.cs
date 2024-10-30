using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create-Read- Update- Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Ekleme İstediğiniz Kategori Adı: ");
            //string categoryName=Console.ReadLine();


            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-83L42UFV\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();//koşulsuz sorguyu çalıştır. Sorgu çalıştıktan sonra veri tabanına yansır..
            //connection.Close();
            //Console.Write("Kategori Başarıyla Eklendi!");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice= decimal.Parse(Console.ReadLine());


            //SqlConnection connetion = new SqlConnection("Data source=LAPTOP-83L42UFV\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connetion.Open();
            //SqlCommand Command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connetion);
            //Command.Parameters.AddWithValue("@productName",productName);
            //Command.Parameters.AddWithValue("@productPrice",productPrice);
            //Command.Parameters.AddWithValue("@productStatus",true);
            //Command.ExecuteNonQuery();
            //connetion.Close();
            //Console.Write("Ürün Eklemesi Başarılı!");



            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connetion = new SqlConnection("Data source=LAPTOP-83L42UFV\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connetion.Open();

            //SqlCommand command = new SqlCommand("select * from TblProduct",connetion);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            //connetion.Close();



            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId= int.Parse(Console.ReadLine());


            //SqlConnection connetion = new SqlConnection("Data source=LAPTOP-83L42UFV\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connetion.Open();

            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductId=@productId",connetion);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();


            //connetion.Close();
            //Console.WriteLine("Silme işlemi yapıldı!");


            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId= int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName= Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice= decimal.Parse(Console.ReadLine());




            //SqlConnection connetion = new SqlConnection("Data source=LAPTOP-83L42UFV\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");

            //connetion.Open();   

            //SqlCommand command= new SqlCommand("Update TblProduct set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId",connetion);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();


            //connetion.Close();
            //Console.WriteLine("Güncelleme Başarılı!");


            #endregion

            Console.Read();



         
        }
    }
}
