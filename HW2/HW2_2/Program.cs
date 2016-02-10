using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class HW2_2
    {
        static void Main(string[] args)
        {
            List<PaperTrash> t1 = new List<PaperTrash>();
            PaperRecycler r1 = new PaperRecycler();
            GenPaperTrash(t1);

            List<PlasticTrash> t2 = new List<PlasticTrash>();
            PlasticRecycler r2 = new PlasticRecycler();
            GenPlasticTrash(t2);

            List<GlassTrash> t3 = new List<GlassTrash>();
            GlassRecycler r3 = new GlassRecycler();
            GenGlassTrash(t3);

            r1.Recycle(t1);
            r2.Recycle(t2);
            r3.Recycle(t3);

            Console.ReadKey();

        }
        private static void GenPaperTrash(List<PaperTrash> trashContainer)
        {
            Random randomUB = new Random();
            int UB = randomUB.Next(50, 5000);

            Random randomTrashWeight = new Random();

            for (int i = 0; i < UB; i++)
            {
                trashContainer.Add(new PaperTrash(1));
            }
        }
        private static void GenPlasticTrash(List<PlasticTrash> trashContainer)
        {
            Random randomUB = new Random();
            int UB = randomUB.Next(50, 5000);

            Random randomTrashWeight = new Random();

            for (int i = 0; i < UB; i++)
            {
                trashContainer.Add(new PlasticTrash(2));
            }
        }
        private static void GenGlassTrash(List<GlassTrash> trashContainer)
        {
            Random randomUB = new Random();
            int UB = randomUB.Next(50, 5000);

            Random randomTrashWeight = new Random();

            for (int i = 0; i < UB; i++)
            {
                trashContainer.Add(new GlassTrash(3));
            }
        }
    }
    public class PaperTrash : Trash
    {
        public PaperTrash(double Weight)
        {_initialWeight = Weight;}
    }
    public class PlasticTrash : Trash
    {
        public PlasticTrash(double Weight)
        { _initialWeight = Weight; }
    }
    public class GlassTrash : Trash
    {
        public GlassTrash(double Weight)
        { _initialWeight = Weight; }
    }
    public abstract class Trash
    {
        protected double _initialWeight = 0;
        public double GetWeightInPounds { get { return _initialWeight; }}
    }
    public class PaperRecycler : Recycler<PaperTrash>
    {
        public override void Recycle(List<PaperTrash> garbageBag)
        {
            double totalWeight = 0;
            foreach (var item in garbageBag)
            {
                totalWeight = totalWeight + item.GetWeightInPounds;
            }
            Console.WriteLine("Total Paper Weight in lbs: " + totalWeight.ToString());
        }
    }
    public class PlasticRecycler : Recycler<PlasticTrash>
    {
        public override void Recycle(List<PlasticTrash> garbageBag)
        {
            double totalWeight = 0;
            foreach (var item in garbageBag)
            {
                totalWeight = totalWeight + item.GetWeightInPounds;
            }
            Console.WriteLine("Total Plastic Weight in lbs: " + totalWeight.ToString());
        }
    }
    public class GlassRecycler : Recycler<GlassTrash>
    {
        public override void Recycle(List<GlassTrash> garbageBag)
        {
            double totalWeight = 0;
            foreach (var item in garbageBag)
            {
                totalWeight = totalWeight + item.GetWeightInPounds;
            }
            Console.WriteLine("Total Glass Weight in lbs: " + totalWeight.ToString());
        }
    }
    public abstract class Recycler<T>
    {
        public abstract void Recycle(List<T> garbageBag);

    }
}
