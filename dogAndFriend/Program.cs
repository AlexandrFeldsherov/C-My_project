Console.WriteLine("ведите скорость первого друга ");
int vFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите скорость второго друга ");
int vSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите скорость собаки, но учти собака быстрее друзей!  ");
int vDog= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите расстояние между друзей ");
int sFriend = Convert.ToInt32(Console.ReadLine());
bool fS=false;
int N=0;

for (int nDog=0;sFriend<1;nDog++,N=nDog) Console.Write("Собака пробежала от одного друга до другогого, до того момента как они встретились "+nDog+" раз!!");
{
    if (fS==true) 
    {
        sFriend=sFriend-(vFirst+vSecond)*(sFriend/(vDog+vFirst));
        fS=false;
        Console.WriteLine(N);
    }
    else
    {
        sFriend=sFriend-(vFirst+vSecond)*(sFriend/(vDog+vSecond));
        fS=true;
        Console.WriteLine(N);
    }

}
 Console.Write("Собака пробежала от одного друга до другогого, до того момента как они встретились "+N+" раз!!");
