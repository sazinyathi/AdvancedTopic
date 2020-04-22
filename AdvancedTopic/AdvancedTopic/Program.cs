using AdvancedTopic.Delegates;
using AdvancedTopic.Lamba;
using AdvancedTopic.Model;
using Generic;
using System;
using System.Linq;

namespace AdvancedTopic
{
    class Program
    {
        // public delegate TResult Func<in T1,in T2, out TResult>(T1 arg1,T2 arg2);
        static void Main(string[] args)
        {
            int number1 = 5;
            // Lamba 
            Func<int, int> squareOfNumber = i => number1 * number1;
            Console.WriteLine(squareOfNumber);

            var lambaDemo = new LambaDemo();
            var listOFBooks =lambaDemo.GetBooks().Where(x => x.Price < 10).ToList();

            Func<int, int, int> add = Sum;
            Func<int, int, int> minus = Subtract;
            int result = minus(5, 3);
            Console.WriteLine(result);
            var _doorProcessor = new UnlockDoorProcessor();
            var _door = new Door();
            _door.KeyNumber = "MY121HN";
            Func<Door, string> processor1 = _doorProcessor.UnclockDoor;
            processor1 += OpenDoorWithRemote;
            var dd = processor1(_door);



            Console.ReadLine();



            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += CustomerFilter;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            processor.Process("hhh", filterHandler);

            var nullable = new Nullables<int>();
            var genericInitializerObject = new GenericInitializerObject<Student>();
            var student = genericInitializerObject.CreateInitializerObjectGeneric();
            student.Name = "Sazi";
            student.Surname = "Nyathi";
            var results = nullable.GetVaueOrDefault();

            var number = new GenericList<int>();
            number.Add(10);

            var students = new GenericList<Student>();
            students.Add(student);

            var studentDictinary = new GenericDictionary<int, Student>();

            studentDictinary.Add(1, student);

        }

        static string OpenDoorWithRemote(Door door)
        {
            return "Open Door With Remote Control";
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }


        static int Subtract(int x, int y)
        {
            return x - y;
        }
        public  static void CustomerFilter(Photo photo)
        {
            Console.WriteLine("Customer Filter");
        }
    }
}
