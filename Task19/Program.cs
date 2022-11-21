int num, rem, sum = 0, temp;
Console.WriteLine("Enter a number: ");
num = Convert.ToInt32(Console.ReadLine());
temp = num;
if (num < 0) Console.WriteLine("A palindrom cannot be a negativ number");
while (num > 0)
{
    rem = num % 10;  
    num = num / 10; 
    sum = sum * 10 + rem; 
}
if (temp == sum) 
{
    Console.WriteLine("Number is palindrome");
}
else 
{
    Console.WriteLine("Number is not a palindrome");
}
    