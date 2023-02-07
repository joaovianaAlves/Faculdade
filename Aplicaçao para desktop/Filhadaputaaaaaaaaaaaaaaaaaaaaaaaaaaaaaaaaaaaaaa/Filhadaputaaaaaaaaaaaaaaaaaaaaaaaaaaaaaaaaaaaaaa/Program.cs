float altura = 0;
float b = 0;
double area;

static float getAltura(float altura){
    Console.WriteLine("Digite a altura:");
    altura = float.Parse(Console.ReadLine());
    {
        while (altura <= 0)
        {
            Console.WriteLine("Valor invalido Redigite:");
            altura = float.Parse(Console.ReadLine());
        }
        return altura;
}
}

static float getBase(float b){
    Console.WriteLine("Digite a base:");
    b = float.Parse(Console.ReadLine());

    while (b <= 0)
    {
        Console.WriteLine("Valor invalido Redigite:");
        b = float.Parse(Console.ReadLine());
    }
    return b;
}

static void getArea(float altura, float b){
   
    float x = getAltura(altura);
    
    float y = getBase(b);
    
    Console.WriteLine("Area do seu triangulo: " + (y*x) /2);
}

getArea(altura,b);