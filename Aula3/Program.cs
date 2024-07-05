// função 1   
/* string ObterNomeCompleto(){
    string primeiroNome = "Isabele";
    string segundoNome = "Leal";

    return $"{primeiroNome} {segundoNome}"; 
} */

/* Console.WriteLine(ObterNomeCompleto()); */

// função 2

/* int SomarValores (int valor1, int valor2){
    return valor1 + valor2;
}

Console.WriteLine($"Resultado é : {SomarValores(10,5)}"); */

//procedimento que não retorna valor

/* void EscrevaNomeCompleto(){
    Console.WriteLine(ObterNomeCompleto());
}

EscrevaNomeCompleto(); */

 /* using System.Collections; */
/*
var arrayList = new ArrayList();

arrayList.Add(12);
arrayList.Add("Curso de C# Estartando Devs 2024");
arrayList.Add(true);

//Console.WriteLine(arrayList[0]);

arrayList.RemoveAt(0);
arrayList.Clear();

foreach (var item in arrayList){
    Console.WriteLine(item);
} */

/* var arrayTipado = new int[4]{1,2,3,4};

arrayTipado[0] = 5;

foreach (var item in arrayTipado){
    Console.WriteLine(item);} */


/* var listaGenerica = new List<string>(3){
    "Curso Microsift C#",
    "Estartando Devs",
    "2024",
};

listaGenerica.Add("teste");
foreach (var item in listaGenerica){
    Console.WriteLine(item);} */


/* var dicionario = new Dictionary<int, string>();
dicionario.Add(1, "Curso C#");
dicionario.Add(2,"Estartando Devs");
dicionario.Add(3,"2024");

var curso = dicionario[2]; 
Console.WriteLine(curso); */

/* foreach (var item in dicionario){
    Console.WriteLine(item.Value);
    } */


/* var queue = new Queue<string>();

queue.Enqueue("Curso C#");
queue.Enqueue("Estartando Devs");
queue.Enqueue("2024");

var item2 = queue.Dequeue();
 Console.WriteLine(item2);

foreach (var item in queue){
    Console.WriteLine(item);
} */
/* 
var pilha = new  Stack<string>();

pilha.Push("Curso C#");
pilha.Push("Estartando Devs");
pilha.Push("2024");

var item2 = pilha.Pop();
 Console.WriteLine(item2);

foreach (var item in pilha){
    Console.WriteLine(item);
} */