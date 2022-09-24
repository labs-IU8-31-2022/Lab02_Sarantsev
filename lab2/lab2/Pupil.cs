using System;
namespace lab2
{
    public class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil is study");
        }
        public virtual void Read()
        {
            Console.WriteLine("Pupil is read");
        }
        public virtual void Write()
        {
            Console.WriteLine("Pupil is write");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Pupil is relax");
        }
    }
    public class ExcellentPupil: Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"Excellent pupil ({Name}) studying excellent");
        }
        public override void Read()
        {
            Console.WriteLine($"Excellent pupil ({Name}) reading excellent");
        }
        public override void Write()
        {
            Console.WriteLine($"Excellent pupil ({Name}) writing excellent");
        }
        public override void Relax()
        {
            Console.WriteLine($"Excellent pupil ({Name}) relaxing excellent");
        }
        private string name_;
        public string Name
        {
            get => name_;
            set
            {
                name_ = value;
            }
        }
    }
    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"Good pupil ({Name}) studying good");
        }
        public override void Read()
        {
            Console.WriteLine($"Good pupil ({Name}) reading good");
        }
        public override void Write()
        {
            Console.WriteLine($"Good pupil ({Name}) writing good");
        }
        public override void Relax()
        {
            Console.WriteLine($"Good pupil ({Name}) relaxing good");
        }
        private string name_;
        public string Name
        {
            get => name_;
            set
            {
                name_ = value;
            }
        }
    }
    public class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine($"Bad pupil ({Name}) studying bad");
        }
        public override void Read()
        {
            Console.WriteLine($"Bad pupil ({Name}) reading bad");
        }
        public override void Write()
        {
            Console.WriteLine($"Bad pupil ({Name}) writing bad");
        }
        public override void Relax()
        {
            Console.WriteLine($"Bad pupil ({Name}) relaxing bad");
        }
        private string name_;
        public string Name
        {
            get => name_;
            set
            {
                name_ = value;
            }
        }
    }

}

