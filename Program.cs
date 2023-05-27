Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("*** Esperto Contra Sabido ***");
Console.ResetColor();
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Quantos alimentos serão distribuídos? ");
Console.ResetColor();

int TotalAlimentos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int Restantes = TotalAlimentos;
int PicaPau = 0, Raposinha = 0;
int ContadorParaMim = 0, ContadorParaVoce = 0;

while(Restantes > 0)
{
    ContadorParaVoce = ContadorParaVoce +1;
    PicaPau = PicaPau + 1;
    Restantes = Restantes - 1;

    Console.Write($"{PicaPau} para você. ");

    ContadorParaMim = 0;

    while(Restantes > 0 && ContadorParaMim < ContadorParaVoce)
    {
        ContadorParaMim = ContadorParaMim + 1;
         Raposinha = Raposinha + 1;
         Restantes = Restantes -1;
    
        Console.Write($"{ContadorParaMim} para mim, ");
    }
    Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Pica Pau recebeu {PicaPau} alimento(s).");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"Raposinha recebeu {Raposinha} alimento(s).");
Console.ResetColor();