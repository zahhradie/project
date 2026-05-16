using System;

namespace ImtahanSistemi
{
    public class Exam
    {
        private int _examId;
        private string _examName;
        private DateTime _examDate;

        public int GetExamId()
        {
            return _examId;
        }

        public void SetExamId(int id)
        {
            if (id > 0)
            {
                _examId = id;
            }
        }

        public string GetExamName()
        {
            return _examName;
        }

        public void SetExamName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) == false)
            {
                _examName = name.Trim();
            }
        }

        public DateTime GetExamDate()
        {
            return _examDate;
        }

        public void SetExamDate(DateTime date)
        {
            _examDate = date;
        }
    }
}
