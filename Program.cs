using dotnet.Models;


int numero = 2;
int contador = 1;

while(contador <= 2)
{
    Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {contador / numero}");
    contador++;
    
}



















// int numero = 5;
// for (int contador = 0; contador <= 10; contador++){

//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");


// }




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





















// bool choveu = false;
// bool staTarde = false;


// if(!choveu && !staTarde ){
//     Console.WriteLine("vou pedelar");
// }else{
// Console.WriteLine("vou pedalar outro dia");
// }










// bool ehMaiorIdade = false;
// bool autorizacaoResponsavel = false;

// if(ehMaiorIdade || autorizacaoResponsavel){
//     Console.WriteLine("Entrada liberada");
// }else{
//     Console.WriteLine("Entrada não liberada");
// }























// Console.WriteLine("Digite uma vogal");
// string letra = Console.ReadLine();


// switch(letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":

//     Console.WriteLine("vogal");
//     break;
//     default: 
//     Console.WriteLine("não é uma vogal");
//     break;
// }














// if(letra == "a"||
//     letra == "e"||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u"){
//         Console.WriteLine("é uma vogal");
//     }else{
//         Console.WriteLine("Não é uma vogal");
//     }




















// int qtdEmEstoque = 4;
// int qtdCompra = 0;
// bool possivelVenda = qtdCompra > 0 && qtdEmEstoque >= qtdCompra;

// Console.WriteLine($"Quantidade em estoque: {qtdEmEstoque}");
// Console.WriteLine($"Quantidade de compra: {qtdCompra}");
// Console.WriteLine($"É possivel realizar a compra? {possivelVenda}");

// if(qtdCompra == 0){
//     Console.WriteLine("Compra inválida");
// }else 
// if(qtdEmEstoque >= qtdCompra){
//     Console.WriteLine("Compra realizada com sucesso");
// }
// else{
//     Console.WriteLine("Desculpe, não temos quantidade o suficiente no estoque");
// }








// string sim = "12";
// int  s = Convert.ToInt32(sim);

// Console.WriteLine(s);




// // convertendo long para Int com ToInt32
// long c = 5;
// int d = Convert.ToInt32(c);


// Console.WriteLine(d);

// // conversão de tipo de variaveis
// int a = 5;
// // double b = a;

// // Console.WriteLine(b);


// //Convertendo de maneira segura
// string e = "15-";
// // int f = 0;

// int.TryParse(e, out int f);

// Console.WriteLine(f);
// Console.WriteLine("Convertido com sucesso!");





// int inteiro = 5;
// string a = inteiro.ToString();
// //int a = int.Parse("Sc");

// Console.WriteLine(a);


// int a = 24;
// int b = 45;

// int c = a + b;

// //c = c + 5 Isto é igual a aquilo
//  c += 5;
// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now.AddDays(3);
// Console.WriteLine(dataAtual.ToString("dd/MM/yy"));





// string apresentacao = "Ola, seja bem-vindo";
// int quantidade = 1;
// Console.WriteLine("Valor da quantidade: " + quantidade);
// // Posso alterar o valor da minha variável quantas vezes eu quiser, porém,
// // ela não deve ser repetida com o seu tipo de variável, mas a nomenclatura está liberada.
// quantidade = 10;
// Console.WriteLine("Valor da quantidade: " + quantidade);
// // double altura = 1.80;
// // decimal preco = 1.99M;
// // bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da altura: " + altura.ToString("0.00")); //toString é a quanridade de números que eu quero no meu double
// Console.WriteLine("Valor da preço: " + preco);
// Console.WriteLine("Valor da condicao: " + condicao);

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Brena";
// pessoa1.Idade = 26;
// pessoa1.Apresentar();

// Pessoa pessoaFisicaRepresentacao = new Pessoa();

