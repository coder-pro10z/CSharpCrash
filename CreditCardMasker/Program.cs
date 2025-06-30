using System.IO;

class CreditCardMasker
{
    public static void Main()
    {
        string card_num;
        //bool isValid;

        do
        {
            Console.WriteLine("Enter a Credit Card Number:");
            card_num = Console.ReadLine();
        }while (String.IsNullOrEmpty(card_num));

        string maskedNum=String.Empty;

        //Console.WriteLine(card_num);

        for (int i = 0; i < card_num.Length; i++)
        {
            if (card_num[i] == '-' || Char.IsWhiteSpace(card_num[i]) || i >= card_num.Length - 4)
                maskedNum += card_num[i];
            else
                maskedNum += 'X';
        }
    Console.WriteLine(maskedNum);
    }
}