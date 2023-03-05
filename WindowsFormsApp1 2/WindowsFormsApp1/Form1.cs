using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 3, 2, 5, 4, 7, 6, 5 };
            foreach (var row in nums)
            { }
            var result1 = from num in nums
                          where num >= 5
                          select num;
            Console.WriteLine(string.Join(",", result1));

            var result2 = from num in nums
                          where num >= 3
                          && num <= 5 
                          || num == 7
                          select num;
            Console.WriteLine("result2=" + string.Join(",", result2));

            var result3 = from num in nums
                          where num >= 3
                          && num <= 5
                          || num == 7
                          orderby num
                          select num;
            Console.WriteLine("result3=" + string.Join(",", result3));

            var result4 = from num in nums
                          where num >= 3
                          && num <= 5
                          || num == 7
                          orderby num descending
                          select num;
            Console.WriteLine("result4=" + string.Join(",", result4));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] values = { "A", "BB", "CCC", "DDDD", "EEEEE", "aBC" };

            //全件
            var result1 = from s in values
                          select s;
            Console.WriteLine("result1=" + string.Join(",", result1));

            //検索条件あり　大文字小文字関係あり
            var result2 = from s in values
                          where s.Contains("a")
                          select s;
            Console.WriteLine("result2=" + string.Join(",", result2));

            //検索条件あり　大文字小文字関係なし　小文字比較
            var result3 = from s in values
                          where s.ToLower().Contains("a")
                          select s;
            Console.WriteLine("result3=" + string.Join(",", result3));

            //複合条件AND
            var result4 = from s in values
                          where s.ToLower().Contains("a")
                          && s.Length > 2
                          select s;
            Console.WriteLine("result4=" + string.Join(",", result4));

            //複合条件OR
            var result5 = from s in values
                          where s.ToLower().Contains("a")
                          || s.Length > 2
                          select s;
            Console.WriteLine("result5=" + string.Join(",", result5));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var products = new List<Product>();
            products.Add(new Product(10, "p10A", 300));
            products.Add(new Product(20, "p20", 300));
            products.Add(new Product(30, "x301A", 200));
            products.Add(new Product(40, "P40", 500));

            var result1 = from p in products
                          where p.ProductName[0] == 'p'
                          select p;
            foreach (var val in result1)
            {
                Console.WriteLine(
                    $"result1 id={val.ProductId} name={val.ProductName} price={val.Price}");
            }

            //大文字小文字の区別をなくす
            var result2 = from p in products
                          where p.ProductName.ToLower()[0] == 'p'
                          select p;
            foreach (var val in result2)
            {
                Console.WriteLine(
                    $"result2 id={val.ProductId} name={val.ProductName} price={val.Price}");
            }

            //昇順
            var result3 = from p in products
                          where p.ProductName.ToLower()[0] == 'p'
                          orderby p.Price
                          select p;
            foreach (var val in result3)
            {
                Console.WriteLine(
                    $"result3 id={val.ProductId} name={val.ProductName} price={val.Price}");
            }

            //降順
            var result4 = from p in products
                          where p.ProductName.ToLower()[0] == 'p'
                          orderby p.Price descending
                          select p;
            foreach (var val in result4)
            {
                Console.WriteLine(
                    $"result4 id={val.ProductId} name={val.ProductName} price={val.Price}");
            }

            //並び替え複数
            var result5 = from p in products
                          where p.ProductName.ToLower()[0] == 'p'
                          orderby p.Price descending, p.ProductId
                          select p;
            foreach (var val in result5)
            {
                Console.WriteLine(
                    $"result5 id={val.ProductId} name={val.ProductName} price={val.Price}");
            }

            //必要な項目だけ取得
            var result6 = from p in products
                          where p.ProductName.ToLower()[0] == 'p'
                          orderby p.Price descending, p.ProductId
                          select p.ProductName;
            foreach (var val in result6)
            {
                Console.WriteLine(
                    $"result6 name={val} ");
            }

            //必要な項目だけ取得　複数パターン
            var result7 = from p in products
                          where p.ProductName.ToLower()[0] == 'p'
                          orderby p.Price descending, p.ProductId
                          select new { p.ProductName, p.Price };
            foreach (var val in result7)
            {
                Console.WriteLine(
                    $"result7 name={val.ProductName} price={val.Price}");
            }

            //別名を付ける
            var result8 = from p in products
                          where p.ProductName.ToLower()[0] == 'p'
                          orderby p.Price descending, p.ProductId
                          select new { p.ProductName, AAA = p.Price };
            foreach (var val in result8)
            {
                Console.WriteLine(
                    $"result8 name={val.ProductName} price={val.AAA}");
            }

            var result9 = from p in products
                          where p.ProductName.ToLower()[0] == 'p'
                          orderby p.Price descending, p.ProductId
                          select new { p.ProductName, Price =  p.Price + "円" };
            foreach (var val in result9)
            {
                Console.WriteLine(
                    $"result9 name={val.ProductName} price={val.Price}");
            }

            //別のクラスに置き換える
            var result10 = from p in products
                           where p.ProductName.ToLower()[0] == 'p'
                           orderby p.Price descending, p.ProductId
                           select new ProductDto(p.ProductId.ToString(), p.ProductName);
            foreach (var val in result10)
            {
                Console.WriteLine(
                    $"result10 {val}");
            }

            //別のクラスに置き換える
            var result11 = from p in products
                           where p.ProductName.ToLower()[0] == 'p'
                           orderby p.Price descending, p.ProductId
                           select new ProductDto(p);
            foreach (var val in result11)
            {
                Console.WriteLine(
                    $"result11 {val}");
            }

            var result12 = from p in products
                           where p.ProductName.ToLower()[0] == 'p'
                           orderby p.Price descending, p.ProductId
                           select new ProductEntity
                           {
                               ProductId = p.ProductId.ToString(),
                               ProductName = p.ProductName,
                           };
            foreach (var val in result12)
            {
                Console.WriteLine(
                    $"result12 {val}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var products = new List<Product>();
            products.Add(new Product(10, "p10A", 300));
            products.Add(new Product(20, "p20", 300));
            products.Add(new Product(30, "x301A", 200));
            products.Add(new Product(40, "P40", 500));

            //大文字小文字の区別をなくす
            var result2 = from p in products
                          where p.ProductName.ToLower()[0] == 'p'
                          select p;
            foreach (var val in result2)
            {
                Console.WriteLine(
                    $"result2 id={val.ProductId} name={val.ProductName} price={val.Price}");
            }

            var result3 = from p in products
                          let wk = p.ProductName.ToLower()
                          where wk[0] == 'p'
                          select p;
            foreach (var val in result3)
            {
                Console.WriteLine(
                    $"result3 id={val.ProductId} name={val.ProductName} price={val.Price}");
            }

            var result4 = from p in products
                          let wk = p.ProductName.ToLower()
                          where wk[0] == 'p'
                          let MyPrice = (p.Price / 2 * 1.08)
                          select new { p.ProductName, MyPrice };
            foreach (var val in result4)
            {
                Console.WriteLine(
                    $"result4 name={val.ProductName} price={val.MyPrice}");
            }

            string[] strings =
{
            "A penny saved is a penny earned.",
            "The early bird catches the worm.",
            "The pen is mightier than the sword."
        };

            // Split the sentence into an array of words
            // and select those whose first letter is a vowel.
            var earlyBirdQuery =
                from sentence in strings
                let words = sentence.Split(' ')
                from word in words
                //let w = word.ToLower()
                //where w[0] == 'a' || w[0] == 'e'
                //    || w[0] == 'i' || w[0] == 'o'
                //    || w[0] == 'u'
                select word;

            // Execute the query.
            foreach (var v in earlyBirdQuery)
            {
                //Console.WriteLine("\"{0}\" starts with a vowel", v);
                Console.WriteLine(v);
            }

            List<string> csvs = new List<string>();
            csvs.Add("AAA,BBB,CCC");
            csvs.Add("DDD,EEE,FFF");
            csvs.Add("111,222,333");
            var result5 = from csv in csvs
                          let items = csv.Split(',')
                          from item in items
                          select item;
            foreach (var val in result5)
            {
                Console.WriteLine(val);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var products = new List<Product>();
            products.Add(new Product(10, "p10A", 300));
            products.Add(new Product(20, "p20", 300));
            products.Add(new Product(30, "x301A", 200));
            products.Add(new Product(40, "P40", 500));
            products.Add(new Product(50, "P50", 200));

            var result1 = from p in products
                          group p by p.Price;
            foreach (var group in result1)
            {
                //ここはグループごとにループする

                Console.WriteLine("group key=" + group.Key);

                foreach (var row in group)
                {
                    Console.WriteLine($"id={row.ProductId} name={row.ProductName} price={row.Price}");
                }
            }

            Console.WriteLine("-----------------result2-------------------");
            var result2 = from p in products
                          where p.Price > 250
                          orderby p.Price descending
                          group p by p.Price;
            foreach (var group in result2)
            {
                //ここはグループごとにループする

                Console.WriteLine("group key=" + group.Key);

                foreach (var row in group)
                {
                    Console.WriteLine($"id={row.ProductId} name={row.ProductName} price={row.Price}");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var products = new List<Product>();
            products.Add(new Product(10, "p200", 200));
            products.Add(new Product(20, "p200", 200));
            products.Add(new Product(30, "p200", 220));
            products.Add(new Product(40, "p200", 220));
            products.Add(new Product(50, "p200", 300));
            products.Add(new Product(60, "p300", 320));
            products.Add(new Product(70, "p400", 320));

            var result1 = from p in products
                          group p by new { p.ProductName, p.Price };
            foreach (var group in result1)
            {
                //ここはグループごとにループする

                Console.WriteLine("group key=" + group.Key);

                foreach (var row in group)
                {
                    Console.WriteLine($"id={row.ProductId} name={row.ProductName} price={row.Price}");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var sales = new List<Sale>();
            sales.Add(new Sale(10,1, 100, Convert.ToDateTime("2020/12/12 12:12:12")));
            sales.Add(new Sale(11, 1, 100, Convert.ToDateTime("2020/12/13 12:12:12")));
            sales.Add(new Sale(12, 1, 101, Convert.ToDateTime("2020/12/12 12:12:12")));

            var saleItems = new List<SaleItem>();
            saleItems.Add(new SaleItem(10, 1, 1, 2));
            saleItems.Add(new SaleItem(10, 1, 2, 3));
            saleItems.Add(new SaleItem(11, 1, 1, 5));
            saleItems.Add(new SaleItem(12, 1, 1, 4));
            saleItems.Add(new SaleItem(12, 1, 3, 1));

            var result1 = from a in sales
                          join b in saleItems
                          on a.SaleId equals b.SaleId
                          select new
                          {
                              a.SaleId,
                              a.CustomerId,
                              a.SaleDateTime,
                              b.ProductId,
                              b.SaleCount,
                          };

            foreach (var val in result1)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("-------------result2--------------------");
            var result2 = from a in sales
                          join b in saleItems
                          on a.SaleId equals b.SaleId
                          where a.SaleId >= 11
                          orderby b.SaleCount 
                          select new
                          {
                              a.SaleId,
                              a.CustomerId,
                              a.SaleDateTime,
                              b.ProductId,
                              b.SaleCount,
                          };

            foreach (var val in result2)
            {
                Console.WriteLine(val);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var sales = new List<Sale>();
            sales.Add(new Sale(10, 1, 100, Convert.ToDateTime("2020/12/12 12:12:12")));
            sales.Add(new Sale(11, 1, 100, Convert.ToDateTime("2020/12/13 12:12:12")));
            sales.Add(new Sale(12, 1, 101, Convert.ToDateTime("2020/12/12 12:12:12")));

            var saleItems = new List<SaleItem>();
            saleItems.Add(new SaleItem(10, 1, 1, 2));
            saleItems.Add(new SaleItem(10, 99, 2, 3));
            saleItems.Add(new SaleItem(11, 1, 1, 5));
            saleItems.Add(new SaleItem(12, 1, 1, 4));
            saleItems.Add(new SaleItem(12, 1, 3, 1));

            var result1 = from a in sales
                          join b in saleItems
                          on new { a.SaleId, a.No }
                          equals new { b.SaleId, b.No }
                          select new
                          {
                              a.SaleId,
                              a.CustomerId,
                              a.SaleDateTime,
                              b.ProductId,
                              b.SaleCount,
                          };

            foreach (var val in result1)
            {
                Console.WriteLine(val);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var sales = new List<Sale>();
            sales.Add(new Sale(10, 1, 100, Convert.ToDateTime("2020/12/12 12:12:12")));
            sales.Add(new Sale(11, 1, 100, Convert.ToDateTime("2020/12/13 12:12:12")));
            sales.Add(new Sale(12, 1, 101, Convert.ToDateTime("2020/12/12 12:12:12")));

            var saleItems = new List<SaleItem>();
            saleItems.Add(new SaleItem(10, 1, 1, 2));
            saleItems.Add(new SaleItem(10, 1, 2, 3));
            //saleItems.Add(new SaleItem(11, 1, 1, 5));
            saleItems.Add(new SaleItem(12, 1, 1, 4));
            saleItems.Add(new SaleItem(12, 1, 3, 1));

            var result1 = from a in sales
                          join b in saleItems
                          on a.SaleId equals b.SaleId into bb
                          from b in bb.DefaultIfEmpty()
                          select new
                          {
                              a.SaleId,
                              a.CustomerId,
                              a.SaleDateTime,
                              ProductId = b?.ProductId ?? -1,
                              SaleCount = b?.SaleCount ?? 0,
                          };

            foreach (var val in result1)
            {
                Console.WriteLine(val);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var nums = new List<int> { 1, 4, 8, 5, 10, 3, 2 };

            var result1 = nums.Where(x => x >= 5);
            Console.WriteLine("result1=" + string.Join(",", result1));

            //IEnumerable
            //Enumerable

            var result2 = nums.Where(x => x >= 5);
            var result2_1 = result2.Where(x => x < 10);
            Console.WriteLine("result2_1=" + string.Join(",", result2_1));

            //平均
            var result3 = nums.Average();
            Console.WriteLine("result3=" + string.Join(",", result3));

            //最大，最小，合計
            var result4 = nums.Max();
            Console.WriteLine("result4=" + string.Join(",", result4));
            var result5 = nums.Min();
            Console.WriteLine("result5=" + string.Join(",", result5));
            var result6 = nums.Sum();
            Console.WriteLine("result6=" + string.Join(",", result6));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string[] values = { "A", "BB", "CCC", "DDDD", "EEEEE", "ABC" };

            //文字数の平均
            var result1 = values.Average(x => x.Length);
            Console.WriteLine("result1=" + string.Join(",", result1));

            var result2 = values.Max(x => x.Length);
            Console.WriteLine("result2=" + string.Join(",", result2));

            var result3 = values.Min(x => x.Length);
            Console.WriteLine("result3=" + string.Join(",", result3));

            var result4 = values.Sum(x => x.Length);
            Console.WriteLine("result4=" + string.Join(",", result4));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var ints = new List<int> { 10, 20 };
            object[] objects = { 1, 2, "AAA", "BB", ints };

            var result1 = objects.OfType<int>();
            Console.WriteLine("result1=" + string.Join(",", result1));

            var result2 = objects.OfType<string>();
            Console.WriteLine("result2=" + string.Join(",", result2));

            var result3 = objects.OfType<List<int>>();
            foreach (var val in result3)
            {
                Console.WriteLine("result3=" + string.Join(",", val));
            }

            var result4 = objects.OfType<int>().Where(x => x >= 2);
            Console.WriteLine("result4=" + string.Join(",", result4));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var products = new List<Product>();
            products.Add(new Product(10, "p10A", 300));
            products.Add(new Product(20, "p20", 300));
            products.Add(new Product(30, "x301A", 200));
            products.Add(new Product(40, "P40", 500));
            products.Add(new Product(50, "P50", 200));

            //var l = from p in products
            //        where p.Price == 200
            //        select p;

            var result1 = products.Where(p => p.Price == 200);
            foreach (var val in result1)
            {
                Console.WriteLine($"result1: id={val.ProductId} name={val.ProductName} price={val.Price}");
            }

            //var l = from p in products
            //        where p.Price == 200
            //        select p.ProductId;

            var result2 = products.Where(p => p.Price == 200)
                                  .Select(p => p.ProductId);
            foreach (var val in result2)
            {
                Console.WriteLine($"result2: val={val}");
            }

            var result3 = products.Where(p => p.Price == 200)
                                 .Select(p => new { p.ProductId, p.ProductName });
            foreach (var val in result3)
            {
                Console.WriteLine($"result2: val={val}");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var products = new List<Product>();
            products.Add(new Product(10, "p10A", 300));
            products.Add(new Product(20, "p20", 300));
            products.Add(new Product(30, "x301A", 200));
            products.Add(new Product(40, "P40", 500));
            products.Add(new Product(50, "P50", 200));

            var result1 = products.Where(p => p.Price == 200).ToList();
            result1.ForEach(p => Console.WriteLine($"result1: id={p.ProductId}"));

            foreach (var val in result1)
            {
                Console.WriteLine($"result1: id={val.ProductId} name={val.ProductName} price={val.Price}");
            }

            var dtos = new List<ProductDto>();
            //foreach（次の２つは同じ意味）
            //書き方１
            result1.ForEach(x => dtos.Add(new ProductDto(x)));

            //書き方２
            foreach(var p in result1)
            {
                dtos.Add(new ProductDto(p));
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var products = new List<Product>();
            products.Add(new Product(10, "p10A", 300));
            products.Add(new Product(20, "p20", 300));
            products.Add(new Product(30, "x301A", 200));
            products.Add(new Product(40, "P40", 500));
            products.Add(new Product(50, "P50", 200));

            //配列に変換
            var arry = products.Where(x=>x.Price == 200).ToArray();

            //Listに変換
            var list = products.Where(x => x.Price == 200).ToList();

            //任意の型に変換
            var dtos = products.ConvertAll(x => new ProductDto(x));

            //クエリ式からListに変換
            var result1 = (from p in products
                          where p.Price == 200
                          select p).ToList();

            //intのリストをstringのリストに変換
            var nums = new List<int> { 1, 3, 5 };
            var strings = nums.ConvertAll(x => x.ToString());

            var result2 = (from n in nums
                           select n.ToString()).ToList();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var products = new List<Product>();
            products.Add(new Product(10, "p10A", 300));
            products.Add(new Product(20, "p20", 300));
            products.Add(new Product(30, "x301A", 200));
            products.Add(new Product(40, "P40", 500));
            products.Add(new Product(50, "P50", 200));

            var result1 = products.OrderBy(x => x.Price);
            foreach (var val in result1)
            {
                Console.WriteLine($"result1: id={val.ProductId} name={val.ProductName} price={val.Price}");
            }

            var result2 = products.OrderByDescending(x => x.Price);
            foreach (var val in result2)
            {
                Console.WriteLine($"result2: id={val.ProductId} name={val.ProductName} price={val.Price}");
            }

            var result3 = products.OrderBy(x => x.Price).ThenBy(x => x.ProductId);
            foreach (var val in result3)
            {
                Console.WriteLine($"result3: id={val.ProductId} name={val.ProductName} price={val.Price}");
            }

            var result4 = products.OrderBy(x => x.Price).ThenByDescending(x => x.ProductId);
            foreach (var val in result4)
            {
                Console.WriteLine($"result4: id={val.ProductId} name={val.ProductName} price={val.Price}");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var products = new List<Product>();
            products.Add(new Product(10, "p10A", 300));
            products.Add(new Product(20, "p20", 300));
            products.Add(new Product(30, "x301A", 200));
            products.Add(new Product(40, "P40", 500));
            products.Add(new Product(50, "P50", 200));

            var result1 = from p in products
                          group p by p.Price;
            foreach (var group in result1)
            {
                //ここはグループごとにループする

                Console.WriteLine("group key=" + group.Key);

                foreach (var row in group)
                {
                    Console.WriteLine($"id={row.ProductId} name={row.ProductName} price={row.Price}");
                }
            }

            Console.WriteLine("-------------------------------------");

            var result2 = products.GroupBy(x => x.Price);
            foreach (var group in result2)
            {
                //ここはグループごとにループする

                Console.WriteLine("group key=" + group.Key);

                foreach (var row in group)
                {
                    Console.WriteLine($"id={row.ProductId} name={row.ProductName} price={row.Price}");
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var products = new List<Product>();
            products.Add(new Product(10, "p200", 200));
            products.Add(new Product(20, "p200", 200));
            products.Add(new Product(30, "p200", 220));
            products.Add(new Product(40, "p200", 220));
            products.Add(new Product(50, "p200", 300));
            products.Add(new Product(60, "p300", 320));
            products.Add(new Product(70, "p400", 320));

            var result1 = from p in products
                          group p by new { p.ProductName, p.Price };
            foreach (var group in result1)
            {
                //ここはグループごとにループする

                Console.WriteLine("group key=" + group.Key);

                foreach (var row in group)
                {
                    Console.WriteLine($"id={row.ProductId} name={row.ProductName} price={row.Price}");
                }
            }

            Console.WriteLine("-------------------------------------");
            var result2 = products.GroupBy(x => new { x.ProductName, x.Price });
            foreach (var group in result2)
            {
                //ここはグループごとにループする

                Console.WriteLine("group key=" + group.Key);

                foreach (var row in group)
                {
                    Console.WriteLine($"id={row.ProductId} name={row.ProductName} price={row.Price}");
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //5を10回返却する
            var result1 = Enumerable.Repeat(5, 10);
            Console.WriteLine(string.Join(",", result1));

            //文字でもOK
            var result2 = Enumerable.Repeat("AAA", 10);
            Console.WriteLine(string.Join(",", result2));

            //34から7個の整数を返す
            var result3 = Enumerable.Range(34, 7);
            Console.WriteLine(string.Join(",", result3));

            //偶数のみを返す
            var result4 = Enumerable.Range(1, 10).Where(x => x % 2 == 0);
            Console.WriteLine(string.Join(",", result4));

            var result5 = Enumerable.Range(1, 10).Select(x => x * 10);
            Console.WriteLine(string.Join(",", result5));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string[] h1 = new string[] { "AAA", "BBB" };
            string[] h2 = new string[] { "AAA", "BBB" };

            Console.WriteLine(h1 == h2);
            Console.WriteLine(h1.Equals(h2));
            Console.WriteLine(h1.SequenceEqual(h2));

            var product1 = new List<Product>();
            product1.Add(new Product(10, "p10", 200));
            product1.Add(new Product(20, "p20", 300));

            var product2 = new List<Product>();
            product2.Add(new Product(10, "p10", 200));
            product2.Add(new Product(20, "p20", 300));

            var a = new Product(1, "", 1);
            var b = new Product(1, "", 1);
            Console.WriteLine("a.Equals(b)" + a.Equals(b));
            Console.WriteLine("product1.SequenceEqual(product2)=" + product1.SequenceEqual(product2));
            Console.WriteLine("product1.Equals(product2)=" + product1.Equals(product2));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var nums1 = new int[] { 1, 2, 3, 4, 9, 5, 2, 4, 6 };
            var nums2 = new int[] { 3, 4, 2, 99, 2 };

            //重複をなくす
            var result1 = nums1.Distinct();
            Console.WriteLine(string.Join(",", result1));

            //両方にあるもの
            var result2 = nums1.Intersect(nums2);
            Console.WriteLine(string.Join(",", result2));

            //どちらかにあればとる
            var result3 = nums1.Union(nums2);
            Console.WriteLine(string.Join(",", result3));

            //nums1にだけある
            var result4 = nums1.Except(nums2);
            Console.WriteLine(string.Join(",", result4));

            //nums2にだけある
            var result5 = nums2.Except(nums1);
            Console.WriteLine(string.Join(",", result5));
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var nums = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 5, 2 };

            //5個スキップしたあとすべて取る
            var result1 = nums.Skip(5);
            Console.WriteLine(string.Join(",", result1));

            //最初から3個取る
            var result2 = nums.Take(3);
            Console.WriteLine(string.Join(",", result2));

            //4個スキップして3個取る
            var result3 = nums.Skip(4).Take(3);
            Console.WriteLine(string.Join(",", result3));

            //トップ３重複あり
            var result4 = nums.OrderByDescending(x => x).Take(3);
            Console.WriteLine(string.Join(",", result4));

            //トップ３重複なし
            var result5 = nums.Distinct().OrderByDescending(x => x).Take(3);
            Console.WriteLine(string.Join(",", result5));

            //3以上がでてきたらそれ以降全部取る
            var result6 = nums.SkipWhile(x => x < 3);
            Console.WriteLine(string.Join(",", result6));

            //5以上がでてくるまで全部取る
            var result7 = nums.TakeWhile(x => x < 5);
            Console.WriteLine(string.Join(",", result7));
        }

        private void button23_Click(object sender, EventArgs e)
        {
            var nums = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 6, 2 };

            //すべてTureの時Ture
            var result1 = nums.All(x => x >= 1);
            Console.WriteLine(string.Join(",", result1));

            var result2 = nums.All(x => x >= 2);
            Console.WriteLine(string.Join(",", result2));

            //存在チェック
            var result3 = nums.Any(x => x == 2);
            Console.WriteLine(string.Join(",", result3));

            var result4 = nums.Any(x => x == 99);
            Console.WriteLine(string.Join(",", result4));
        }
    }
}
