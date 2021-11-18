using System;
class Aula12{
    static void Main(){

        double n1,n2,n3,n4,nota,final;

        Console.WriteLine("Digite aqui suas notas, utilizando a vírgula para decimais:");
        Console.WriteLine("Nota da primeira prova:");
        n1=double.Parse(Console.ReadLine());
        Console.WriteLine("Nota da segunda prova:");
        n2=double.Parse(Console.ReadLine());
        Console.WriteLine("Nota da terceira prova:");
        n3=double.Parse(Console.ReadLine());
        Console.WriteLine("Nota da quarta prova:");
        n4=double.Parse(Console.ReadLine());
        nota=(n1+n2+n3+n4)/4;
        final=Math.Round(nota,1);

        Console.WriteLine("Relação de Notas: ");
        Console.WriteLine("Prova 1: {0,15}",n1);
        Console.WriteLine("Prova 2: {0,15}",n2);
        Console.WriteLine("Prova 3: {0,15}",n3);
        Console.WriteLine("Prova 4: {0,15}",n4);
        Console.WriteLine("Nota Final: {0,12}",final);

        if(nota<=10){
        if(nota>=7.0){
            Console.WriteLine("Resultado: Aprovado(a)");
            }
        if(nota<7.0){
            Console.WriteLine("Resultado: Reprovado(a)");
            }
        }
        if(nota>10){
            Console.WriteLine("Valor inválido, certifique-se de que as notas foram digitadas corretamente e utilizando a vírgula para valores decimais.");
        }
    }
}
    
    
    //Se(Expressão Lógica for verdadeira){Isso é executado}
    //Expressões Lógicas: < > <= >= ==(Igualdade, um = só é atribuição) !=