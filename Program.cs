using System;

namespace ImtahanSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            ExamService servis = new ExamService();

            servis.TelebeElaveEt(1, "7XJ89RS", "Nicat", "Məmmədov", "nicat@mail.com");

            servis.BalYaz(1, 101, 95);
            servis.BalYaz(1, 102, 85);
            servis.BalYaz(1, 103, 60);

            servis.HesabatGoster(1);
        }
    }
}
