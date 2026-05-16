namespace ImtahanSistemi
{
    public class Result : Exam
    {
        private int _score;
        private string _userType;
        public int GetScore()
        {
            return _score;
        }

        public void SetScore(int score)
        {
            if (score >= 0)
            {
                if (score <= 100)
                {
                    _score = score;
                }
            }
        }

        public string GetUserType()
        {
            return _userType;
        }

        public void SetUserType(string type)
        {
            _userType = type;
        }

        public virtual double Hesabla()
        {
            if (_userType == "Teacher")
            {
                if (_score + 10 > 100)
                {
                    return 100;
                }
                else
                {
                    return _score + 10;
                }
            }
            else
            {
                return _score;
            }
        }

        public string GetGrade()
        {
            double yekunBal = Hesabla();

            if (yekunBal >= 91)
            {
                return "A (Əla)";
            }
            if (yekunBal >= 81)
            {
                return "B (Çox yaxşı)";
            }
            if (yekunBal >= 71)
            {
                return "C (Yaxşı)";
            }
            if (yekunBal >= 61)
            {
                return "D (Kafi)";
            }
            if (yekunBal >= 51)
            {
                return "E (Qənaətbəxş)";
            }
            
            return "F (Kəsildiniz)";
        }
    }
}
