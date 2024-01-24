// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("PosVenda DEV");
Console.WriteLine("===============================");
var opcao = 0;
var validador = true;
while (validador)
{
    
    
    Console.WriteLine("escolha uma opção!");
Console.WriteLine("[1] Verificar Clientes Cadastrados: ");
Console.WriteLine("[2] Cadastrar Cliente:");
Console.WriteLine("[3] Atualizar Dados Do Cliente:");
Console.WriteLine("[4] Verificar Status do pedido Do Cliente: ");
Console.WriteLine("[5] Excluir Cliente:");
Console.WriteLine("[6] Sair");
    Console.WriteLine("===============================");
 
    



        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("tudo no 01");

                break;
            case "2":
                Console.WriteLine("Hora de Cadastrar o Cliente:");
                Console.WriteLine("===============================");
                Console.WriteLine("informe seu nome: ");
                var nomeCliente = Console.ReadLine();
                Console.WriteLine("Informe seu CPF:");
                var cpfCliente = Console.ReadLine();
                Console.WriteLine("Informe sua Dada de Nascimento");
                var dataDeNascimentoCliente = Console.ReadLine();
                Console.WriteLine("===============================");
                Console.WriteLine("Informe Seu Endereço");
                Console.WriteLine("Rua:");
                var ruaCliente = Console.ReadLine();
                Console.WriteLine("Bairro:");
                var bairroCliente = Console.ReadLine();
                Console.WriteLine("Cidade:");
                var cidadeCliente = Console.ReadLine();
                Console.WriteLine("Qual estador Que vc Mora:");
                var EstadoCliete = Console.ReadLine();
                Console.WriteLine("Complemento:");
                var complementoCliente = Console.ReadLine();
                Console.WriteLine("-=-=-=-=-= Cliente Cadastrado Com Sucesso! -=-=-=-=-=");
                Console.WriteLine("===============================");
                break;

            case "3":
                Console.WriteLine("tudo no 03");
                break;
            case "4":
                Console.WriteLine("tudo no 04");
                break;
            case "5":
                Console.WriteLine("tudo no 05");
                break;
            case "6":
                validador = false;
                break;
        default:
            Console.WriteLine("Opção invalida tente novamente!!!");
            Console.WriteLine("===============================");
            break;
    }
    
}




Console.WriteLine("Data Da Compra");
var dataCompra = Console.ReadLine();
Console.WriteLine("Data Da Entregar");
var dataDaEntregar = Console.ReadLine();
Console.WriteLine("Orden De Comprar");
Console.WriteLine("===============================");

List<string>clientes= new List<string>();
clientes.AddRange(clientes);



