using System;
class IdentificadorMatrizIdentidade {
  static void Main() {
      
    int linhas, colunas, reprovador=0;
    //Se a matriz falhar algum teste, reprovador muda para 1. Senão continua 0 até o fim.
    
    double[,] m;//o número de linhas/colunas pode ser declarado depois.
    
    //entrada do número de linhas/colunas.  
    Console.WriteLine("Digite o número de linhas.");
    linhas=int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o número de colunas.");
    colunas=int.Parse(Console.ReadLine());
    
    //teste 1: a matriz deve ser quadrada.  
    if (linhas!=colunas)
    {
    reprovador=1;
    Console.WriteLine("Número de linhas é diferente do número de colunas. Logo, sua matriz não é identidade.");
    }
    else
    {
          //declarando o número de linhas/colunas.
          m=new double[linhas,colunas];
          
          //entrada dos elementos da matriz.
          for (int i=0;i<linhas;i++)
          {
              for (int j=0;j<colunas;j++)
              {
                  Console.WriteLine("Digite o elemento da linha {0} coluna {1}.",i+1,j+1);
                  m[i,j]=double.Parse(Console.ReadLine());
              }
          }
        
        //impressão da matriz  
        Console.WriteLine("Matriz informada:");
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write("\t{0}", m[i, j]);
            }
            Console.WriteLine();
        }
        
        //teste 2: os elementos da diagonal devem ser iguais a 1.
        for (int i=0;i<linhas;i++)
        {
            if (m[i,i]!=1) 
            {
                Console.WriteLine("Sua matriz não é identidade.");
                reprovador=1;//Se falhar o teste, reprovador muda para 1. Senão continua 0.
                break;
            }
        }    
        
        //Se reprovador=1, o resto do programa é ignorado. Senão ele entra no próximo teste
        
        //Teste 3: os outros elementos devem ser 0.
        if (reprovador==0)
        {
            for (int i=0;i<linhas;i++)
            {    
                if (reprovador==1)
                break; //esse if impede que o programa diga que não é identidade várias vezes.
                
                for (int j = 0; j < colunas; j++)
                {
                    if (i==j)
                    continue;//os elementos da diagonal principal (=1) são ignorados
                    
                    if (m[i,j]!=0)
                    {
                        Console.WriteLine("Sua matriz não é identidade.");
                        reprovador=1;//Se falhar o teste, reprovador muda para 1. Senão continua 0.
                        break;
                    }
                }
            }
        }
        
        //passando em todos os testes, imprime que é identidade.
        if (reprovador==0)
            Console.WriteLine("Sua matriz é uma matriz identidade.");
      
    }  
}}
