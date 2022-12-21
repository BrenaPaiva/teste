## Operadores de atribuição
* Diferença entre convert e Parse
* Convertendo tipo de variaveis
```cs

string sim = "12";
int  s = Convert.ToInt32(sim);

Console.WriteLine(s);
// convertendo long para Int com ToInt32
 long c = 5;
 int d = Convert.ToInt32(c);


 Console.WriteLine(d);

 // conversão de tipo de variaveis
 int a = 5;
 double b = a;
Console.WriteLine(b);
// Convertendo de maneira segura
string e = "15-";
int f = 0;

 int.TryParse(e, out int f);

 Console.WriteLine(f);
 Console.WriteLine("Convertido com sucesso!");
```
## Operadores aritméticos
```cs
 public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");

        }
            public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");

        }
            public void Multiplicacao(int x, int y){
            Console.WriteLine($"{x} * {y} = {x * y}");

        }
            public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}");

        }
            public void Potencia(int x, int y){
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");

        }
            public void Seno(double angulo){
                double radiano = angulo * Math.PI / 180;
                double seno = Math.Sin(radiano);
                Console.WriteLine($"seno de angulo {angulo}° = {Math.Round(seno, 4)}");

         }
           public void Coseno(double angulo){
                double radiano = angulo * Math.PI / 180;
                double coseno = Math.Cos(radiano);
                Console.WriteLine($"Coseno de angulo {angulo}° = {Math.Round(coseno, 4)}");

         }
           public void Tangente(double angulo){
                double radiano = angulo * Math.PI / 180;
                double tangente = Math.Tan(radiano);
                Console.WriteLine($"tangente de angulo {angulo}° = {Math.Round(tangente, 2)}");

         }
         //Calculando em raiz quadrada
         public void RaizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {Math.Round(raiz)}");
    }
}

```
# Call
*Chamando em outra rota
```cs
Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Dividir(24, 2);
calc.Multiplicacao(2, 25);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);
```