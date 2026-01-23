namespace DebugTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*RED POINTER*/ string[] students = ["Alpha", "Beta", "Charlie", "Delta", "Euphoria", "Foltress"];

            int studentsLenght = students.Length;

            System.Console.WriteLine(students[studentsLenght - 1]);
        }
    }
}