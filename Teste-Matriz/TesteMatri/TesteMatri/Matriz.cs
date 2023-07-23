using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TesteMatri;


internal class Matriz
{
    public int linhas, colunas;

    public string[,] matriz;

    public bool MatrizQuadrada = false;




    public Matriz(int linhas, int colunas)
    {
        this.linhas = linhas;
        this.colunas = colunas;
        this.matriz = new string[this.linhas, this.colunas];

        this.gerarMatriz();


        if (this.linhas == this.colunas)
        {
           this.MatrizQuadrada = true;

        }

    }

    public void gerarMatriz()
    {
        for (int i = 0; i < this.linhas; i++)
        {
            for (int j = 0; j < this.colunas; j++)
            {

                matriz[i, j] = Console.ReadLine(); //(int) new Random().Next() * 100_000 / 100;
            }
        }
    }

    public void printMatriz()
    {
        for (int i = 0; i < this.linhas; i++)
        {
            for (int j = 0; j < this.colunas; j++)
            {

                Console.Write(matriz[i, j] + " ");
            }

            Console.WriteLine();
        }
    }


    public string diagonalPrincipal()
    {
        string[] vet = new string[this.colunas];
        string[] Princ = new string[this.colunas];
        // guardar diagonal primária da matriz
        for (int i = 0; i < this.linhas; i++)
        {
            for (int j = 0; j < this.colunas; j++)
            {
                if (i == j)
                {
                    vet[i] = matriz[j, i];
                    Princ[i] = vet[i];
                    Console.Write(" ", vet[i]);
                }
            }
        }

        return Princ[this.colunas];
    }

    public string diagonalSecundaria()
    {
        string[] vet2 = new string[this.colunas];
        string[] Secun = new string[this.colunas];

        Console.WriteLine("Guardando diagonal secundária da  matriz");

        // guardar diagonal secundária da  matriz
        for (int i = 0; i < this.linhas; i++)
        {
            for (int j = 0; j < this.colunas; j++)
            {
                if (i + j == this.colunas - 1)
                {
                    vet2[i] = matriz[i, j];
                    Secun[i] = vet2[i];
                    Console.Write(" ", vet2[i]);
                }
            }

        }

        return Secun[this.colunas];

    }

    public void trocaDiagonal()
    {
        for (int i = 0; i < this.linhas; i++)
        {
            for (int j = 0; j < this.colunas; j++)
            {
                if (i == j)     // diagonal primaria
                {
                    matriz[i, j] = diagonalSecundaria();
                    {

                    }
                    if (i + j == 3) // diagonal secundaria
                    {
                        matriz[i, j] = diagonalPrincipal();
                    }
                }
            }
        }
    }


 



    //List<List<Integer>> result = new ArrayList<>();
    //for (int i = rowStart; i <= rowEnd; i++)
    //{
    //    List<Integer> row = new ArrayList<>();
    //    for (int j = colStart; j <= colEnd; j++)
    //    {
    //        row.add(matrix[i][j]);
    //    }
    //    result.add(row);
    //}

    //System.out.println("The maximum sum submatrix is " + result);
    //return maxSum;
}






