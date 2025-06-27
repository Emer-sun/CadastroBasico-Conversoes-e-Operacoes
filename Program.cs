Console.WriteLine("Olá, por gentileza digite seu nome"); //Instrução para o usuário
string nome =  Console.ReadLine();
Console.WriteLine($"Olá {nome}, um prazer ter você por aqui, por gentileza digite sua idade");
int idade = Convert.ToInt32(Console.ReadLine()); //Armeza informação
int dobro = idade * 2;
double media = (idade + dobro) / 2.0; //especificar o .0 pois se não sai como numero inteiro
int resto = (idade % dobro);
Console.WriteLine("Digite sua altura");
double altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua nota da prova");
float nota = float.Parse(Console.ReadLine()); //usado .parse para conversão pois a classe Convert não possui converção para float
int arredondamento = (int)nota;
Console.WriteLine($"Digite sua data de nascimento");
DateTime nascimento = Convert.ToDateTime(Console.ReadLine());


Console.WriteLine($"Olá, {nome}");
Console.WriteLine($"Você tem {idade} e mede {altura}");
Console.WriteLine($"Sua nota final foi {nota}, arrendondando para {arredondamento}");
Console.WriteLine($"Você nasceu em {nascimento.ToShortDateString()}"); //Usando o ToShort para comprimir a informação e não ficar os 00:00
Console.WriteLine($"Idade calculada {idade} | Dobro da idade {dobro}" );
Console.WriteLine($"Média entre idade digitada e calculada: {media}");
Console.WriteLine($"Resto da divisão entre idade e nota convertida {resto}");
Console.ReadKey();