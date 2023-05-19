
class MainClass {
  public static void Main (string[] args) {
    bool continueLoop = true;
    int result = 0;

    while (continueLoop) {
      Console.WriteLine("Enter an operator (+ or -) or any other character to exit:");
      string op = Console.ReadLine();

      switch (op) {
        case "+":
          Console.WriteLine("Enter the size of the matrix:");
          int size = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter the real number:");
          int number = int.Parse(Console.ReadLine());

          result += size * number;
          break;

        case "-":
          Console.WriteLine("Enter the size of the matrix:");
          size = int.Parse(Console.ReadLine());
          Console.WriteLine("Enter the real number:");
          number = int.Parse(Console.ReadLine());

        
          result -= size * number;
          break;

        default:
          continueLoop = false;
          break;
      }
    }
    Console.WriteLine("Result: " + result);
  }
}