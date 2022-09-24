using System;
namespace lab2
{
    public class Progam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 1");
            ExcellentPupil p1 = new ExcellentPupil();
            p1.Name = "pupil1";
            GoodPupil p2 = new GoodPupil();
            p2.Name = "pupil2";
            ClassRoom test_class = new ClassRoom(p1, p2);
            test_class.studyInfo();
            test_class.readInfo();
            test_class.writeInfo();
            test_class.relaxInfo();
            Console.WriteLine("TASK 2");
            Car car = new Car(15, 15, 25000, 120, 2000, "car", 4);
            Plane plane = new Plane(15, 17, 100000, 250, 1990, 250, 150);
            Ship ship = new Ship(16, 18, 250000, 200, 2000, "port", 100);
            car.Print();
            plane.Print();
            ship.Print();
            Console.WriteLine("TASK 3");
            Console.WriteLine("Enter a key: ");
            int input_key;
            input_key = Convert.ToInt32(Console.ReadLine());
            switch(input_key)
            {
                case 987654321:
                    ProDocumentWorker worker1 = new ProDocumentWorker();
                    worker1.CheckKey(input_key);
                    break;
                case 126789356:
                    ExpertDocumentWorker worker2 = new ExpertDocumentWorker();
                    worker2.CheckKey(input_key);
                    break;
                default:
                    DocumentWorker worker3 = new DocumentWorker();
                    Console.WriteLine("Wrong key, can use only DocumentWorker");
                    break;
            }
        }
    }
}

