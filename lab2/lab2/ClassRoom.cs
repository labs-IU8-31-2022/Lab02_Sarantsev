using System;
namespace lab2
{
    public class ClassRoom
    {
        private List<Pupil> pupils_ = new List<Pupil>();
        public ClassRoom(params Pupil[] pupils)
        {
            foreach (Pupil i in pupils)
            {
                pupils_.Add(i);
            }
        }
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            pupils_.Add(p1);
            pupils_.Add(p2);
            pupils_.Add(p3);
            pupils_.Add(p4);
        }
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            pupils_.Add(p1);
            pupils_.Add(p2);
            pupils_.Add(p3);
        }
        public ClassRoom(Pupil p1, Pupil p2)
        {
            pupils_.Add(p1);
            pupils_.Add(p2);
        }
        public void studyInfo()
        {
            Console.WriteLine("Study: ");
            foreach (Pupil p in pupils_)
            {
                p.Study();
            }
        }
        public void readInfo()
        {
            Console.WriteLine("Read: ");
            foreach (Pupil p in pupils_)
            {
                p.Read();
            }
        }
        public void writeInfo()
        {
            Console.WriteLine("Write: ");
            foreach (Pupil p in pupils_)
            {
                p.Write();
            }
        }
        public void relaxInfo()
        {
            Console.WriteLine("Relax: ");
            foreach (Pupil p in pupils_)
            {
                p.Relax();
            }
        }
    }
}

