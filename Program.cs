using System;
using System.Collections;
using System.Collections.Generic;

namespace Non_generic.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = new List<int>();

            //nums.Add(5);
            //nums.Add(55);
            //nums.Add(53);
            //nums.Add(9);

            //List<string> words = new List<string>();

            //words.Add("sdfgh");
            //words.Add("tgrgghb");
            //words.Add("hghberghgth");
            //words.Add("johbtjbtoibkhbtrn");

            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.WriteLine(nums.[i]);
            //}

            //if (nums.Count == 4)
            //{
            //    Console.WriteLine("List count is {0}",nums.Count );
            //}

            //List<Person> people = new List<Person>();

            //Person person1 = new Person();
            //person1.Name = "Sadiq";
            //person1.Id = 5;
            //person1.Email="ramil@gmail.com";

            //Person person2 = new Person
            //{
            //    Id = 6,
            //    Name = "ramil",
            //    Email = "ramil@gmail.com"
            //};

            //people.Add(new Person { Id = 1, Name = "Orxan", Email = "orxan@gmail.com" });
            //people.Add(new Person { Id = 2, Name = "Cavidan", Email = "cavidan@gmail.com" });
            //people.Add(new Person { Id = 3, Name = "Ilkin", Email = "ilkin@gmail.com" });
            //people.Add(new Person { Id = 4, Name = "Nermin", Email = "nermin@gmail.com" });



            //GetStudents(people);

            //var result = GetPersonByName(people, "Orxan");
            //Console.WriteLine(result.Name + "-" + result.Id + "-" + result.Email);




            //Hashtable datas = new Hashtable();

            //datas.Add(1,"Togrul");
            //datas.Add(2, "Fidan");
            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}


            //SortedList datas = new SortedList();
            //datas.Add(1,"Togrul");
            //datas.Add(5,"Fidan");
            //datas.Add(3,"Seid");
            //datas.Add(2,"Esqin");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}


            //SortedList<int, string> datas = new SortedList<int, string>();

            //datas.Add(6, "Azer");
            //datas.Add(4, "Huseyn");

            //foreach (KeyValuePair<int,string> item in datas)
            //{
            //    Console.WriteLine(item.Key+"-"+item.Value);
            //}


            //ArrayList datas = new ArrayList();

            //datas.Add("Salam");
            //datas.Add(5);
            //datas.Add(true);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}



            //HashSet<int> datas = new HashSet<int>();

            //datas.Add(1);
            //datas.Add(3);
            //datas.Add(1);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}


            //Stack<int> datas = new Stack<int>();

            //datas.Push(1);
            //datas.Push(22);
            //datas.Push(18);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}


            //Queue<int> datas = new Queue<int>();

            //datas.Enqueue(1);
            //datas.Enqueue(22);
            //datas.Enqueue(18);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}


            Dictionary<string, string> datas = new Dictionary<string, string>();

            datas.Add("Admin", "Orxan");
            datas.Add("Member", "Mirsamir");
            datas.Add("Superadmin", "Cavid");

            foreach ( KeyValuePair<string,string> item in datas)
            {
                Console.WriteLine($"Name:{item.Value}, Role:{item.Key}");
            }


            
        }

        //public static Person GetPersonByName(List<Person>people,string name)
        //{
        //    var person = people.Find(m => m.Name == name);
        //    return person;
        //}



        //public static void GetStudents(List<Person>students)
        //{
        //    foreach (var stu in students)
        //    {
        //        Console.WriteLine("Students : Id-{0}, Name -{1}, Email - {2}",stu.Id, stu.Name, stu.Email);
        //    }
        //}



        //public static void GetNumbers(List<Person>students)
        //{
        //    foreach (var item in students)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public class Person
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public string Email { get; set; }
    }
    }
} 

