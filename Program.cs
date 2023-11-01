using test1.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        LinQ1 testLinQ1 = new LinQ1();
        // testLinQ1.PrintData();
        // testLinQ1.Query();
        testLinQ1.JoinList();

        LinQ2 testLinQ2 = new LinQ2();
        // testLinQ2.PrintData();
        // testLinQ2.ConsultaQuery();
        // testLinQ2.ConsultIndexEvenNumber();
        // testLinQ2.OrderByUser();
    }
}