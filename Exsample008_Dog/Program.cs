int count = 0;
int distance = 10000;
int firstFriendspeed = 1;
int secondFriendspeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;


while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendspeed + dogSpeed);
        friend = 2;
    }

    else
    {
        time = distance / (secondFriendspeed + dogSpeed);
        friend = 1;
    }

    distance = distance - (firstFriendspeed + secondFriendspeed) * time;
    count++;

}
Console.Write("count = ");
Console.WriteLine(count);