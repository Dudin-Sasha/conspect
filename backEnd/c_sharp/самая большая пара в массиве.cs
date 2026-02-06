using System.ComponentModel;

int[][] arrOfArrs =
{
    new int[]{4,5,13,6,7,8,100},
    new int[]{1,200,15,14,3,500,2},
    new int[]{4,5,13,6,7,8,1},
};


int max = 0;
for (int i = 0; i < arrOfArrs.Length; i++)
{
    Console.WriteLine();
    for (int j = 0; j < arrOfArrs[i].Length; j++)
    {
        Console.Write(arrOfArrs[i][j] + " ");
        if (i < arrOfArrs.Length - 1)
        {
            if (j > 0 && j < arrOfArrs[i].Length - 1-1)
            {
                //стороны
                if ((arrOfArrs[i][j] + arrOfArrs[i][j + 1]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i][j + 1];
                }
                if ((arrOfArrs[i][j] + arrOfArrs[i][j - 1]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i][j - 1];
                }
                //низ
                if ((arrOfArrs[i][j] + arrOfArrs[i + 1][j]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i + 1][j];
                }
                if ((arrOfArrs[i][j] + arrOfArrs[i + 1][j - 1]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i + 1][j - 1];
                }
                if ((arrOfArrs[i][j] + arrOfArrs[i + 1][j + 1]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i + 1][j + 1];
                }

            }
            else if (j == 0)
            {

                //стороны
                if ((arrOfArrs[i][j] + arrOfArrs[i][j + 1]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i][j + 1];
                }

                //низ
                if ((arrOfArrs[i][j] + arrOfArrs[i + 1][j]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i + 1][j];
                }
                if ((arrOfArrs[i][j] + arrOfArrs[i + 1][j + 1]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i + 1][j + 1];
                }

            }

            else if (j == arrOfArrs[i].Length - 1)
            {

                //стороны

                if ((arrOfArrs[i][j] + arrOfArrs[i][j - 1]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i][j - 1];
                }

                //низ
                if ((arrOfArrs[i][j] + arrOfArrs[i + 1][j]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i + 1][j];
                }
                if ((arrOfArrs[i][j] + arrOfArrs[i + 1][j - 1]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i + 1][j - 1];
                }

            }

        }
   
        if (i == arrOfArrs.Length - 1)
        {
            if (j > 0 && j < arrOfArrs[i].Length - 1)
            {

                //стороны
                if ((arrOfArrs[i][j] + arrOfArrs[i][j + 1]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i][j + 1];
                }
                if ((arrOfArrs[i][j] + arrOfArrs[i][j - 1]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i][j - 1];
                }

            }
            else if (j == 0)
            {

                //стороны
                if ((arrOfArrs[i][j] + arrOfArrs[i][j + 1]) > max)
                {
                    max = arrOfArrs[i][j] + arrOfArrs[i][j + 1];
                }


                else if (j == arrOfArrs[i].Length - 1)
                {
                    //стороны

                    if ((arrOfArrs[i][j] + arrOfArrs[i][j - 1]) > max)
                    {
                        max = arrOfArrs[i][j] + arrOfArrs[i][j - 1];
                    }
                }
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine('\n'+max);
//Console.WriteLine(arrOfArrs[1][1]);