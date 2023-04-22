using System;

namespace exercicios30_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {

            int contadorDia, contadorHora, contadorMinuto, contadorSegundo;
            //Imprimindo Semanas até a semana 52

            for (int contadorSemana = 1; contadorSemana <= 52; contadorSemana++) {
                Console.WriteLine($"Semana {contadorSemana}:");
                //Imprimindo dias da semana até 7
                contadorDia = 1;

                while (contadorDia <= 7) {
                    Console.WriteLine($"Dia {contadorDia}:");
                    contadorHora = 0;

                    //Imprimindo Horas do Dia
                    while (contadorHora <= 23) {
                        //Imprimindo Minutos da Hora
                        contadorMinuto = 0;

                        while (contadorMinuto <= 59) {
                            //Imprimindo Segundos do Minuto
                            contadorSegundo = 0;

                            while (contadorSegundo <= 59) {
                                //Imprimindo Horário

                                if (contadorHora < 10)
                                {
                                    if (contadorMinuto < 10)
                                    {
                                        if (contadorSegundo < 10)
                                        {
                                            Console.WriteLine($"0{contadorHora}:0{contadorMinuto}:0{contadorSegundo}");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"0{contadorHora}:0{contadorMinuto}:{contadorSegundo}");
                                        }
                                    }
                                    else if (contadorSegundo < 10)
                                    {
                                        Console.WriteLine($"0{contadorHora}:{contadorMinuto}:0{contadorSegundo}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"0{contadorHora}:{contadorMinuto}:{contadorSegundo}");
                                    }
                                }
                                else if (contadorMinuto < 10)
                                {
                                    if (contadorSegundo < 10)
                                    {
                                        Console.WriteLine($"{contadorHora}:0{contadorMinuto}:0{contadorSegundo}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{contadorHora}:0{contadorMinuto}:{contadorSegundo}");
                                    }
                                }
                                else if (contadorSegundo < 10)
                                {
                                    Console.WriteLine($"{contadorHora}:{contadorMinuto}:0{contadorSegundo}");
                                }
                                else
                                {
                                    Console.WriteLine($"{contadorHora}:{contadorMinuto}:{contadorSegundo}");
                                }

                                contadorSegundo++;                                
                            }

                            contadorMinuto++;
                        }

                        contadorHora++;
                    }

                    contadorDia++;
                }
            }
        }
    }
}
