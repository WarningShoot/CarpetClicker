using System;
using System.Numerics;

[Serializable]
public class BigNumber
{
    public BigInteger Number { get; private set; }
    public string NumberString => Number.ToString();
    public int NumberLenght => NumberString.Length;

    public BigNumber()
    {
        Number = new BigInteger(0);
    }

    public BigNumber(int number)
    {
        Number = new BigInteger(number);
    }

    public BigNumber(string number)
    {
        Number = BigInteger.Parse(number);
    }

    public BigNumber(BigInteger number)
    {
        Number = number;
    }

    public void AddNumber(BigInteger number)
    {
        Number += number;
    }

    public string GetFormattedNumber()
    {
        if (NumberLenght <= 3)
            return NumberString;

        var offset = NumberLenght % 3;
        var bigNumberNotification = (BigNumberNotifications)(int)MathF.Floor((NumberLenght - 1) / 3f);

        var formattedNumber = "";

        switch (offset)
        {
            case 0:
                formattedNumber = $"{NumberString[0]}{NumberString[1]}{NumberString[2]}.{NumberString[3]}{NumberString[4]}";
                break;

            case 2:
                formattedNumber += $"{NumberString[0]}{NumberString[1]}.{NumberString[2]}{NumberString[3]}";
                break;

            case 1:
                formattedNumber += $"{NumberString[0]}.{NumberString[1]}{NumberString[2]}";
                break;
        }

        return formattedNumber + bigNumberNotification.ToString();
    }
}

internal enum BigNumberNotifications
{
    K = 1,
    M,
    B,
    T,
    A,
    C,
    D,
    E,
    F,
    G,
    H,
    I,
}