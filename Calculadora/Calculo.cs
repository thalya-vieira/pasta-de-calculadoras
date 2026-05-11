
class Calculo
{
    //atributos da calculadora
    public int Num1;
    public int Num2;
    

    //metodo de receber numeros
    public void ReceberNum()
    {
        Console.Write("Digite o Num1: ");
        int.TryParse(Console.ReadLine(), out Num1);

        Console.Write("Digite o Num2: ");
        int.TryParse(Console.ReadLine(), out Num2);
    }

    //metodo de somar
    public void Somar()
    {
        Console.WriteLine($"Resultado da soma: {Num1+Num2}");
    }


    //metodo de subtrair
    public void Subtrair()
    {
        Console.WriteLine($"Resultado da subtraçao: {Num1-Num2}");
    }

    //metodo de multiplicar
    public void Multiplicar()
    {
        Console.WriteLine($"Resultado da multiplicação: {Num1 * Num2}");
    }

    //metodo de Dividir
    public void Dividir()
    {
        Console.WriteLine($"Resultado da divisão: {Num1 / Num2}");
    }
}