using System.Drawing;
System.Random random = new System.Random();

int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int platziCoins = 0;
string message = "";
string controlOtraCarta = "";
string switchControl = "menu";

while (true){

    Console.WriteLine("\nWelcome a P L A T Z I N O \n");
    Console.WriteLine("¿Cuántos PlatziCoins deseas? \n" + "Ingresa un número entero \n" + "Recuerda que necesitas 1 por ronda \n");

    platziCoins = int.Parse(Console.ReadLine());

    for (int i = 0; i < platziCoins; i++)
    {
        totalJugador = 0;
        totalDealer = 0;

        switch (switchControl)
        {
            case "menu":

                Console.WriteLine("\nEscriba ‘21’ para jugar al 21");
                switchControl = Console.ReadLine();
                i = i - 1;
                break;

            case "21":
                do {
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine($"\nToma tu carta, te salió el número: {num} ");
                    Console.WriteLine("¿Deseas otra carta ?");
                    controlOtraCarta = Console.ReadLine();

                } while (controlOtraCarta == "Si" ||
                         controlOtraCarta == "si" ||
                         controlOtraCarta == "yes");

                totalDealer = random.Next(14, 23);
                Console.WriteLine($"El dealer tiene {totalDealer}");
                Console.WriteLine($"Sumaste {totalJugador}");

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "Venciste al dealer, felicidades";
                    switchControl = "menu";
                }
                else if (totalJugador >= 22)
                {
                    message = "Perdiste vs el dealer, te pasaste de 21";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "Perdiste vs el dealer";
                    switchControl = "menu";
                }
                else
                {
                    message = "condición no válida";
                }
                Console.WriteLine(message);
                break;

            default:
                Console.WriteLine("Valor ingresado no válido en el  C A S I N O");
                break;
        }
    }
}