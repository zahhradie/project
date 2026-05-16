using System;

namespace ImtahanSistemi
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataBase db = new DataBase();

            Student s1 = new Student();
            s1.SetId(1);
            s1.SetAd("Nicat");
            s1.SetSoyad("Məmmədov");
            s1.SetEmail("nicat@mail.com");

            Teacher t1 = new Teacher();
            t1.SetId(1);
            t1.SetAd("Afaq");
            t1.SetSoyad("Məmmədova");

            Result r1 = new Result();
            r1.SetExamId(101);
            r1.SetExamName("Riyaziyyat");
            r1.SetExamDate(DateTime.Now);
            r1.SetScore(95);
            r1.SetUserType("Student");

            Result r2 = new Result();
            r2.SetExamId(201);
            r2.SetExamName("Metodika");
            r2.SetExamDate(DateTime.Now.AddDays(-1));
            r2.SetScore(85);
            r2.SetUserType("Teacher");

            s1.GetNeticeler().Add(r1);
            t1.GetNeticeler().Add(r2);

            db.AddStudent(s1);
            db.AddTeacher(t1);

            GetInfo(db);
            Console.ReadLine();
        }

        public static void GetInfo(DataBase db)
        {
            Console.WriteLine("Sistemdəki Toplam Şagird Sayı: " + db.GetStudentCount());
            Console.WriteLine("Sistemdəki Toplam Teacher Sayı: " + db.GetTeacherCount());

            Console.WriteLine("ŞAGİRD İMTAHAN NƏTİCƏLƏRİ");
            foreach (var s in db.GetAllStudents())
            {
                Console.WriteLine("Şagird: " + s.TamAd() + " | Email: " + s.GetEmail());
                foreach (var r in s.GetNeticeler())
                {
                    Console.WriteLine("  -> İmtahan: " + r.GetExamName() + " (ID: " + r.GetExamId() + ")");
                    Console.WriteLine("     Tarix: " + r.GetExamDate().ToString("dd.MM.yyyy") + " | Daxil Edilən Bal: " + r.GetScore() + " | Qiymət: " + r.GetGrade());
                }
            }

            Console.WriteLine("\n TEACHER İMTAHAN NƏTİCƏLƏRİ");
            foreach (var t in db.GetAllTeachers())
            {
                Console.WriteLine("Teacher: " + t.TamAd());
                foreach (var r in t.GetNeticeler())
                {
                    Console.WriteLine("İmtahan: " + r.GetExamName() + " (ID: " + r.GetExamId() + ")");
                    Console.WriteLine("Tarix: " + r.GetExamDate().ToString("dd.MM.yyyy") + " | Giriş Balı: " + r.GetScore() + " | Düsturla Yekun: " + r.Hesabla() + " | Qiymət: " + r.GetGrade());
                }
            }
        }
    }
}
