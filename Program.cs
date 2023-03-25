string[] InitArray = new string[5] { "12345", "hello", "=)", "yes", "home"};
string[] FinalArray = new string[InitArray.Length];

void FormArrayOfStrings(string[] InitArray, string[] FinalArray)

{
    int count = 0;
    for (int i = 0; i < InitArray.Length; i++)
    {
        if (InitArray[i].Length <= 3)
        {
            FinalArray[count] = InitArray[i];
            count++;
        }
    }
}