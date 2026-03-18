namespace LibrarySystem
{
    abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public virtual void GetDescription()
        {
            Console.WriteLine($"Книга: {Title}, Автор: {Author}");
        }
        public abstract void Read();
    }
    class PaperBook : Book
    {
        public int WeightGram { get; set; }
        public PaperBook(string title, string author, int weight) : base(title, author)
        {
            WeightGram = weight;
        }
        public override void Read()
        {
            Console.WriteLine($"Ви гортаєте паперові сторінки книги '{Title}'.");
        }
        public override void GetDescription()
        {
            base.GetDescription();
            Console.WriteLine($"Тип: Паперова, Вага: {WeightGram}г");
        }
    }
    class EBook : Book
    {
        public string Format { get; set; }
        public EBook(string title, string author, string format) : base(title, author)
        {
            Format = format;
        }
        public override void Read()
        {
            Console.WriteLine($"Ви читаєте '{Title}' на екрані пристрою у форматі {Format}.");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book myPaperBook = new PaperBook("Кобзар", "Т. Шевченко", 800);
            Book myEBook = new EBook("Цифрова фортеця", "Д. Браун", "EPUB");
            Console.WriteLine("--- Тестування поліморфізму ---");
            myPaperBook.GetDescription();
            myPaperBook.Read();
            Console.WriteLine();
            myEBook.GetDescription();
            myEBook.Read();
        }
    }
}