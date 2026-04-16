internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba dos valores numerico: ");
        double num1=Convert.ToDouble(Console.ReadLine());  
        double num2=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n*** MENU PRICIPAL");
        Console.WriteLine("1-SUMA");
        Console.WriteLine("2-RESTA");
        Console.WriteLine("3-MULTIPLICACION");
        Console.WriteLine("4-DIVISION");
        Console.WriteLine("5-SALIR");
        Console.WriteLine("DIGITE EL VALOR SEGUN SEA LA OP [ ]");
        int opc=Convert.ToInt32(Console.ReadLine());

        //Evaluar son switch
        double result=0;
        string msj = "";
        switch (opc)
        {
            case 1:
                msj = "\nLa\nsuma es: ";
                result = num1 + num2;
                break;
            case 2:
                msj = "\nLa\nresta es: ";
                result = num1 - num2;
                break;
            case 3:
                msj = "\nLa\nmulti es: ";
                result = num1 * num2;
                break;
            case 4:
                msj = "\nLa\ndivision es: ";
                result = num1 / num2;
                break;
            case 5:
                msj = "SALIENDO... ";
                break;

            default:
                msj = "DIJITE UNA OPCCION VALIDA";
                break;
        }
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine(msj);
        Console.WriteLine(result);

    }
}