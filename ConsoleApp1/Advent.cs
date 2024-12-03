namespace ConsoleApp1;
public class Advent
{
    static void read_file(string filename)
    {
        string contents = File.ReadAllText(filename);
        string[] array = contents.Split(' ', '\n');

        List<int> left = new List<int>();
        List<int> right  = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                left.Add(int.Parse(array[i]));
                Console.WriteLine("Left: " + array[i]);
            }
            else
            {
                right.Add(int.Parse(array[i]));
                Console.WriteLine("Right: " + array[i]);
            }
        }
    }

    static void Main(string[] args)
    {
        read_file("input.txt");
    }
    
    
}