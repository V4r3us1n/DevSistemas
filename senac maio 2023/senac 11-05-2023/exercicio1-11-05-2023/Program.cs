using System;

namespace exercicio1_11_05_2023
{
    class Program
    {
        static Animal[] animais = new Animal[0];
        static AnimalCachorro[] cachorros = new AnimalCachorro[0];

        static AnimalGato[] gatos = new AnimalGato[0];

        static AnimalVaca[] vacas = new AnimalVaca[0];

        static AnimalCavalo[] cavalos = new AnimalCavalo[0];
        static void Main(string[] args)
        {
            int continuarLoop = 0, opcao = 0, categoria;
            string nomeAnimal, nomeDono, categoriaNome;
            
            do {
            
            opcao = Menu();
            
            switch (opcao)
            {
                case 1:
                    //ADICIONAR ANIMAL
                    Console.WriteLine("[AVISO!] CADASTRANDO NOVO ANIMAL");
                    Console.WriteLine("");
                    Console.Write("Digite o Nome do Animal: ");
                    nomeAnimal = Console.ReadLine();
                    Console.Write("Digite o Nome do Dono do Animal: ");
                    nomeDono = Console.ReadLine();
                    do {
                        Console.WriteLine("[1] Cachorro, [2] Gato, [3] Vaca, [4] Cavalo");
                        Console.Write("Digite a Categoria do Animal (de 1 a 4): ");
                        categoria = Int32.Parse(Console.ReadLine());
                        
                        if (categoria < 1 || categoria > 4)
                        {
                            Console.WriteLine("[ERRO!] ESCOLHA UMA CATEGORIA VÁLIDA (ENTRE 1 E 4)!");
                        }
                        
                    } while (categoria < 1 || categoria > 4);
                    
                    Animal animal = new Animal(nomeAnimal, nomeDono);
                    animal.NomearCategoria(categoria);
                    
                    AumentarArrayAnimais();
                    
                    animais[animais.Length-1] = animal;

                    switch (categoria)
                    {
                        case 1:
                            //CADASTRANDO CACHORRO
                            categoriaNome = "Cachorro";
                            AnimalCachorro cachorro = new AnimalCachorro(nomeAnimal, nomeDono);
                            cachorro.AdicionarCategoria(categoriaNome);
                            AumentarArrayCachorros();
                            cachorros[cachorros.Length-1] = cachorro;

                            break;
                        case 2:
                            //CADASTRANDO GATO
                            categoriaNome = "Gato";
                            AnimalGato gato = new AnimalGato(nomeAnimal, nomeDono);
                            gato.AdicionarCategoria(categoriaNome);
                            AumentarArrayGatos();
                            gatos[gatos.Length-1] = gato;

                            break;
                        case 3:
                            //CADASTRANDO VACA
                            categoriaNome = "Vaca";
                            AnimalVaca vaca = new AnimalVaca(nomeAnimal, nomeDono);
                            vaca.AdicionarCategoria(categoriaNome);
                            AumentarArrayVacas();
                            vacas[vacas.Length-1] = vaca;

                            break;
                        case 4:
                            //CADASTRANDO CAVALO
                            categoriaNome = "Cavalo";
                            AnimalCavalo cavalo = new AnimalCavalo(nomeAnimal, nomeDono);
                            cavalo.AdicionarCategoria(categoriaNome);
                            AumentarArrayCavalos();
                            cavalos[cavalos.Length-1] = cavalo;

                            break;
                        default:
                            Console.WriteLine("[ERRO!] NÃO EXISTE ESSA CATEGORIA!");
                            break;
                    }
                    
                    break;
                case 2:
                    //EXIBIR ANIMAIS CADASTRADOS
                    Console.WriteLine("Quais Animais você deseja ver?");
                    Console.WriteLine("[1] Cachorro, [2] Gato, [3] Vaca, [4] Cavalo, [5] Todos");

                    int opcaoExibirAnimais = Int32.Parse(Console.ReadLine());

                    switch (opcaoExibirAnimais)
                    {
                        case 1:
                            //EXIBINDO TODOS OS CACHORROS CADASTRADOS
                            Console.WriteLine("[AVISO!] EXIBINDO TODOS OS CACHORROS CADASTRADOS!");
                    
                            for (int i = 0; i < cachorros.Length; i++)
                            {	
                                Console.WriteLine("");
                                Console.WriteLine($"Nome: {cachorros[i].Nome}");
                                Console.WriteLine($"Dono: {cachorros[i].Dono}");
                                Console.WriteLine($"Categoria: {cachorros[i].CategoriaNome}");
                                Console.WriteLine("");
                            }

                            break;
                        case 2:
                            //EXIBINDO TODOS OS GATOS CADASTRADOS
                            Console.WriteLine("[AVISO!] EXIBINDO TODOS OS GATOS CADASTRADOS!");
                    
                            for (int i = 0; i < gatos.Length; i++)
                            {	
                                Console.WriteLine("");
                                Console.WriteLine($"Nome: {gatos[i].Nome}");
                                Console.WriteLine($"Dono: {gatos[i].Dono}");
                                Console.WriteLine($"Categoria: {gatos[i].CategoriaNome}");
                                Console.WriteLine("");
                            }

                            break;
                        case 3:
                            //EXIBINDO TODAS AS VACAS CADASTRADAS
                            Console.WriteLine("[AVISO!] EXIBINDO TODOS AS VACAS CADASTRADOS!");
                    
                            for (int i = 0; i < vacas.Length; i++)
                            {	
                                Console.WriteLine("");
                                Console.WriteLine($"Nome: {vacas[i].Nome}");
                                Console.WriteLine($"Dono: {vacas[i].Dono}");
                                Console.WriteLine($"Categoria: {vacas[i].CategoriaNome}");
                                Console.WriteLine("");
                            }

                            break;
                        case 4:
                            //EXIBINDO TODOS OS CAVALOS CADASTRADOS
                            Console.WriteLine("[AVISO!] EXIBINDO TODOS OS CAVALOS CADASTRADOS!");
                    
                            for (int i = 0; i < cavalos.Length; i++)
                            {	
                                Console.WriteLine("");
                                Console.WriteLine($"Nome: {cavalos[i].Nome}");
                                Console.WriteLine($"Dono: {cavalos[i].Dono}");
                                Console.WriteLine($"Categoria: {cavalos[i].CategoriaNome}");
                                Console.WriteLine("");
                            }

                            break;
                        case 5:
                        //EXIBINDO TODOS OS ANIMAIS CADASTRADOS
                            Console.WriteLine("[AVISO!] EXIBINDO TODOS OS ANIMAIS CADASTRADOS!");
                    
                            for (int i = 0; i < animais.Length; i++)
                            {	
                                Console.WriteLine("");
                                Console.WriteLine($"Nome: {animais[i].Nome}");
                                Console.WriteLine($"Dono: {animais[i].Dono}");
                                Console.WriteLine($"Categoria: {animais[i].CategoriaNome}");
                                Console.WriteLine("");
                            }

                            break;
                        default:
                            //OPÇÃO INVÁLIDA
                            Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");

                            break;
                    }
                
                    break;
                case 3:
                    //SAIR DO MENU
                    Console.WriteLine("[AVISO!] Saindo do Menu...");
                    Console.WriteLine("");
                    continuarLoop++;
                
                    break;
                default:
                    //OPÇÃO INVÁLIDA
                    Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                    Console.WriteLine("");
                
                    break;
            }
            
            } while (continuarLoop == 0);
        }
        
