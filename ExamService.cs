using System;
using System.Collections.Generic;

namespace ImtahanSistemi
{
    public class ExamService
    {
        public List<Student> Telebeler = new List<Student>();

        public void TelebeElaveEt(int id, string fin, string ad, string soyad, string email)
        {
            Student s = new Student(fin);
            s.Id = id;
            s.Ad = ad;
            s.Soyad = soyad;
            s.Email = email;

            if (s.Ad != null && s.Soyad != null)
            {
                Telebeler.Add(s);
                Console.WriteLine($"{s.TamAd()} sistemə daxil edildi.");
            }
        }

        public void BalYaz(int telebeId, int imtahanId, int bal)
        {
            if (bal < 0 || bal > 100) return;

            foreach (var s in Telebeler)
            {
                if (s.Id == telebeId)
                {
                    bool artiqVar = false;
                    foreach (var r in s.Ballar)
                    {
                        if (r.ExamId == imtahanId) { artiqVar = true; break; }
                    }

                    if (!artiqVar)
                        s.Ballar.Add(new Result { ExamId = imtahanId, Score = bal });
                    break;
                }
            }
        }

        public void HesabatGoster(int telebeId)
        {
            foreach (var s in Telebeler)
            {
                if (s.Id == telebeId)
                {
                    Console.WriteLine($"\n--- {s.TamAd().ToUpper()} ---");

                    int cem = 0;

                    foreach (var r in s.Ballar)
                    {
                        Console.WriteLine($"İmtahan: {r.ExamId} | Bal: {r.Score} | Qiymət: {r.GetGrade()}");

                        cem = cem + r.Score;
                    }

                    if (s.Ballar.Count > 0)
                    {
                        double ortalama = (double)cem / s.Ballar.Count;

                        Console.WriteLine($"Ümumi Bal Cəmi: {cem}");
                        Console.WriteLine($"İmtahan Sayı: {s.Ballar.Count}");
                        Console.WriteLine($"ORTALAMA NƏTİCƏ: {ortalama:F2}");

                        Result yekun = new Result { Score = (int)ortalama };
                        Console.WriteLine($"YEKUN STATUS: {yekun.GetGrade()}");
                    }
                    break;
                }
            }
        }
    }
}
