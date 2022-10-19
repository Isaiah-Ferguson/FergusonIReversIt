//Isaiah Keith Ferguson
//10/18/2022
//Reverse IT
//We will be reversing the user's input.
//Peer Reviewed by:

Console.Clear();

string endingString = "";

while(endingString != "end")
{
string input = "";
string revInput = "";
int remainder = 0;
int revNumber = 0;
bool trueNumber = true;
int realNumber = 0;

Console.WriteLine("Lets reverse it!");
Console.WriteLine("Please enter characters");

input = Console.ReadLine();
trueNumber = Int32.TryParse(input, out realNumber);

if (trueNumber)
{
    while (realNumber > 0)
    {
        remainder = realNumber % 10;
        realNumber = realNumber / 10;
        revNumber = (revNumber * 10) + remainder;
    }
Console.WriteLine(input + " | " + revNumber);
}
else
{
    for (int i = input.Length - 1;i >= 0; i--)
    {
        revInput = revInput + input[i];
    }
Console.WriteLine(input + " | " + revInput);
} 
Console.WriteLine("Please type 'End' To Terminate the program or press 'Enter' to play again");
endingString = Console.ReadLine().ToLower();
}
