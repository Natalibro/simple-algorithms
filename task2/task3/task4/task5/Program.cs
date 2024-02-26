//Задача с прпвильным решением 4

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
int variable = number;

while(variable != 0)
{
    variable = variable / 10;
    i *= 10;
}
//Console.WriteLine(i);

while(i > 1)
{
    i = i/10;
    variable = number / i;
    if(i >1){
        Console.Write(variable + ", ");
        number = number % i;
    }
    else {
        Console.Write(variable);
    }
}
