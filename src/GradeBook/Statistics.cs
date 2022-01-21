namespace GradeBook {
    public class Statistics {
        public Statistics(Book book) {
            high = book.HighGrade();
            low = book.LowGrade();
            average = book.Average();
            sum = book.Sum();
        }
        public double high;
        public double low;
        public double average;
        public double sum;
    }
}

