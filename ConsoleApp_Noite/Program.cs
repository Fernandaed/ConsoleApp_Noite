// See https://aka.ms/new-console-template for more information
using ConsoleApp_Noite;
using ConsoleApp_Noite.Heranca;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, 10.90M, "Cervejinha");

Console.WriteLine(p1.getDescricao()+" "+p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1 litro");

Console.WriteLine(p1.getDescricao()+ " " + p1.getValor());


Endereco endereco = new Endereco("Rua Mario Miziara", "91", "Sobral", "15906304", "Taquaritinga", "SP");


Cliente c1 = new Cliente(1, "Gabriele", "9913456895", endereco);
Cliente c2 = new Cliente(2, "Gabriela", "9913456895", endereco);
Cliente c3 = new Cliente(3, "Ryan", "9913456895", endereco);
Cliente c4 = new Cliente(4, "Fernanda", "9913456895", endereco);
Cliente c5 = new Cliente(5, "Giovanni", "9913456895", endereco);

//Console.WriteLine(c2.getEndereco().getRua() + " " + c2.getEndereco().getNumero() );

//c2.getEndereco().setNumero("135");

//Console.WriteLine(c2.getEndereco().getNumero());

Console.WriteLine(c2.getEndereco().EnderecoCompleto());



// Pasta Herança


Carro gol = new Carro();
gol.temMotor = true;
gol.numeroPortas = 4;
gol.numeroAssentos = 5;
gol.fabricante = "VW";
gol.CintoSeguranca = true;
gol.ArCondicionado = false;


Bike caloi = new Bike();
caloi.temMotor = false;
caloi.numeroPortas = 0;
caloi.numeroAssentos = 1;


Carro Saveiro = new Carro();
Saveiro.fabricante = "VW";


Carro Uno = new Carro();
Uno.fabricante = "Fiat";

Carro Palio = new Carro();
Palio.fabricante = "Fiat";

Bike speed = new Bike(); 
speed.temMotor = false;
speed.numeroPortas = 0;

//Faça uma ação chamada ExibirDados
//mostre as informações na tela pelo Console.WriteLine

Console.WriteLine(speed.ExibirDados());
Console.WriteLine(gol.ExibirDados());


// Lista

List<Carro> listaCarros = new List<Carro>();
listaCarros.Add(gol);
listaCarros.Add(Palio);
listaCarros.Add(Uno);
listaCarros.Add(Saveiro);

Console.WriteLine(listaCarros[0].fabricante);

listaCarros.Remove(Palio);

//exibir a quantidade de itens da lista

for(int i = 0; i < listaCarros.Count; i++)
{
    Console.WriteLine(listaCarros[i].ExibirDados());
}

// ou

foreach(var item in listaCarros)
{
    Console.WriteLine(item.ExibirMarca());
}


//Imprima na tela todos os clientes desse contexto;
//Crie uma lista para eles;

//Crie uma lista com 560 produtos e imprima na tela
//Crie uma lista que aceite qualquer tipo de veículo e imprima na tela;

List<Cliente> listaCliente = new List<Cliente>();
listaCliente.Add(c1);
listaCliente.Add(c2);
listaCliente.Add(c3);
listaCliente.Add(c4);
listaCliente.Add(c5);

foreach (var item in listaCliente)
{
    Console.WriteLine(item.ExibirClientes());
}

// 560 produtos

List<Produto> listaProduto = new List<Produto>();


for(int produto = 1; produto <= 560 ; produto++)
{
    Console.WriteLine("Produto n° " + produto);
}  


//Lista que aceite qualquer tipo de veiculo

List<Veiculo> listaVeiculos = new List<Veiculo>();


