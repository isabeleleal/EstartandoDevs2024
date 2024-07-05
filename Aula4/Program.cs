// Estrutura de controle - if, else if e else
/* 
Console.WriteLine("Informe o mês:");

var mes = int.Parse(Console.ReadLine());

if(mes == 1 ){
    Console.WriteLine("Feliz ano novo!");

}else if(mes == 5){
    Console.WriteLine("Feliz dia das mães!");
}else if (mes == 12){
    Console.WriteLine("Feliz Natal!");
}else{
    Console.WriteLine("Apenas mais um mês!");
} */


// Estrutura de controle - switch case

/* Console.WriteLine("Informe o mês:");

var mes = int.Parse(Console.ReadLine());

switch (mes){
    case 1: 
        Console.WriteLine("Feliz ano novo!");
        break;

    case 5:
        Console.WriteLine("Feliz dia das mães!");
        break;

    case 12:
         Console.WriteLine("Feliz Natal!");
         break ;
        
    default:
        Console.WriteLine("Apenas mais um mês!");
        break;
} */

// Laços de repetições - for 

/* for(var contador = 0; contador < 10; contador++){
    Console.WriteLine($"Esse é a {contador} cada vez que executo o laço de repetição!");
} */



/* var lista = new List<string>(){"Curso", "Estartando Devs", "2024"};

for(var item =0; item < lista.Count; item++){
    var nome = lista[item];

    Console.WriteLine(nome);
} */

// Laços de repetições - foreach

/* var lista = new List<string>(){"Curso", "Estartando Devs", "2024"};

foreach (var item in lista){
    Console.WriteLine(item);
} */


/* foreach(var letra in "Curso Estartando Devs 2024"){
    Console.WriteLine(letra);
} */

// Laços de repetições - while/ do while

/* var i = 0;

while (i < 4) {
    Console.WriteLine($"Valor de i é {i}");
    i++;
}
 */

/*  var j = 0;

 do {
    Console.WriteLine($"Valor de j é {j}");
    j++;
 } while(j<4); */

// Laços de respetição parar - Break e Continue

/* var i = 0;

while(i <5 ){
     if(i < 2){
        Console.WriteLine($"Continuando");
        i++;
        continue;
    }

    Console.WriteLine($"Valor de i é {i}");
    i++;

    if(i == 3){
        Console.WriteLine($"Loop interrompido na {i+1} vez do laço!");
        break;
    }
} */

// conversão string para int

/* int numero = int.Parse("10");
Console.WriteLine(numero); */

/* int numero1 = Convert.ToInt32("10");
Console.WriteLine(numero1); */
/* 
int numero2 = Convert.ToInt32(null);
Console.WriteLine(numero2); */

/* int numero2 = int.Parse(null);
Console.WriteLine(numero2); */

/* bool verdadeiro = bool.Parse("true");
Console.WriteLine(verdadeiro); */

// Conversor - TryParse

/* var numero = "12345";

if(int.TryParse(numero, out int numeroTransformado)){
    Console.WriteLine("Número convertido com sucesso!");

}

Console.WriteLine(numeroTransformado); */

//strings - ToLower ( coloca tudo da string em minusculo)

/* var frase = "CURSO ESTARTANDO DEVS 2024";

Console.WriteLine(frase);

frase = frase.ToLower();

Console.WriteLine(frase); */

//strings - ToUpper ( coloca tudo da string em maiusculo)

/* var frase = "Curso Estartando Devs 2024";

Console.WriteLine(frase);

frase = frase.ToUpper();

Console.WriteLine(frase); */

//strings - Substring

/*  var frase = "Curso Estartando Devs 2024";

Console.WriteLine(frase);

var trecho = frase.Substring(0, 5 );

Console.WriteLine(trecho); */

//strings - Range

/* var frase = "Curso Estartando Devs 2024";

var inicio = frase[..5];

var meio = frase[6..^5];
var fim = frase[^4..];

Console.WriteLine(inicio);
Console.WriteLine(meio);
Console.WriteLine(fim); */

//strings - Contains

/* var frase = "Curso Estartando Devs 2024";

Console.WriteLine($"Existe 'Devs' na frase? {frase.Contains("Devs")}"); */

//strings - TRIM ( Remove caracter)

/*  var frase = "***Curso Estartando Devs 2024***";

Console.WriteLine($"TRIM Total:{frase.Trim('*')}");
Console.WriteLine($"TRIM incio:{frase.TrimStart('*')}");
Console.WriteLine($"TRIM final:{frase.TrimEnd('*')}"); */

//strings - StartsWith/ EndsWith

/* var frase = "Curso Estartando Devs 2024";

Console.WriteLine($"A frase começa com 'Curs'?:{frase.StartsWith("Curs")}");
Console.WriteLine($"A frase termina com '2023'?:{frase.EndsWith("2023")}"); */

//strings - Replace

/* var frase = "Curso Estartando Devs 2024";

Console.WriteLine(frase);

var fraseModificada = frase.Replace("Curso", "Formação");

Console.WriteLine(fraseModificada); */

//strings - Length

/* Console.WriteLine("Escreva uma palavra:");
var palavra = Console.ReadLine();

Console.WriteLine($"Palavra informada foi: {palavra}");
Console.WriteLine($"Quantidade de letras é: {palavra.Length}"); */