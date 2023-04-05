Console.WriteLine($"Digite o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite a sua idade: ");
int idade = int.Parse (Console.ReadLine());

Console.WriteLine($"Digite o seu salário: ");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o seu estado civil com 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)): ");
char estadoCivil = char.Parse(Console.ReadLine().ToLower());

while (nome.Length == 0)
{
    Console.WriteLine($"Digite o seu nome novamente, pois não atendeu aos padrões requeridos: ");
    nome = Console.ReadLine();
}

while (idade < 0 && idade >= 100)
{
    Console.WriteLine($"Digite a sua idade novamente, pois não atendeu aos padrões requeridos: ");
    idade = int.Parse(Console.ReadLine());
}

while (salario < 0.01f)
{
    Console.WriteLine($"Digite o seu salário novamente, pois não atendeu aos padrões requeridos: ");
    salario = float.Parse(Console.ReadLine());
}

while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd')
{
    Console.WriteLine($"Digite o seu estado civil novamente, pois não atendeu aos padrões requeridos: ");
    estadoCivil = char.Parse(Console.ReadLine());
}

Console.WriteLine($"Todos os dados foram coletados com sucesso!");




//if (String.IsNullOrEmpty(nome))
//{
//  Console.WriteLine($"")    
//}