using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


using Genesis.Infrastructure.Data;
using Genesis.Domain.model;


namespace TestConsole
{
    public class AppData
    {


        public static void InitCompanyData(GenesisContext context)
        {
            try
            {
                //hejehj
                var adr = new Address("Nejlikegatan 3", "70353", "Örebro");
                var comp1  = context.Companies.Find("o1");
                if (comp1 != null)
                {
                    context.Companies.Remove(comp1);

                    context.SaveChanges();
                }
                var comp = new Company("o1", "n1", "a@b.com", "p1", adr);
                var dep1 = new Department("Olaigatan", adr, "phone1");
                dep1.AddOpenHoursOfDay(DayOfWeek.Monday, TimeSpan.FromHours(8), TimeSpan.FromHours(16));
                dep1.AddOpenHoursOfDay(DayOfWeek.Tuesday, TimeSpan.FromHours(8), TimeSpan.FromHours(16));
                dep1.AddOpenHoursOfDay(DayOfWeek.Wednesday, TimeSpan.FromHours(8), TimeSpan.FromHours(16));
                dep1.AddOpenHoursOfDay(DayOfWeek.Friday, TimeSpan.FromHours(8), TimeSpan.FromHours(16));
                dep1.AddOpenHoursOfDay(DayOfWeek.Saturday, TimeSpan.FromHours(10), TimeSpan.FromHours(15));
                dep1.AddExceptionDay(new DateTime(2018, 2, 24));
                dep1.AddExceptionDay(new DateTime(2018, 2, 28));
                comp.Departments.Add(dep1);
                context.Companies.Add(comp);
                context.SaveChanges();
            }
            catch (Exception ex )
            {

            }

        }

