// Exercício do site URI "PUM"
// Esse programa o usuário ira digitar a quantidade de linhas para aparecer a mensagem "1 2 3 PUM".
// Assim cada linha vai somando mais 1, menos o "PUM".


int N = int.Parse(Console.ReadLine());

int Num1 = 1;
int Num2 = 2;
int Num3 = 3;
for (int i = 1; i <= N; i++)
{
    Console.WriteLine(Num1 + " " + Num2 + " " + Num3 + " PUM");
    Num1 = Num1 + 4;
    Num2 = Num2 + 4;
    Num3 = Num3 + 4;
}
