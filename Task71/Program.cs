// 71. Есть два массива info и data.
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении.
// Числа идут друг за другом без разделителей.
// Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1}
// info = {2, 3, 3, 1}

// выходные данные:
// 1, 7, 0, 1

Console.Clear();

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

int[] decimArr = ConvertToDecimal(data, info);

Console.WriteLine(string.Join(", ", decimArr));

/////////////////////////////////////////////////////////
int[] ConvertToDecimal(int[] dataArr, int[] infoArr)
{
    int[] decimalNumberArr = new int[infoArr.Length];
    int indexArr = 0;

    int startIndex = 0;
    int stopIndex = 0;

    int[] number;
    foreach (int bitCount in infoArr)
    {
        number = new int[bitCount];
        stopIndex = startIndex + bitCount;

        if (stopIndex <= dataArr.Length)
        {
            int index = 0;
            for (int j = startIndex; j < stopIndex; j++)
            {
                number[index] = dataArr[j];
                index++;
            }

            int decimalNumber = Convert.ToInt32(string.Concat(number), 2);
            decimalNumberArr[indexArr] = decimalNumber;
            indexArr++;
        }

        startIndex = stopIndex;
    }
    return decimalNumberArr;
}