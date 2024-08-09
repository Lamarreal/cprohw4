using cprohw4;
using StaticClasses;

int factor = MathHelper.Factorial(5); //- 120
int Gdivisor = (int)MathHelper.lcm(8,12); //-24
int Ldivisor = (int)MathHelper.lcm(100, 50); //-50

ApplicationSettings appSettings = new();
Console.WriteLine(appSettings.dataSettings.connStatus);

Storage<int> IntStorage = new();
IntStorage.SetItem(1);

Storage<string> strStorage = new();
strStorage.SetItem("text");

var timer = new cprohw4.Timer();
void Test(cprohw4.Timer self)
{
    Console.WriteLine("test 123");
}

timer.OnTimeElapsed += Test;

await timer.Start(1000);

Console.WriteLine(strStorage.GetValue());
Console.WriteLine(IntStorage.GetValue());
Console.WriteLine(Gdivisor);