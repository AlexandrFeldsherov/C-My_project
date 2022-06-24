int nDog=1;
bool fS=false;

Console.WriteLine("ведите скорость первого друга ");
int vFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите скорость второго друга ");
int vSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите скорость собаки, но учти собака быстрее друзей!  ");
int vDog= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите расстояние между друзей ");
int sFriend = Convert.ToInt32(Console.ReadLine());
for(;sFriend<1;nDog++)
{
    if fS==true {
        sFriend=sFriend-(vFirst+vSecond)*(sFriend/(vDog+vSecond));
        fS=true;
    }
    else {
        sFriend=sFriend-(vFirst+vSecond)*(sFriend/(vDog+vFirst));
        fS=false;
    }
}
Console.Write("Собака пробежала от одного друга до другогого, до того момента как они встретились "+nDog+" раз!!");
