using System;
using System.Threading;

namespace Итоговая_подготовка
{
    class Program
    {
        /// <summary>
        /// Возвращается сумму двух чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Возвращается сумму трёх чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }
        //static void Main(string[] args)
        //{
        //    Computer pc1 = new Computer();
        //    //pc1.PCJOB();
        //    int result = Slogenie(5, 4);
        //}
        static void Main(string[] args)
        {
            Computer pc1 = new Computer("Выблядок", "Ахуевшая", "RTX3080TITAN", "Пидарас 3000", 2, "600вольтовая коробка ебашущаяя всё нахуй",new CvantProc1());
            Computer pc2 = new Computer(new Core5());
            Console.WriteLine(pc2.proc);
            pc1.GetInfo();
            Slogenie slogenie = Computer.Vichislenia;
            int result = slogenie(5, 4);
            Console.WriteLine(result);
        }
    }
    delegate void Character(string message);
    delegate int Slogenie(int x, int y);
    public class Computer
    {

        string namePC { get; set; }
        string konfiguracia { get; set; }
        string namevidiokard { get; set; }
        string nameprocessor { get; set; }
        int countozy { get; set; }
        string informPowerKoroka { get; set; }
        Character character = Console.WriteLine;
        Slogenie slogenie;
      public  Processor proc;
        int kolvovremeni = 3600;
        public Computer(string namePC, string konfiguracia, string namevidiokard, string nameprocessor, int countozy, string informPowerKoroka,Processor proc1)
        {
            this.countozy = countozy;
            this.informPowerKoroka = informPowerKoroka;
            this.konfiguracia = konfiguracia;
            this.nameprocessor = nameprocessor;
            this.namevidiokard = namevidiokard;
            this.namePC = namePC;
            proc = proc1;
        }
        public Computer(Processor proc2)
        {
            proc = proc2;
        }
        public void PCJOB()
        {
            for (int i = 0; i < kolvovremeni; i++)
            {
                character("Ваш компьютер работает стабильно!");
                Thread.Sleep(10000);
            }
        }
        static public int Vichislenia(int a, int b)
        {
            return a + b;
        }
        public void GetInfo()
        {
            character($"Название вашего пк: {namePC} Конфигурация: {konfiguracia}  Пиздатая Видеокарта {namevidiokard} ,Блатной процессор{nameprocessor}, сколько всего плашек ОЗУ {countozy}, и информация о вашем блоке питания {informPowerKoroka}");
        }
    }
    public abstract class Processor
    {
        protected abstract string NameProc { get; set; }
        protected abstract string Energopotreblenie { get; set; }
        protected abstract string Properties { get; set; }

    }
    public class CvantProc1 : Processor
    {
        protected override string NameProc { get; set; }
        protected override string Energopotreblenie { get ; set; }
        protected override string Properties { get ; set; }
        public CvantProc1()
        {
            NameProc = "Квантовый первый процессор";
            Energopotreblenie = "1000V";
            Properties = "Довольно мощный процессор,короче крутой";
        }
    }
    public class Core5 : Processor, ICommonProc
    {
        public int chastota { get; set; }
        public string proizvoditelnost { get; set; }
        protected override string NameProc { get; set; }
        protected override string Energopotreblenie { get; set; }
        protected override string Properties { get; set; }
        public Core5()
        {
            NameProc = "IntelCore5";
            Energopotreblenie = "65V";
            Properties = "Нормальный процессор";
            chastota = 3600;
            proizvoditelnost = "Ахуевшая";
        }
        public override string ToString()
        {
            return $"Назване процессора : {NameProc} Его энегропотребление : {Energopotreblenie} Свойства : {Properties} Тактовая частота : {chastota} Производительность : {proizvoditelnost}";
        }
    }
    

}
