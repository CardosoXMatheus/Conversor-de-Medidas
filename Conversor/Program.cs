using System;
using System.Globalization;
using System.Threading; // Para usar na função 'voltar'
using ShellProgressBar; // package de barra de progressão para usar na função 'voltar'



namespace ProvaCilleneM2_matheus
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Conversor"; //TITULO


            //DEFINIR AS VARIAVEIS
            int Principal = 0, Terciario = 0;
            string Secundario = "a", continuar="s";
            double resultado = 0, Metro = 0, Centimetro = 0, Litro = 0, Mililitro = 0, Dolar = 0, Real = 0, Euro = 0, Quilo = 0, Grama = 0, cotacao = 0;
           

            Console.ForegroundColor = ConsoleColor.DarkBlue; //Mudar cor das letras
            

            Titulo();
            do
            {// COMECO DO MENU
                do{
                    Console.Clear();
                    Console.WriteLine("╔════════════════════════════════════╗");
                    Console.WriteLine("║            CONVERSORES             ║");
                    Console.WriteLine("╟────────────────────────────────────║");
                    Console.WriteLine("║    [1]     Conversor de Medidas    ║");
                    Console.WriteLine("╟────────────────────────────────────║");
                    Console.WriteLine("║    [2]     Conversor de Moedas     ║");
                    Console.WriteLine("╟────────────────────────────────────║");
                    Console.WriteLine("║    [3]     Conversor de Peso       ║");
                    Console.WriteLine("╟────────────────────────────────────║");
                    Console.WriteLine("║    [4]         Sair                ║");
                    Console.WriteLine("╚════════════════════════════════════╝");

                    Console.Write("Escolha uma opção de 1 a 4: ");
                    Teste1a3(ref  Principal);
                   
                }while (Principal < 1 || Principal > 5); //Tratar erro de colocar um valor diferennte

                Console.Clear();
                switch (Principal)
                {//CONVERSOR
                    case 1:
                        do
                        { //REPETIR O MENU MEDIDAS
                            Console.Clear();
                            Titulo();

                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║        CONVERSOR DE MEDIDAS        ║");
                            Console.WriteLine("╟────────────────────────────────────║");
                            Console.WriteLine("║    [A]       Métricas              ║");
                            Console.WriteLine("╟────────────────────────────────────║");
                            Console.WriteLine("║    [B]     Volumétricas            ║");
                            Console.WriteLine("╟────────────────────────────────────║");
                            Console.WriteLine("║    [C] Voltar ao Menu Principal    ║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.Write("Escolha uma opção de A, B ou C: ");

                            TesteAlfabeto(ref Secundario); //Entrada e Tratamento da variavel

                            switch (Secundario)
                            {//CONVERSOR DE MEDIDAS
                                case "A":
                                case "a":
                                    do
                                    { //REPETIR O MENU MÉTRICAS
                                        Console.Clear();
                                        Titulo(); //Função para mostrar o titulo conversor

                                        Console.WriteLine("╔════════════════════════════════════╗");
                                        Console.WriteLine("║              MÉTRICAS              ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║    [1]  Metro para Centímetro      ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║    [2]  Centímetro para Metro      ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║    [3] Voltar ao Menu Principal    ║");
                                        Console.WriteLine("╚════════════════════════════════════╝");
                                        Console.Write("Escolha uma opção de 1 a 3: ");

                                        Teste1a3(ref Terciario); //Entrada e Tratamento da variavel

                                        switch (Terciario)
                                        {//MÉTRICAS
                                            case 1:
                                                do
                                                {   
                                                    Console.Clear();
                                                    Console.WriteLine("╔═════════════════════════════════════╗");
                                                    Console.WriteLine("║        METRO PARA CENTÍMETRO        ║");
                                                    Console.WriteLine("╚═════════════════════════════════════╝");
                                                    Console.Write("\nDigite o valor em Metros para serem covertidos em Centimentros: ");
                                                    Teste_VariavelDiferente(ref Metro);//Entrada e Tratamento da variavel

                                                    resultado = Metro * 100;
                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    Console.Write($"\n{Metro} metros são {resultado} centimentros");
                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                                                    RepetirOperação(ref continuar);//Repetir quantas vezes quiser o case
                                                } while (continuar == "S" || continuar == "s");
                                                break;

                                            case 2:
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("╔═════════════════════════════════════╗");
                                                    Console.WriteLine("║        CENTÍMETRO PARA METRO        ║");
                                                    Console.WriteLine("╚═════════════════════════════════════╝");
                                                    Console.Write("\nDigite o valor em Centimentros para serem covertidos em Metros: ");
                                                    Teste_VariavelDiferente(ref Centimetro); //Entrada e Tratamento da variavel

                                                    resultado = Centimetro / 100;
                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    Console.Write($"\n{Centimetro} Centimentros são {resultado} Metros");
                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                                                    RepetirOperação(ref continuar);//Repetir quantas vezes quiser o case
                                                } while (continuar == "S" || continuar == "s");
                                                break;
                                        }
                                    }
                                    while (Terciario != 3);
                                    Voltar();
                                    break;

                                case "B":
                                case "b":
                                    do //REPETIR O MENU VOLUMÉTRICAS
                                    {
                                        Console.Clear();
                                        Titulo();

                                        Console.WriteLine("╔════════════════════════════════════╗");
                                        Console.WriteLine("║            VOLUMÉTRICAS            ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║    [1]  Litro para Mililitro       ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║    [2]  Mililitro para Litro       ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║    [3] Voltar ao Menu Principal    ║");
                                        Console.WriteLine("╚════════════════════════════════════╝");
                                        Console.Write("Escolha uma opção de 1 a 3: ");

                                        Teste1a3(ref Terciario); //Entrada e Tratamento da variavel

                                        switch (Terciario)
                                        {
                                            case 1: //REPETIR
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("╔═════════════════════════════════════╗");
                                                    Console.WriteLine("║         LITRO PARA MILILITRO        ║");
                                                    Console.WriteLine("╚═════════════════════════════════════╝");
                                                    Console.Write("\nDigite o valor em Litros para serem covertidos em Mililitros: ");
                                                    Teste_VariavelDiferente(ref Litro); //Entrada e Tratamento da variavel

                                                    resultado = Litro * 1000;
                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    Console.Write($"\n{Litro} Litros são {resultado} Mililitros");
                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                                                    RepetirOperação(ref continuar);//Repetir quantas vezes quiser o case
                                                } while (continuar == "S" || continuar == "s");
                                                break;


                                            case 2:
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("╔═════════════════════════════════════╗");
                                                    Console.WriteLine("║         MILILITRO PARA LITRO        ║");
                                                    Console.WriteLine("╚═════════════════════════════════════╝");
                                                    Console.Write("\nDigite o valor em Litros para serem covertidos em Mililitros: ");
                                                    Teste_VariavelDiferente(ref Mililitro); //Entrada e Tratamento da variavel

                                                    resultado = Mililitro / 1000;
                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    Console.Write($"\n{Mililitro} Mililitros são {resultado} Litros");
                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                                                    RepetirOperação(ref continuar);//Repetir quantas vezes quiser o case
                                                } while (continuar == "S" || continuar == "s");
                                                break;
                                        }
                                    } while (Terciario != 3);
                                    Console.Clear();
                                    Voltar();

                                    break;
                            }
                        } while (Secundario != "c" && Secundario != "C" && Terciario != 3);

                        Console.Clear();
                        Voltar();
                        break;

                    case 2:
                        do
                        { //REPETIR O MENU MOEDAS
                            Console.Clear();
                            Titulo(); 

                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║         CONVERSOR DE MOEDAS        ║");
                            Console.WriteLine("╟────────────────────────────────────║");
                            Console.WriteLine("║    [A]         Dólar               ║");
                            Console.WriteLine("╟────────────────────────────────────║");
                            Console.WriteLine("║    [B]         Euro                ║");
                            Console.WriteLine("╟────────────────────────────────────║");
                            Console.WriteLine("║    [C] Voltar ao Menu Principal    ║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.Write("Escolha uma opção de A, B ou C: ");

                            TesteAlfabeto(ref Secundario); //Entrada e Tratamento da variavel

                            switch (Secundario)  //CONVERSOR DE MOEDAS
                            {
                                case "A":
                                case "a":
                                    do //REPETIR O MENU DOLAR
                                    {
                                        Console.Clear();
                                        Titulo();

                                        Console.WriteLine("╔════════════════════════════════════╗");
                                        Console.WriteLine("║         CONVERSOR DE MOEDAS        ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║    [1]     Dólar para Real         ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║    [2]     Real para Dólar         ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║    [3] Voltar ao Menu Principal    ║");
                                        Console.WriteLine("╚════════════════════════════════════╝");
                                        Console.Write("Escolha uma opção de 1 a 3: ");

                                        Teste1a3(ref Terciario); //Entrada e Tratamento da variavel

                                        switch (Terciario)
                                        {
                                            case 1:
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("╔═════════════════════════════════════╗");
                                                    Console.WriteLine("║              DÓLAR PARA REAL        ║");
                                                    Console.WriteLine("╚═════════════════════════════════════╝");
                                                    Console.Write("\nDigite a cotação do dólar: ");
                                                    Teste_VariavelDiferente(ref cotacao);
                                                    Console.Write("\nDigite o valor em Dolares para serem covertidos em Reais: ");
                                                    Teste_VariavelDiferente(ref Dolar); //Entrada e Tratamento da variavel

                                                    resultado = Dolar * cotacao;
                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    Console.Write($"\nU${Dolar} Dolares são R${resultado} Reais");
                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                                                    RepetirOperação(ref continuar);//Repetir quantas vezes quiser o case
                                                } while (continuar == "S" || continuar == "s");
                                                break;


                                            case 2:
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("╔═════════════════════════════════════╗");
                                                    Console.WriteLine("║              REAL PARA DÓLAR        ║");
                                                    Console.WriteLine("╚═════════════════════════════════════╝");
                                                    Console.Write("\nDigite a cotação do dólar: ");
                                                    Teste_VariavelDiferente(ref cotacao);
                                                    Console.Write("\nDigite o valor em Reais para serem covertidos em Dolares: ");
                                                    Teste_VariavelDiferente(ref Real); //Entrada e Tratamento da variavel

                                                    resultado = Real / cotacao;
                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    Console.Write($"\nR${Real} Reais são U${resultado} Dolares");
                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                                                    RepetirOperação(ref continuar);//Repetir quantas vezes quiser o case
                                                } while (continuar == "S" || continuar == "s");
                                                break;
                                        }
                                    } while (Terciario != 3);
                                    Console.Clear();
                                    Voltar();
                                    break;

                                case "B":
                                case "b":
                                    do //REPETIR O MENU EURO
                                    {
                                        Console.Clear();
                                        Titulo();

                                        Console.WriteLine("╔════════════════════════════════════╗");
                                        Console.WriteLine("║                EURO                ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║    [1]     Euro para Real          ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║    [2]     Real para Euro          ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║    [3] Voltar ao Menu Principal    ║");
                                        Console.WriteLine("╚════════════════════════════════════╝");
                                        Console.Write("OpçãoEscolha uma opção de 1 a 3: ");

                                        Teste1a3(ref Terciario); //Entrada e Tratamento da variavel

                                        switch (Terciario)
                                        {
                                            case 1:
                                                do
                                                {   
                                                    Console.Clear();
                                                    Console.WriteLine("╔═════════════════════════════════════╗");
                                                    Console.WriteLine("║              EURO PARA REAL         ║");
                                                    Console.WriteLine("╚═════════════════════════════════════╝");
                                                    Console.Write("\nDigite a cotação do Euro: ");
                                                    Teste_VariavelDiferente(ref cotacao);
                                                    Console.Write("\nDigite o valor em Euro para serem covertidos em Reais: ");
                                                    Teste_VariavelDiferente(ref Euro); //Entrada e Tratamento da variavel

                                                    resultado = Euro * cotacao;
                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    Console.Write($"\nЄ&{Euro} Euros são R${resultado} Reais");
                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                                                    RepetirOperação(ref continuar);//Repetir quantas vezes quiser o case
                                                } while (continuar == "S" || continuar == "s");
                                                break;


                                            case 2:
                                                do
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("╔═════════════════════════════════════╗");
                                                    Console.WriteLine("║              REAL PARA EURO         ║");
                                                    Console.WriteLine("╚═════════════════════════════════════╝");
                                                    Console.Write("\nDigite a cotação do Euro: ");
                                                    Teste_VariavelDiferente(ref cotacao);
                                                    Console.Write("\nDigite o valor em Reais para serem covertidos em Euro: ");
                                                    Teste_VariavelDiferente(ref Real); //Entrada e Tratamento da variavel

                                                    resultado = Real / cotacao;
                                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                    Console.Write($"\nR${Real} Reais são Є${resultado} Euros");
                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                                                    RepetirOperação(ref continuar);//Repetir quantas vezes quiser o case
                                                } while (continuar == "S" || continuar == "s");
                                                break;
                                        }
                                    } while (Terciario != 3);

                                    Console.Clear();
                                    Voltar();
                                    break;
                            }
                        } while (Secundario != "c" && Secundario != "C" && Terciario != 3);

                        Console.Clear();
                        Voltar();
                        break;

                    case 3:
                        do
                        { //REPETIR O MENU PESO
                            Console.Clear();
                            Titulo();

                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║         CONVERSOR DE PESO          ║");
                            Console.WriteLine("╟────────────────────────────────────║");
                            Console.WriteLine("║    [1]     Quilo para Grama        ║");
                            Console.WriteLine("╟────────────────────────────────────║");
                            Console.WriteLine("║    [2]     Grama para Quilo        ║");
                            Console.WriteLine("╟────────────────────────────────────║");
                            Console.WriteLine("║    [3] Voltar ao Menu Principal    ║");
                            Console.WriteLine("╚════════════════════════════════════╝");
                            Console.Write("Escolha uma opção de 1 a 3:  "); //Entrada e Tratamento da variavel

                            Teste1a3(ref Terciario);

                            switch (Terciario)  //CONVERSOR DE PESO
                            {
                                case 1:
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("╔═════════════════════════════════════╗");
                                        Console.WriteLine("║              QUILO PARA GRAMA       ║");
                                        Console.WriteLine("╚═════════════════════════════════════╝");
                                        Console.Write("Digite o valor em Quilos para serem covertidos em Gramas: ");
                                        Teste_VariavelDiferente(ref Quilo); //Entrada e Tratamento da variavel

                                        resultado = Quilo * 1000;
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.Write($"{Quilo} Quilos são {resultado} Gramas");
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                                        RepetirOperação(ref continuar);//Repetir quantas vezes quiser o case
                                    } while (continuar == "S" || continuar == "s");
                                    break;

                                case 2:
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("╔═════════════════════════════════════╗");
                                        Console.WriteLine("║              GRAMA PARA QUILO       ║");
                                        Console.WriteLine("╚═════════════════════════════════════╝");
                                        Console.Write("Digite o valor em Gramas para serem covertidos em Quilos: ");
                                        Teste_VariavelDiferente(ref Grama); //Entrada e Tratamento da variavel

                                        resultado = Grama / 1000;
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.Write($"{Grama} Gramas são {resultado} Quilos");
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                                        RepetirOperação(ref continuar);//Repetir quantas vezes quiser o case
                                    } while (continuar == "S" || continuar == "s");
                                    break;
                            }
                        } while (Terciario != 3);

                        Console.Clear();
                        Voltar();
                        break;

                    case 4: // SAIR DO PROGRAMA
                        Console.Clear();
                        MensagemFinal(); //Mensagem de Tchau
                        Console.ReadKey();
                        break;
                }
            }
            while (Principal != 4);
        }

        //*********** REGIÃO DAS FUNÇÕES **************//
        static int Teste1a3(ref int Terciario) //TRATAMENTO MENU TERCIARIO
        {
            
                try//Impedir que quebre o codigo
                {
                    Terciario = int.Parse(Console.ReadLine());
                }
                catch (Exception )//Mensagem de captura de erro
                {
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                    Console.Write("\n\nInsira um valor Valido: ");
                    Teste1a3(ref Terciario);
                    Console.Clear();
                    
                }
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            return Terciario;
        }

        static string TesteAlfabeto(ref string Secundario) //TRATAMENTO MENU SECUNDARIO
        {
            
            try//Impedir que quebre o codigo
            {
                Secundario = Console.ReadLine();
            }
            catch (Exception ) //Mensagem de captura de erro
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.Write("\n\nInsira um valor Valido de A, B ou C: ");
                TesteAlfabeto(ref  Secundario);
                Console.Clear();
            }
            
            //Restrigir o usario a colocar apenas a variavel certa
            while (Secundario != "a" && Secundario != "A" && Secundario != "b" && Secundario != "B" && Secundario != "c" && Secundario != "C")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nValor Invalido tente Novamente um valor de A, B ou C: ");
                Secundario = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            return Secundario;
        }

        static double Teste_VariavelDiferente(ref double numero) //TRATAMENTO PARA VALOR MENOR OU IGUAL A ZERO
        {
            try //Impedir que quebre o codigo
            {
                numero = Double.Parse(Console.ReadLine());
            }
            catch (Exception )//Mensagem de captura de erro
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.Write("\n\nInsira um valor Valido: ");
                Teste_VariavelDiferente(ref  numero);
                Console.Clear();
            }

            //Restrigir o usario a colocar apenas a variavel certa
            while (numero <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nERRO! valor Negativo ou igual a zero. Tente um número positivo: ");
                numero = Double.Parse(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            return numero;
        }


        static void Voltar() // MENSAGEM DE VOLTAR
        {
            Console.Clear();
            const int totalTicks = 10; 
            var Progresso = new ProgressBarOptions //CRIANDO E CARACTERIZANDO A BARRA DE VOLTAR
            {
                ProgressCharacter = '─',
                ProgressBarOnBottom = true,

                ForegroundColor = ConsoleColor.Yellow,
	            ForegroundColorDone = ConsoleColor.DarkGreen,
	            BackgroundColor = ConsoleColor.DarkGray,
	            BackgroundCharacter = '\u2593'
            };

            using (var pbar = new ProgressBar(totalTicks, "Voltando", Progresso)) //APLICANDO A BARRA
            {
                IProgress<double> progress = pbar.AsProgress<double>();

                pbar.Tick("carregando"); //Mensagem em cima da barra
                Thread.Sleep(1000); // espera para dar a impressao de carregamento
                progress.Report(0.25);// atualização para 25%
                Thread.Sleep(1000);
                progress.Report(0.50);// atualização para 50%
                Thread.Sleep(1000);
                progress.Report(0.75);// atualização para 75%
                Thread.Sleep(1000);
                progress.Report(1);// atualização para 100%
                
                
            }
            Console.Clear();
            Titulo();
        }

        static string RepetirOperação(ref string continuar) //REPETIR A OPERAÇÃO QUANTAS VEZES QUISER
        {
            Console.WriteLine("\n\n'S' - Inserir outro valor\n'Qualquer tecla' - Menu Anterior");
            continuar = Console.ReadLine();
            Console.Clear();

            return continuar;
        }

        static void Titulo() //Titulo Principal
        {
            Console.WriteLine("     ╔═══╦═══╦═╗ ╔╦╗  ╔╦═══╦═══╦═══╦═══╦═══╗");
            Console.WriteLine("     ║╔═╗║╔═╗║║╚╗║║╚╗╔╝║╔══╣╔═╗║╔═╗║╔═╗║╔═╗║");
            Console.WriteLine("     ║║ ╚╣║ ║║╔╗╚╝╠╗║║╔╣╚══╣╚═╝║╚══╣║ ║║╚═╝║");
            Console.WriteLine("     ║║ ╔╣║ ║║║╚╗║║║╚╝║║╔══╣╔╗╔╩══╗║║ ║║╔╗╔╝");
            Console.WriteLine("     ║╚═╝║╚═╝║║ ║║║╚╗╔╝║╚══╣║║╚╣╚═╝║╚═╝║║║╚╗");
            Console.WriteLine("     ╚═══╩═══╩╝ ╚═╝ ╚╝ ╚═══╩╝╚═╩═══╩═══╩╝╚═╝ ");
        }

        static void MensagemFinal() //Mensagem ao finalizar o programa
        {
           Console.WriteLine("╔════════════════════════════════════════════╗");
           Console.WriteLine("║      OBRIGADO POR USAR NOSSO CONVERSOR!    ║");
           Console.WriteLine("║        APERTE QUALQUER TECLA PARA SAIR.    ║");
           Console.WriteLine("╚════════════════════════════════════════════╝\n"); 

            Console.WriteLine("         ┌────┐┌───┐┌┐ ┌┐┌───┐┌┐ ┌┐   ▐▓█▀▀▀▀▀▀▀▀▀█▓▌░▄▄▄▄▄░");
            Console.WriteLine("         │┌┐┌┐││┌─┐│││ │││┌─┐│││ ││   ▐▓█░░▀░░▀▄░░█▓▌░█▄▄▄█░");
            Console.WriteLine("         └┘││└┘││ └┘│└─┘│││ ││││ ││   ▐▓█░░▄░░▄▀░░█▓▌░█▄▄▄█░");
            Console.WriteLine("           ││  ││ ┌┐│┌─┐││└─┘│││ ││   ▐▓█▄▄▄▄▄▄▄▄▄█▓▌░█████░");
            Console.WriteLine("           ││  │└─┘│││ │││┌─┐││└─┘│    ░░░▄▄███▄▄░░░░░█████░");
            Console.WriteLine("           └┘  └───┘└┘ └┘└┘ └┘└───┘");

        }

        
    }
}





