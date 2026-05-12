namespace ImtahanSistemi
{
    public class Result
    {
        public int ExamId { get; set; }
        public int Score { get; set; }

        public string GetGrade()
        {
            // Qiymətləndirmə meyarları
            if (Score >= 91) return "A (Əla)";
            if (Score >= 81) return "B (Çox yaxşı)";
            if (Score >= 71) return "C (Yaxşı)";
            if (Score >= 61) return "D (Kafi)";
            if (Score >= 51) return "E (Qənaətbəxş)";
            return "F (Kəsildiniz)";
        }
    }
}
