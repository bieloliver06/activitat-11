namespace activitat11
{
    class Program
    {
        static void Main()
        {
            Console.Write("Quina és el teu text? ");
            string input = Console.ReadLine() ?? "";
            
            Console.WriteLine("Nombre de caracters: " + input.Length);
            Console.WriteLine("Text en majúscules: " + input.ToUpper());
            Console.WriteLine("Text en minúscules: " + input.ToLower());

            Console.WriteLine($"Número de paraules : {input.Split(' ').Length}");
            
            Console.Write("Quina paraula vols cercar? ");
            string word = Console.ReadLine() ?? "";
            Console.WriteLine($"La paraula \"{word}\" apareix a la posició {input.IndexOf(word)}.");
            
            Console.Write("Quina paraula vols substituir? ");
            string word1 = Console.ReadLine() ?? "";
            Console.Write("Per quina paraula vols substituir-la? ");
            string word2 = Console.ReadLine() ?? "";
            Console.WriteLine($"Text modificat : {input.Replace(word1, word2)}");

            Console.WriteLine($"Text sense espais : {input.Replace(" ", "")}");
            
        }
    }
}