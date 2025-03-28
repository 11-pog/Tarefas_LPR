#include <iostream>

using namespace std;

int InputNum(const string Error_Log, bool Unsigned = false, bool AllowZero = true);

int main()
{
    cout << "Por favor entre com a quantidade de números que serão digitados: ";
    int NumberAmount = InputNum("Número inválido, tente novamente: " , true, false);

    cout << "Por favor entre com " << NumberAmount << " números." << endl;

    int NumberArray[NumberAmount];
    for (int i = 0; i < NumberAmount; i++)
    {
        cout << i + 1 << ": ";
        NumberArray[i] = InputNum("Número inválido, tente novamente: ");
    }

    int sum = 0;
    int index = 0;
    int sumIndex = 0;

    while (index < NumberAmount)
    {
        if (NumberArray[index] % 2 == 0)
        {
            sum += NumberArray[index];
            sumIndex++;
        }

        index++;
    }

    if (sumIndex == 0) sumIndex = 1;

    cout << "A media dos números pares é " << sum/sumIndex << endl;
    cin.ignore();
}


int InputNum(const string Error_Log, bool Unsigned, bool AllowZero)
{
    while (1)
    {
        string Input;
        cin >> Input;

        try
        {
            int Output = stoi(Input);

            if ((AllowZero || Output != 0) &&
                (!Unsigned || Output >= 0))
            {
                return Output;
            }
        }
        catch (const invalid_argument&) {}

        cout << Error_Log;
    }
}