using System.Security.Cryptography.X509Certificates;

Console.Write("Quantos paricipantes houve nesse Evento: ");
int i = int.Parse(Console.ReadLine());

int[] NParticipante = new int[i];
string[] Participante = new string[i];
double[] Salto3 = new double[i];
double[] Salto2 = new double[i];
double[] Salto1 = new double[i];
double[] MediaSalto = new double[i];
double[] MaiorSalto = new double[i];

Console.Clear();

for (int j = 0; j < NParticipante.Length; j++)
{
    Console.Write($"Digite o nome do {j  + 1}º Participante: ");
    Participante[j] = Console.ReadLine();

    Console.Write("Altura do 1° Salto|M:");
    Salto1[j] = double.Parse(Console.ReadLine());

    Console.Write("Altura do 2° Salto|M:");
    Salto2[j] = double.Parse(Console.ReadLine());

    Console.Write("Altura do 3° Salto|M:");
    Salto3[j] = double.Parse(Console.ReadLine());

    if (MaiorSalto[j] < Salto1[j] && Salto1[j] > Salto2[j] && Salto1[j] > Salto3[j])
    {
        MaiorSalto[j] = Salto1[j];
    }

    else if (MaiorSalto[j] < Salto2[j] && Salto2[j] > Salto1[j] && Salto2[j] > Salto3[j])
    {
        MaiorSalto[j] = Salto2[j];
    }

    else if (MaiorSalto[j] < Salto3[j] && Salto3[j] > Salto2[j] && Salto3[j] > Salto2[j])
    {

        MaiorSalto[j] = Salto3[j];
    }
    Console.Clear();
}

bool resposta = true;


do
{
    for (int c = 0; c < NParticipante.Length; c++)
    {
        Console.WriteLine($"{c+1}º: {Participante[c]}");    
    }

    Console.Write("Deseja ver as estaticas de qual participante:");
    string nome = Console.ReadLine();

    for (int c = 0; c < NParticipante.Length; c++)
    {
        if (nome == Participante[c])
        {
            Console.Clear();
            Console.WriteLine("Nome:" + Participante[c]);
            Console.WriteLine("1º Salto|M:" + Salto1[c]);
            Console.WriteLine("2º Salto|M:" + Salto2[c]);
            Console.WriteLine("3º Salto|M:" + Salto3[c]);
            Console.WriteLine("Maior Salto|M:" + MaiorSalto[c]);
        }
    }

    Console.WriteLine("Deseja ver os dados de outro usuário? [S/N]");
    string r = Console.ReadLine();

        if (r == "s")
        {
        resposta = true;
        Console.Clear();
        }
        else 
        {
        Console.WriteLine("Finalizando Programa...");
        resposta = false;
        }

} while (resposta == true);