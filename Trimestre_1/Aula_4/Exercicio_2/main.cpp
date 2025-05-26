#include <iostream>
#include <string>

using namespace std;

// Func Prototype
long InputLong(string error_log);

int main()
{
    cout << "Entre com um valor inteiro" << endl;
    long Divisor = InputLong("Numero Inválido, digite outro: ");

    cout << "Entre com outro valor inteiro" << endl;
    long Dividend = InputLong("Numero Inválido, digite outro: ");

    cout << Divisor << " e "<< Dividend;

    if (Dividend % Divisor == 0)
    {
        cout << " são multiplos" << endl;
    }
    else
    {
        cout << " não são multiplos" << endl;
    }

    return 0;
}


long InputLong(string error_log)
{
    while(true)
    {
        string input;
        cin >> input;

        try
        {
            return stoi(input);
        }
        catch (const exception& e)
        {
            cout << error_log << endl;
        }
    }
}