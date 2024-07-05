// Manipulação de datas
/* 
var data1 = new DateTime(2024,07,04, 23, 30, 25); // construindo data
Console.WriteLine(data1);

var data2 = DateTime.Parse("2024/07/04 17:30:23");
Console.WriteLine(data2);

var dataAtual = DateTime.Now; // pega a data atual
Console.WriteLine(dataAtual);

var hoje = DateTime.Today; // pega o dia 
Console.WriteLine(hoje);
 */
/* var dataFormatada = DateTime.Now.ToString("dd/MM/YY HH:mm:ss") // formatando a data
Console.WriteLine(dataFormatada); */
/* 
var dateOffSet = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
Console.WriteLine(dateOffSet.LocalDateTime);
Console.WriteLine(dateOffSet.UtcDateTime); // horario universal */

// subtração de data

/* var dataInicial = new DateTime(2024,02,16);

var dataFinal = DateTime.Now;

var diferencaDatas = dataFinal - dataInicial;
Console.WriteLine($"Total em dias:{(int)diferencaDatas.TotalDays}"); // total de dias de uma data para outra
Console.WriteLine($"Total em horas: {(int)diferencaDatas.TotalHours}"); */

// Adicionando dias, meses e ano 

/* var data1 = DateTime.Today;

Console.WriteLine($"Hoje: {data1}");

Console.WriteLine($"Adicionando 3 dias: {data1.AddDays(3)}");

Console.WriteLine($"Adicionando 3 meses: {data1.AddMonths(3)}");

Console.WriteLine($"Adicionando 3 anos: {data1.AddYears(3)}"); */

// adicionando horas, minutos e segundos

/* var data2 = DateTime.Now;

Console.WriteLine($"Hoje: {data2}");

Console.WriteLine($"Adicionando 3 horas: {data2.AddHours(3).ToString("HH:mm:ss")}");

Console.WriteLine($"Adicionando 3 minutos: {data2.AddMinutes(3).ToString("HH:mm:ss")}");

Console.WriteLine($"Adicionando 3 segundos: {data2.AddSeconds(3).ToString("HH:mm:ss")}"); */


// dia da semana 
/* var data3 = DateTime.Now;

Console.WriteLine(data3.DayOfWeek); */

// manipula só  a data

/* var somenteData = DateOnly.Parse("2024-07-04");
Console.WriteLine(somenteData.ToString("dd/MM/yyyy")); */


// manipula só o horário

/* var somenteHora = TimeOnly.Parse("23:35:25");

Console.WriteLine(somenteHora.ToString("HH:mm:ss")); */


// exception são os erros inesperados 

// gerando uma exception 

/* var controle = 's';

while(controle == 's'){
    Console.WriteLine("Informe um número:");

    var numero = Console.ReadLine();

    if(!int.TryParse(numero,out var numeroConvertido)){
        Console.WriteLine("Não foi possível converter o valor para um número válido! Por favor informe outro valor.");

        continue;

    }

    var resultado = 500/numeroConvertido;
    Console.WriteLine($"O resultado da divisão de 500 por {numeroConvertido} é: {resultado}");

    Console.WriteLine($"\nPressione a letra [S] para continuar...");

    controle = char.Parse(Console.ReadLine()!.ToLower()); // foçando ele 

    Console.Clear();
}

Console.WriteLine($"Fim do programa!"); */


/*  var controle = 's';

while(controle == 's'){
    Console.WriteLine("Informe um número:");

    var numero = Console.ReadLine();

    if(!int.TryParse(numero,out var numeroConvertido)){
        Console.WriteLine("Não foi possível converter o valor para um número válido! Por favor informe outro valor.");

        continue;

    }
    try{

    var resultado = 500/numeroConvertido;
    Console.WriteLine($"O resultado da divisão de 500 por {numeroConvertido} é: {resultado}");

    Console.WriteLine($"\nPressione a letra [S] para continuar...");

    controle = char.Parse(Console.ReadLine()!.ToLower()); // foçando ele 

    Console.Clear();
    }catch(Exception exception){
        Console.WriteLine($"Ocorreu um erro: {exception.Message}");
        Console.WriteLine($"/nStack {exception.StackTrace}:");
    }
}

Console.WriteLine($"Fim do programa!"); */

// criando um arquivo com .NET

/* var escrever = new StreamWriter("arquivo.txt", true );

Console.WriteLine("Informe o nome do usuário:");
var nome = Console.ReadLine();

escrever.WriteLine($"Id: {Random.Shared.Next(1,100)}");
escrever.WriteLine($"Nome:{nome}");
escrever.WriteLine("--------------------------------------");

escrever.Close(); */

// ler o arquivo 

/* var textoExtraido = File.ReadAllText("arquivo.txt");
Console.WriteLine(textoExtraido); */

// deletando o arquivo

/* if(File.Exists("arquivo.txt")){
    File.Delete("arquivo.txt");
    Console.WriteLine("Arquivo Removido!");

} */