        public static void InitCompanyDataOrg(GenesisContext context)
        {
            try
            {
                var adr = new Address("Nejlikegatan 3", "70353", "Örebro");
                var adr2 = new Address("Nejlikegatan 3", "70353", "Örebro");
                //context.Database.EnsureCreated();

                var comp = new Company("o1", "n1", "a@b.com", "p1", adr);
                comp = context.Companies.FirstOrDefault(c => c.OrgNumber == comp.OrgNumber);
                if (comp != null)
                {
                    context.Set<Company>().Remove(comp);
                    //context.SaveChanges();
                }

                comp = new Company("o1", "n1", "a@b.com", "p1", adr);

                /*
                                var cat1 = new Category(0, 0, "Tårta", "d1");
                                var cat2 = new Category(0, 0, "Fikabröd", "d2");
                                var cat3 = new Category(0, 0, "SM Tårtor", "d3");

                                var info = new ProductDetailInfo("Storlek", TypeEnum.StringType);
                                cat1.ProductDetailInfos.Add(info);
                                var pris = new ProductDetailInfo("Pris", TypeEnum.DoubleType);
                                cat1.ProductDetailInfos.Add(pris);
                                cat2.ProductDetailInfos.Add(pris);
                                cat2.ProductDetailInfos.Add(info);
                                cat3.ProductDetailInfos.Add(pris);
                                cat3.ProductDetailInfos.Add(info);

                                var products1 = new List<Product>() {
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

                                 var products2 = new List<Product>() {
                                new Product("Kanelbullar", "Vetedeg, kanel", "Kanelbulle.jpg", 100, "supplierId"),
                                new Product("Kardemummabullar", "Vetedeg, kardemumma, mandelmassa", "Kanelbulle.jpg", 100, "supplierId"),
                                new  Product("Blåbärsbulle", "Vetedeg, blåbärssylt, vaniljkräm", "blabarsbulle.png", 100, "supplierId"),
                                new Product("Winerbröd hallon", "Spandau med hallonsylt", "spandaujam.jpg", 100, "supplierId"),
                                new  Product("Wienerbröd choklad", "Spandau med choklad", "spandau.jpg", 100, "supplierId"),
                                new  Product("Desireebulle", "Vetebulle fylld med vaniljgrädde", "Desireebulle.jpg", 100, "supplierId"),
                                new  Product("Krämbulle", "Vetedeg med vanilkräm", "krambulle.jpg", 100, "supplierId")
                                };
                                var products3 = new List<Product>() {
                                new Product("SM tårta skagen", "Smörgåsårta med handskalde räkor, grönsaker & skagenröra", "smtarta.jpg", 100, "supplierId"),
                                new Product("SM tårta Skinka", "Smörgåstårta med rökt skinka, skinkröra & grönsaker", "smtarta.jpg", 100, "supplierId"),
                                new Product("SM tårta Kyckling curry", "Curry, kyckling & grönsaker", "smtarta.jpg", 100, "supplierId")
                                };
                                var groupKey = products1.FirstOrDefault().ProductDetails.Select(s => s.GroupKey).FirstOrDefault();
                                ProductDetail pd = new ProductDetail(groupKey, "Storlek", "10 personer");
                                products1.FirstOrDefault().ProductDetails.Add(pd);
                                ProductDetail pd2 = new ProductDetail(groupKey, "Pris", "249");
                                products1.FirstOrDefault().ProductDetails.Add(pd2);
                                cat1.Products.AddRange(products1);
                                cat2.Products.AddRange(products2);
                                cat3.Products.AddRange(products3);
                                comp.Categories.AddRange(new List<Category>() { cat1, cat2, cat3 });
                                var adr1 = new Address("s1", "p1", "c1");
                                var dep1 = new Department("Olaigatan", adr1, "phone1");
                                dep1.AddOpenHoursOfDay(DayOfWeek.Monday, TimeSpan.FromHours(8), TimeSpan.FromHours(16));
                                dep1.AddOpenHoursOfDay(DayOfWeek.Tuesday, TimeSpan.FromHours(8), TimeSpan.FromHours(16));
                                dep1.AddOpenHoursOfDay(DayOfWeek.Wednesday, TimeSpan.FromHours(8), TimeSpan.FromHours(16));
                                dep1.AddOpenHoursOfDay(DayOfWeek.Friday, TimeSpan.FromHours(8), TimeSpan.FromHours(16));
                                dep1.AddOpenHoursOfDay(DayOfWeek.Saturday, TimeSpan.FromHours(10), TimeSpan.FromHours(15));
                                dep1.AddExceptionDay(new DateTime(2018, 2, 24));
                                dep1.AddExceptionDay(new DateTime(2018, 2, 28));
                                comp.Departments.Add(dep1);
                                var dep2 = new Department("Stallbacken", adr2, "phone2");
                                dep2.AddOpenHoursOfDay(DayOfWeek.Monday, TimeSpan.FromHours(8), TimeSpan.FromHours(19));
                                dep2.AddOpenHoursOfDay(DayOfWeek.Tuesday, TimeSpan.FromHours(8), TimeSpan.FromHours(19));
                                dep2.AddOpenHoursOfDay(DayOfWeek.Wednesday, TimeSpan.FromHours(8), TimeSpan.FromHours(19));
                                dep2.AddOpenHoursOfDay(DayOfWeek.Friday, TimeSpan.FromHours(8), TimeSpan.FromHours(19));
                                dep2.AddOpenHoursOfDay(DayOfWeek.Saturday, TimeSpan.FromHours(10), TimeSpan.FromHours(18));
                                dep2.AddExceptionDay(new DateTime(2018, 2, 24));
                                dep2.AddExceptionDay(new DateTime(2018, 2, 26));
                                comp.Departments.Add(dep2);
                                var NewOrder = new Order("customerID1", "o1", new DateTime(2018, 3, 18), adr1, new DateTime(2018, 3, 25));
                                var newOrderDetail = new OrderDetail(groupKey, "Äppelpaj", "bästa äppelpajen", 19.90, "Gabriel kommentar", 4);
                                NewOrder.AddDetail(newOrderDetail);
                                comp.Orders.Add(NewOrder);
                                */
                //context.Companies.Add(comp);
                var comp2 = new Company("o2", "n1", "a@b.com", "p1", adr);
                //comp2.Inactive = true;
                context.Companies.Add(comp2);
                context.SaveChanges();
            }
            catch (Exception exp)
            {
                var xx = exp.Message;
            }
        }


        }
    }
