using System;
using System.Collections.Generic;
using System.Text;

using Genesis.Infrastructure.Data;
using Genesis.Domain.model;
using System.Linq;

namespace TestConsole
{
    class HallsInfo
    {


        public static void Init(GenesisContext context)
        {
            try
            {


            var adrHalls = new Address("Engelbrektsgatan 12", "702 12", "Örebro");
            var adrOlai = new Address("Olaigatan 17a", "703 61", "Örebro");

                var comp1 = context.Companies.Find("5567569008");
            if (comp1 != null)
            {
                context.Companies.Remove(comp1);

                context.SaveChanges();
            }
            var comp = new Company("5567569008", "Konditorn i Örebro AB", "info@hallskonditori.se", "0196110766", adrHalls);
            var Olai = new Department("Olaigatan", adrOlai, "0196110766");
                Olai.AddOpenHoursOfDay(DayOfWeek.Monday, TimeSpan.FromHours(8), TimeSpan.FromHours(18));
                Olai.AddOpenHoursOfDay(DayOfWeek.Tuesday, TimeSpan.FromHours(8), TimeSpan.FromHours(18));
                Olai.AddOpenHoursOfDay(DayOfWeek.Wednesday, TimeSpan.FromHours(8), TimeSpan.FromHours(18));
                Olai.AddOpenHoursOfDay(DayOfWeek.Friday, TimeSpan.FromHours(8), TimeSpan.FromHours(16));
                Olai.AddOpenHoursOfDay(DayOfWeek.Saturday, TimeSpan.FromHours(10), TimeSpan.FromHours(16));
                Olai.AddExceptionDay(new DateTime(2018, 2, 24));
                Olai.AddExceptionDay(new DateTime(2018, 2, 28));
            comp.Departments.Add(Olai);
                var Stallis = new Department("Stallbacken", adrHalls, "0196110766");
                Stallis.AddOpenHoursOfDay(DayOfWeek.Monday, TimeSpan.FromHours(8), TimeSpan.FromHours(18));
                Stallis.AddOpenHoursOfDay(DayOfWeek.Tuesday, TimeSpan.FromHours(8), TimeSpan.FromHours(18));
                Stallis.AddOpenHoursOfDay(DayOfWeek.Wednesday, TimeSpan.FromHours(8), TimeSpan.FromHours(18));
                Stallis.AddOpenHoursOfDay(DayOfWeek.Friday, TimeSpan.FromHours(8), TimeSpan.FromHours(16));
                Stallis.AddOpenHoursOfDay(DayOfWeek.Saturday, TimeSpan.FromHours(10), TimeSpan.FromHours(16));
                Stallis.AddExceptionDay(new DateTime(2018, 2, 24));
                Stallis.AddExceptionDay(new DateTime(2018, 2, 28));
                comp.Departments.Add(Stallis);
                



                var catCake = new Category(Guid.Empty, 0, "Tårta", "d1");
                var catFika = new Category(Guid.Empty, 0, "Fikabröd", "d2");
                var catSmCake = new Category(Guid.Empty, 0, "SM Tårtor", "d3");

                var info = new ProductDetailInfo("Storlek", TypeEnum.StringType);
                catCake.ProductDetailInfos.Add(info);
                var pris = new ProductDetailInfo("Pris", TypeEnum.DoubleType);
                catCake.ProductDetailInfos.Add(pris);
                catFika.ProductDetailInfos.Add(pris);
                catFika.ProductDetailInfos.Add(info);
                catSmCake.ProductDetailInfos.Add(pris);
                catSmCake.ProductDetailInfos.Add(info);

                var prodCake = new List<Product>() {
                                new  Product("Princess", "Grädde, vaniljkräm, hallonsylt, anslag" , "princess.png" ,100, "supplierId"),
                                new Product("Prince", "Krämgrädde, chokladpenslad maräng, hallon, anslag", "prince.png", 100, "supplierId"),
                                new Product("Gräddtårta", "Grädde, hallongsylt, vaniljkräm, anslag", "graddtarta.png", 100, "supplierId"),
                                new Product("Sacher", "Choklad, aprikoskräm, chokladanslag", "sacher.png", 100, "supplierId"),
                                new Product("Fruktis", "Sylt, vaniljkräm, grädde, smörkräm", "fruktis.png", 100, "supplierId"),
                                new Product("Blåbär", "Blåbärsgrädde, vaniljkräm, blåbärssylt, anslag", "blueberry.png", 100, "supplierId"),
                                new Product("Spegel", "Chokladmousse, vaniljkräm, chokladglasyr, anslag", "spegel.png", 100, "supplierId"),
                                new Product("William", "Pärongrädde, vaniljkräm, päronbitar, anslag", "william.png", 100, "supplierId"),
                                new Product("Willma", "Hallongrädde, vaniljkräm, hela hallon, anslag", "willma.png", 100, "supplierId"),
                                };

                var prodFika = new List<Product>() {
                                new Product("Kanelbullar", "Vetedeg, kanel", "Kanelbulle.jpg", 100, "supplierId"),
                                new Product("Kardemummabullar", "Vetedeg, kardemumma, mandelmassa", "Kanelbulle.jpg", 100, "supplierId"),
                                new  Product("Blåbärsbulle", "Vetedeg, blåbärssylt, vaniljkräm", "blabarsbulle.png", 100, "supplierId"),
                                new Product("Winerbröd hallon", "Spandau med hallonsylt", "spandaujam.jpg", 100, "supplierId"),
                                new  Product("Wienerbröd choklad", "Spandau med choklad", "spandau.jpg", 100, "supplierId"),
                                new  Product("Desireebulle", "Vetebulle fylld med vaniljgrädde", "Desireebulle.jpg", 100, "supplierId"),
                                new  Product("Krämbulle", "Vetedeg med vanilkräm", "krambulle.jpg", 100, "supplierId")
                                };
                var prodSmCake = new List<Product>() {
                                new Product("SM tårta skagen", "Smörgåsårta med handskalde räkor, grönsaker & skagenröra", "smtarta.jpg", 100, "supplierId"),
                                new Product("SM tårta Skinka", "Smörgåstårta med rökt skinka, skinkröra & grönsaker", "smtarta.jpg", 100, "supplierId"),
                                new Product("SM tårta Kyckling curry", "Curry, kyckling & grönsaker", "smtarta.jpg", 100, "supplierId")
                                };

                //var groupKey = prodCake.FirstOrDefault().ProductDetails.Select(s => s.GroupKey).FirstOrDefault();

                int x = 0;




                                foreach(var item in prodCake)
                                {

                    x++;
                    ProductDetail pdS6 = new ProductDetail(x, "Storlek", "6 personer");
                                ProductDetail pdP6 = new ProductDetail(x, "Pris", "170");
                    x++;
                    ProductDetail pdS8 = new ProductDetail(x, "Storlek", "8 personer");
                                ProductDetail pdP8 = new ProductDetail(x, "Pris", "220");
                    x++;
                    ProductDetail pdS10 = new ProductDetail(x, "Storlek", "10 personer");
                                ProductDetail pdP10 = new ProductDetail(x, "Pris", "260");
                    x++;
                    ProductDetail pdS15 = new ProductDetail(x, "Storlek", "15 personer");
                                ProductDetail pdP15 = new ProductDetail(x, "Pris", "310");
                    x++;
                    ProductDetail pdS20 = new ProductDetail(x, "Storlek", "20 personer");
                                ProductDetail pdP20 = new ProductDetail(x, "Pris", "360");
                                item.ProductDetails.Add(pdS6);
                                item.ProductDetails.Add(pdP6);
                                item.ProductDetails.Add(pdS8);
                                item.ProductDetails.Add(pdP8);
                                item.ProductDetails.Add(pdS10);
                                item.ProductDetails.Add(pdP10);
                                item.ProductDetails.Add(pdS15);
                                item.ProductDetails.Add(pdP15);
                                item.ProductDetails.Add(pdS20);
                                item.ProductDetails.Add(pdP20);
                            }

                                foreach(var item in prodSmCake)
                                {
                    x++;
                    ProductDetail pdS6= new ProductDetail(x, "Storlek", "6 personer");
                                    ProductDetail pdP6SmCake = new ProductDetail(x, "Pris", "310");
                    x++;
                    ProductDetail pdS8 = new ProductDetail(x, "Storlek", "10-12 personer");
                                    ProductDetail pdP8SmCake = new ProductDetail(x, "Pris", "410");
                    x++;
                    ProductDetail pdS10_12 = new ProductDetail(x, "Storlek", "14-16 personer");
                                    ProductDetail pdP10_12SmCake = new ProductDetail(x, "Pris", "510");
                    x++;
                    ProductDetail pdS14_16 = new ProductDetail(x, "Storlek", "18-20 personer");
                                    ProductDetail pdP14_16SmCake = new ProductDetail(x, "Pris", "610");
                    x++;
                    ProductDetail pdS18_20 = new ProductDetail(x, "Storlek", "8 personer");
                                    ProductDetail pdP18_20SmCake = new ProductDetail(x, "Pris", "360");

                                    item.ProductDetails.Add(pdS6);
                                    item.ProductDetails.Add(pdP6SmCake);
                                    item.ProductDetails.Add(pdS8);
                                    item.ProductDetails.Add(pdP8SmCake);
                                    item.ProductDetails.Add(pdS10_12);
                                    item.ProductDetails.Add(pdP10_12SmCake);
                                    item.ProductDetails.Add(pdS14_16);
                                    item.ProductDetails.Add(pdP14_16SmCake);
                                    item.ProductDetails.Add(pdS18_20);
                                    item.ProductDetails.Add(pdP18_20SmCake);

                                }

                                foreach (var item in prodFika)
                                                {
                    x++;
                    ProductDetail pdS5Pack = new ProductDetail(x, "Storlek", "5 st");
                                    ProductDetail pdP5Pack = new ProductDetail(x, "Pris", "75");
                    x++;
                    ProductDetail pdS10Pack = new ProductDetail(x, "Storlek", "10 st");
                                    ProductDetail pdP10Pack = new ProductDetail(x, "Pris", "125");
                                    item.ProductDetails.Add(pdS5Pack);
                                    item.ProductDetails.Add(pdP5Pack);
                                    item.ProductDetails.Add(pdS10Pack);
                                    item.ProductDetails.Add(pdP10Pack);

                                }

                                catCake.Products.AddRange(prodCake);
                                catFika.Products.AddRange(prodFika);
                                catSmCake.Products.AddRange(prodSmCake);
                                comp.Categories.AddRange(new List<Category>() { catCake, catFika, catSmCake });
                                context.Companies.Add(comp);
                                context.SaveChanges();
            }
            catch (Exception ex )
            {

            }

} //initHalls 

    } // class 
} // namespace 
