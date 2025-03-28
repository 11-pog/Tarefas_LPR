#include <iostream>

using namespace std;

int main()
{
    int sum = 0;

    for(int i = 50; i <= 500; i++)
    {
        if (i % 2 == 1 &&
            i % 3 == 0)
        {
            sum += i;
        }
    }

    cout << sum;;
}