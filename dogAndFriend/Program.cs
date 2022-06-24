Console.WriteLine("ведите скорость первого друга ");
int vFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите скорость второго друга ");
int vSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите скорость собаки, но учти собака быстрее друзей!  ");
int vDog= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите расстояние между друзей ");
int sFriend = Convert.ToInt32(Console.ReadLine());
int nDog=0;
bool fS=false;
while(sFriend<1)
{
    if (fS==true) 
    {
        sFriend=sFriend-(vFirst+vSecond)*(sFriend/(vDog+vSecond));
        fS=true;
        nDog=nDog+1;

    }
    else 
    {
        sFriend=sFriend-(vFirst+vSecond)*(sFriend/(vDog+vFirst));
        fS=false;
         nDog=nDog+1;
    }
}
Console.Write("Собака пробежала от одного друга до другогого, до того момента как они встретились "+nDog+" раз!!");