        static int Menu()
        {
            Console.WriteLine("========== CADASTRO ANIMAIS ==========");
            Console.WriteLine("[1] Cadastrar Animal");
            Console.WriteLine("[2] Exibir Animais Cadastrados");
            Console.WriteLine("[3] Sair");
            Console.WriteLine("======================================");
            Console.WriteLine("");
            Console.Write("Digite a Opção Desejada: ");
            int opcao = Int32.Parse(Console.ReadLine());
            return opcao;
        }
        
        static void AumentarArrayAnimais()
        {
            Animal[] animaisTemp = new Animal[animais.Length + 1];
            
            for (int i = 0; i < animais.Length; i++)
            {
                animaisTemp[i] = animais[i];
            }
            
            animais = animaisTemp;
        }

        static void AumentarArrayCachorros()
        {
            AnimalCachorro[] cachorrosTemp = new AnimalCachorro[cachorros.Length + 1];

            for (int i = 0; i < cachorros.Length; i++)
            {
                cachorrosTemp[i] = cachorros[i];
            }
            
            cachorros = cachorrosTemp;
        }

        static void AumentarArrayGatos()
        {
            AnimalGato[] gatosTemp = new AnimalGato[gatos.Length + 1];
            
            for (int i = 0; i < gatos.Length; i++)
            {
                gatosTemp[i] = gatos[i];
            }
            
            gatos = gatosTemp;
        }

        static void AumentarArrayVacas()
        {
            AnimalVaca[] vacasTemp = new AnimalVaca[vacas.Length + 1];
            
            for (int i = 0; i < vacas.Length; i++)
            {
                vacasTemp[i] = vacas[i];
            }
            
            vacas = vacasTemp;
        }

        static void AumentarArrayCavalos()
        {
            AnimalCavalo[] cavalosTemp = new AnimalCavalo[cavalos.Length + 1];
            
            for (int i = 0; i < cavalos.Length; i++)
            {
                cavalosTemp[i] = cavalos[i];
            }
            
            cavalos = cavalosTemp;
        }
    }
}
