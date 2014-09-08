using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taxi
{
    public class Car 
    { 
        protected int income = 0;
        protected int expence = 0;
        protected int timeBusy = 0;

        public void addIncome(int x, int t) {}
        public void addExpence(int x, int t) { }
        public int getIncome() { return this.income; }
        public int getExpence() { return this.expence; }
        public bool getBusy(int t) { return this.timeBusy <= t; }
    }

    public class PassenderCar : Car
    {
    }

    public class WorkerCar : Car
    {
    }

    public class TaxiCar : PassenderCar
    {
        public void addIncome(int x, int t) 
        {
            this.timeBusy = t;
            this.income += 200 * x;
        }

        public void addExpence(int x, int t) 
        {
            this.timeBusy = t;
            this.expence += 300 * x;
        }

    }

    public class ShuttleCar : PassenderCar
    {
        protected int contain;
    }

    public class Bus : ShuttleCar
    {
        protected int contain = 20;
        public void addIncome(int x, int t)
        {
            if (x > this.contain) x = contain;
            this.timeBusy = t;
            this.income += 20 * x;
        }

        public void addExpence(int x, int t)
        {
            this.timeBusy = t;
            this.expence += 300 * x;
        }
    }

    public class MicroBus : ShuttleCar
    {
    }

    //ремонтная
    public class RepairCar : WorkerCar
    {
        public void addIncome(int x, int t)
        {
            this.timeBusy = t;
            this.income += 500 * x;
        }
    }

    public class ReactCar : WorkerCar
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            //инициализируем рандом
            const int initRnd = 77;
            Random realRnd = new Random();
            Random repeatRnd = new Random(initRnd);

            //создаём объекты-машины
            TaxiCar taxi1 = new TaxiCar();
            TaxiCar taxi2 = new TaxiCar();
            Bus bus1 = new Bus();
            Bus bus2 = new Bus();
            Bus bus3 = new Bus();
            RepairCar repCar = new RepairCar();

            int t; //таймер

            for (t = 1; t <= 12; t++)
            {
                //ремонт 1го такси
                if ((int)realRnd.Next(0, 11) == 10 && taxi1.getBusy(t) && repCar.getBusy(t))
                {
                    //время, на которое машина занята
                    int tt = (int)realRnd.Next(0, 4);
                    taxi1.addExpence(tt, t);
                    repCar.addIncome(tt, t);
                }
                //вызов 1го такси
                if ((int)realRnd.Next(0, 2) == 1 && taxi1.getBusy(t) )
                {
                    //время, на которое машина занята
                    int tt = (int)realRnd.Next(0, 3);
                    taxi1.addIncome(tt, t);
                }
                //ремонт 2го такси
                if ((int)realRnd.Next(0, 11) == 10 && taxi2.getBusy(t) && repCar.getBusy(t))
                {
                    //время, на которое машина занята
                    int tt = (int)realRnd.Next(0, 4);
                    taxi2.addExpence(tt, t);
                    repCar.addIncome(tt, t);
                }
                //вызов 2го такси
                if ((int)realRnd.Next(0, 2) == 1 && taxi2.getBusy(t))
                {
                    //время, на которое машина занята
                    int tt = (int)realRnd.Next(0, 3);
                    taxi2.addIncome(tt, t);
                }
                //ремонт 1го автобуса
                if ((int)realRnd.Next(0, 11) == 10 && bus1.getBusy(t) && repCar.getBusy(t))
                {
                    //время, на которое машина занята
                    int tt = (int)realRnd.Next(0, 4);
                    bus1.addExpence(tt, t);
                    repCar.addIncome(tt, t);
                }
                //поездка 1го автобуса
                if (bus1.getBusy(t))
                {
                    //количество пассажиров
                    int tt = (int)realRnd.Next(0, 30);
                    bus1.addIncome(tt, t);
                }
                //ремонт 2го автобуса
                if ((int)realRnd.Next(0, 11) == 10 && bus2.getBusy(t) && repCar.getBusy(t))
                {
                    //время, на которое машина занята
                    int tt = (int)realRnd.Next(0, 4);
                    bus2.addExpence(tt, t);
                    repCar.addIncome(tt, t);
                }
                //поездка 2го автобуса
                if (bus2.getBusy(t))
                {
                    //количество пассажиров
                    int tt = (int)realRnd.Next(0, 30);
                    bus2.addIncome(tt, t);
                }
                //ремонт 3го автобуса
                if ((int)realRnd.Next(0, 11) == 10 && bus3.getBusy(t) && repCar.getBusy(t))
                {
                    //время, на которое машина занята
                    int tt = (int)realRnd.Next(0, 4);
                    bus3.addExpence(tt, t);
                    repCar.addIncome(tt, t);
                }
                //поездка 3го автобуса
                if (bus3.getBusy(t))
                {
                    //количество пассажиров
                    int tt = (int)realRnd.Next(0, 30);
                    bus3.addIncome(tt, t);
                }
            }
            System.Console.WriteLine("Ремонтная машина: прибыль = " + repCar.getIncome());
            System.Console.WriteLine("1ое такси: прибыль = " + taxi1.getIncome());
            System.Console.WriteLine("1ое такси: затраты = " + taxi1.getExpence());
            System.Console.WriteLine("2ое такси: прибыль = " + taxi2.getIncome());
            System.Console.WriteLine("2ое такси: затраты = " + taxi2.getExpence());
            System.Console.WriteLine("1ый автобус: прибыль = " + bus1.getIncome());
            System.Console.WriteLine("1ый автобус: затраты = " + bus1.getExpence());
            System.Console.WriteLine("2ый автобус: прибыль = " + bus2.getIncome());
            System.Console.WriteLine("2ый автобус: затраты = " + bus2.getExpence());
            System.Console.WriteLine("3ый автобус: прибыль = " + bus3.getIncome());
            System.Console.WriteLine("4ый автобус: затраты = " + bus3.getExpence());
            System.Console.ReadKey();
        }
    }
}
