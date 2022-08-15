int count = 0, distance = 10000, FriendV1 = 1, FriendV2 = 2, dogV = 5, friend = 2, time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (FriendV1 + dogV);
        friend = 2;
    }
    else
    {
        time = distance / (FriendV2 + dogV);
        friend = 1;
    }
distance = distance - (FriendV1 + FriendV2) * time;
count++;

}

Console.Write("Dog will run ");
Console.Write(count);
Console.Write(" times before friends meet each other");
//Console.Write($"Dog will run {count} times before friends meet each other");
