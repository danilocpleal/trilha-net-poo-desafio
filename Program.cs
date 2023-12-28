using DesafioPOO.Models;

string nrocelular;
string modelcelular;
string imeicelular;
int qtdememoria;
string app;

Console.WriteLine("Smartphone Nokia:");

Console.WriteLine("Qual o número do celular:");
nrocelular = Console.ReadLine();
Console.WriteLine("Qual o modelo do celular:");
modelcelular = Console.ReadLine();
Console.WriteLine("Qual o IMEI do celular:");
imeicelular = Console.ReadLine();
Console.WriteLine("Qual a qtde de memória do celular:");
qtdememoria = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o aplicativo que deseja instalar no celular:");
app = Console.ReadLine();


Smartphone nokia = new Nokia(numero: nrocelular, modelo: modelcelular, imei: imeicelular, memoria: qtdememoria);
nokia.Ligar();
nokia.InstalarAplicativo(app);

Console.WriteLine("");
Console.WriteLine("Smartphone Iphone:");

Console.WriteLine("Qual o número do celular:");
nrocelular = Console.ReadLine();
Console.WriteLine("Qual o modelo do celular:");
modelcelular = Console.ReadLine();
Console.WriteLine("Qual o IMEI do celular:");
imeicelular = Console.ReadLine();
Console.WriteLine("Qual a qtde de memória do celular:");
qtdememoria = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o aplicativo que deseja instalar no celular:");
app = Console.ReadLine();

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: nrocelular, modelo: modelcelular, imei: imeicelular, memoria: qtdememoria);
iphone.Ligar();
iphone.InstalarAplicativo(app);