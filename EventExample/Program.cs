using System;

namespace EventExample
{

    class ClassA
    {
        public ClassA(ClassB classB)
        {
            classB.Event += Dosomething;
        }
        void Dosomething()
        {
            Console.WriteLine("Ага! Сработало! A");
        }
        
    }

    class ClassC
    {
        public ClassC(ClassB classB)
        {
            classB.Event += new Action(Dosomething);
            
        }
        void Dosomething()
        {
            Console.WriteLine("Ага! Сработало! C");
        }

        public void Unregister(ClassB classB)

        {
            classB.Event -= Dosomething;
        }

    }

    class ClassB
    {
        public event Action Event;

        public void Work()
        {
            for(int i=0;i<10000;i++)
                if (new Random().Next(1, 1000) == 100)
                    //if (Event!=null) Event.Invoke();
                    Event?.Invoke();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ClassB objB = new ClassB();
            ClassA objA = new ClassA(objB);
            ClassC objC = new ClassC(objB);
            objC.Unregister(objB);
            objB.Work();

        }
    }
}
