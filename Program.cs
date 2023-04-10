//Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
//Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

//Entrada 

//Processamento 
for (int i = 1; i <= 10; i++)
{
Console.WriteLine($"Tabuada do {i}: ");
Console.WriteLine($"_____________");
for (int t = 0; t <= 10; t++)
{
Console.WriteLine($"{i} X {t} = {i*t}");
}
Console.WriteLine();     //linha vazia
}
    
//Saida

 