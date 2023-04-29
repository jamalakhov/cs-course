// 70. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

Console.Clear();

int n = 3; // длина слова

char[] alphabet = { 'а', 'и', 'с', 'в' }; // алфавит
string[] words = new string[CalculateNumberOfWords(alphabet.Length, n)]; // массив для хранения слов
char[] word = new char[n]; // массив для хранения слова
int wordIndex = 0;

GenerateWords(alphabet, word, n, 0); // вызываем рекурсивную функцию
PrintArr(words); // печатаем массив слов

/////////////////////////////////////////////////////////////////////////
void GenerateWords(char[] alphabet, char[] word, int n, int pos)
{
    if (pos == n) // если мы дошли до конца слова
    {
        words[wordIndex] = string.Concat(word); // сохраняем слово в массив
        wordIndex++;
        return;
    }
    // перебираем все символы алфавита и добавляем их в текущую позицию слова
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[pos] = alphabet[i];
        GenerateWords(alphabet, word, n, pos + 1); // рекурсивно вызываем функцию для следующей позиции
    }
}

int CalculateNumberOfWords(int alphabetSize, int wordLength)
{
    return (int)Math.Pow(alphabetSize, wordLength); // количество возможных слов
}

void PrintArr(string[] arr)
{
    foreach (string str in arr)
    {
        Console.WriteLine(str);
    }
}