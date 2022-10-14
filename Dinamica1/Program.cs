string[,] maquinaDeBebidas = new string[2, 2];
double[,] valorBebidas = new double[2, 2];
maquinaDeBebidas[0, 0] = "Coca-Cola";
valorBebidas[0, 0] = 5;
maquinaDeBebidas[0, 1] = "Pepsi";
valorBebidas[0, 1] = 4;
maquinaDeBebidas[1, 0] = "Água";
valorBebidas[1, 0] = 2;
maquinaDeBebidas[1, 1] = "Fanta Uva";
valorBebidas[1, 1] = 3;




for (int i = 0; i < maquinaDeBebidas.GetLength(0); i++)
{
    for (int j = 0; j < maquinaDeBebidas.GetLength(1); j++)
    {
        Console.WriteLine($"{ maquinaDeBebidas[i, j]} | Valor: R$ {valorBebidas[i, j]} ");
    }
}