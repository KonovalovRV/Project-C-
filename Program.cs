
double v1 = 10; //speed man1
double v2 = 6; //speed man2
double v3 = 20; //speed dog
count = 0;//count  
distance = 10000;//distance between man1 and man2
man=2;

while (distance > 10)
  if(man=1)
{       
        t = distance / (v2 + v3);
        man = 2;
        distance = distance-(v2 + v1)*t;
}
    if (man=2)
{   
        t = distance / (v1 + v3);
        man = 1;
        distance = distance-(v2 + v1)*t;
}    
    count = count + 1;

Console.WriteLine(count);


