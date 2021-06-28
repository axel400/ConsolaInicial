using System;

namespace TareaDeArboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo()
            {

                Valor = "/",
                nivel=0,
                Hijos ={
                    new Nodo{
                        Valor="*",
                        Hijos={
                            new Nodo{
                                Valor="8"
                            },
                            new Nodo{
                                Valor ="9"
                            }
                        }
                    },
                    new Nodo{
                        Valor ="-",
                        Hijos={
                            new Nodo{
                                Valor="87"
                            },
                            new Nodo{
                                Valor="46"
                            }
                        }
                    },
                    new Nodo{
                        Valor="+",
                        Hijos={
                            new Nodo{
                                Valor="7"
                            },
                            new Nodo{
                                Valor="10"
                            }
                           
                        }
                    }
                    


                },
            };

            ControladorArbol controladorArbol = new ControladorArbol();
            Console.WriteLine($"el numero de hojas del arbol es de : {controladorArbol.ContarHojas(raiz)}");
            Console.WriteLine($"el numero de niveles del arbol es de : {controladorArbol.ContarNiveles(raiz)}");
            Console.WriteLine($"el numero de nodos del arbol es de : {controladorArbol.ContarNodos(raiz)}");


        }
    }
}