using System.Net;

Console.Title = "Algoritmo Equação de 2° Grau";
WebClient web = new WebClient();
string logo_msg = web.DownloadString("https://pastebin.com/raw/iGF6Ex0C");
string resultado_msg = web.DownloadString("https://pastebin.com/raw/bRL3LYfF");

double resposta1 = 0;
double resposta2 = 0;
double resposta3 = 0;

double resultado = 0;

void Inicio() { 
    Console.WriteLine(logo_msg);
    Console.WriteLine("    ");
    Console.WriteLine("    ");
    Console.WriteLine("Algoritmo - Calculadora de Equação 2° Grau");
    Console.WriteLine("========================================");
    Console.WriteLine("    ");
    Console.WriteLine("DELTA = b² - 4 * a * c");
    Console.WriteLine("    ");
    Console.WriteLine("========================================");
    Console.WriteLine("    ");

    Console.WriteLine("Digite o Valor A");
    resposta2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o Valor B²");
    resposta1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o Valor C");
    resposta3 = Convert.ToDouble(Console.ReadLine());

    user_resultado();
}
void user_resultado(){ 
//negativo
    resultado = (Math.Pow(resposta1, 2) - 4 * resposta2 * resposta3);

    Console.Clear();
    Console.WriteLine(resultado_msg);
    Console.WriteLine("========================================");
    Console.WriteLine("DELTA = " + resposta1 + "² - 4 * " + resposta2 + " * " + resposta3);
    Console.WriteLine("    ");
    Console.WriteLine("Resultado é: " + resultado);
    Console.WriteLine("========================================");

    Console.ReadKey();
    Console.Clear();
    Inicio();
}

Console.Clear();
Inicio();

