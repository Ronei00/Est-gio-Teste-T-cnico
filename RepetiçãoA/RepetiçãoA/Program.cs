int count = 0;
Console.WriteLine("Escreva alguma frase e iremos contar quantos a tem na frase");

string valordigitado = Console.ReadLine();

char[] valor = valordigitado.ToCharArray();

for(int i = 0; i < valor.Length; i++)
{
    if (valor[i] == 'a' || valor[i] == 'A')
    {
        count++;
    }
}
Console.WriteLine($"Nesta frase existe: {count} a");