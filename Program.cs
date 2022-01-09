// See https://aka.ms/new-console-template for more information
int[] yearPrices = {10,5,3 };
int firstYear, secondYear, thirdYear;
firstYear = yearPrices[0];
secondYear = yearPrices[1];
thirdYear = yearPrices[2];

if(firstYear - secondYear < firstYear -thirdYear) 
{
    if (firstYear - secondYear < secondYear - thirdYear)
    {
        string firstYear1, secondYear1;
        string answer;
        int answer1;
        answer1 = firstYear - secondYear;
        answer = answer1.ToString();
        firstYear1 = firstYear.ToString();
        secondYear1 = secondYear.ToString();
        Console.WriteLine("the minimum loss is " +  firstYear1 + " - " + secondYear1 + " = " + answer);



    }
    else
    {
        string secondYear1, thirdYear1;
        string answer;
        int answer1;
        answer1 = secondYear - thirdYear;
        answer = answer1.ToString();
        thirdYear1 = thirdYear.ToString();
        secondYear1 = secondYear.ToString();
        Console.WriteLine("the minimum loss is " +secondYear1 + " - " + thirdYear1 + " = " + answer);
    }
}
else
{
    string firstYear1, thirdYear1;
    string answer;
    int answer1;
    answer1 = firstYear - thirdYear;
    answer = answer1.ToString();
    thirdYear1 = thirdYear.ToString();
    firstYear1 = firstYear.ToString();
    Console.WriteLine("the minimum loss is " + firstYear1 + " - " + thirdYear1 + " = " + answer);
}