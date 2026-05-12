using System;
using System.Collections.Generic;

namespace ImtahanSistemi
{
    public class Student
    {
        private string _ad;
        private string _soyad;
        private string _finCode;

        public int Id { get; set; }
        public string Email { get; set; }
        public List<Result> Ballar = new List<Result>();

        public Student(string fin)
        {
            FinCode = fin;
        }

        public string FinCode
        {
            get { return _finCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Trim().Length == 7)
                    _finCode = value.Trim().ToUpper();
                else
                    _finCode = "NAMELUM";
            }
        }

        public string Ad
        {
            get { return _ad; }
            set { if (!string.IsNullOrWhiteSpace(value)) _ad = value.Trim(); }
        }

        public string Soyad
        {
            get { return _soyad; }
            set { if (!string.IsNullOrWhiteSpace(value)) _soyad = value.Trim(); }
        }

        public string TamAd() => _ad + " " + _soyad;
    }
}
