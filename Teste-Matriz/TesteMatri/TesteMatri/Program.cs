using System;
using System.Security.Cryptography;
using TesteMatri;


internal class Program
{
    private static void Main(string[] args)
    {


        //Matriz matriz = new Matriz(, );


        //matriz.gerarMatriz();

        //matriz.printMatriz();

        //matriz.diagonalPrincipal();
        //matriz.diagonalSecundaria();

        //matriz.trocaDiagonal();

        //matriz.printMatriz();



        // Alterenativa 2 do teste

        int[][] jaggedArray2 = new int[][]
        {
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 0, 2, 4, 6 ,8},
            new int[] { 11, 22 ,10, 15,3}
         };

        int[][] jaggedArray3 = new int[][]
      {
            new int[] { 1, 3, 9 },
            new int[] { 0, 2, 6 },
            new int[] { 11, 22,10 }
       };







        Console.WriteLine(  matrizFind(jaggedArray2, jaggedArray3));
         



        static int matrizFind(int[][] matrizMaior, int[][] matrizMenor)
        {


            // Computa o tamanho das matrizes. 
            int alturaMenor = matrizMenor.Length;
            int larguraMenor = alturaMenor == 0 ? 0 : matrizMenor[0].Length;
            int alturaMaior = matrizMaior.Length;
            int larguraMaior = alturaMaior == 0 ? 0 : matrizMaior[0].Length;

            int quantidade = 0;

            // [Opcional] Rejeita matrizes que tiverem linhas com larguras heterogêneas.
            for (int t = 1; t < alturaMaior; t++)
            {
                if (matrizMaior[t].Length != larguraMaior)
                {
                    Console.WriteLine("Ambas as matrizes devem ter larguras homogêneas.");
                }
            }
            for (int t = 1; t < alturaMenor; t++)
            {
                if (matrizMenor[t].Length != larguraMenor)
                {

                    Console.WriteLine("Ambas as matrizes devem ter larguras homogêneas.");

                }
            }

            // Percorre as linhas da matriz maior 
            for (int a = 0; a <= alturaMaior - alturaMenor; a++)
            {
                // Percorre as colunas da matriz maior 
                for (int b = 0; b <= larguraMaior - larguraMenor; b++)
                {

                    // Tendo a posição [a][b] da matriz maior como correspondente ao possível canto superior esquerdo da matriz menor,
                    // verifica se essa posição contém a matriz menor ao percorrer ambas as matrizes juntas 
                    // Começa percorrendo as linhas de ambas as matrizes.
                    for (int c = 0; c < alturaMenor; c++)
                    {
                        // Percorre as colunas de ambas as matrizes.
                        for (int d = 0; d < larguraMenor; d++)
                        {

                            // Se as coordenadas tiverem valores diferentes, então essa posição da matriz maior não contém a menor.
                            // Dessa forma, se for esse o caso, interrompe o processo de percorrer ambas as matrizes juntas e avança para a
                            // próxima possibilidade na matriz maior.
                            if (matrizMaior[a + c][b + d] != matrizMenor[c][d])
                            {
                                continue;


                            }
                            else
                            {
                                quantidade++;
                            }

                        }
                    }

                   

                }
            }

           
            return quantidade++;
        }


    }
}