
using System;
class GeradorMatrizIdentidade {
  static void Main() {
      
      int ordem;
      int[,] m;//o número de linhas/colunas pode ser declarado depois.
      
      //pedindo o número de linhas/colunas ao usuário
      Console.WriteLine("Numa matriz identidade, número de linhas = número de colunas.");
      Console.WriteLine("Digite a ordem da matriz (número de linhas/colunas).");
      ordem=int.Parse(Console.ReadLine());
      
      m= new int[ordem,ordem];//indicando o número de linhas/colunas ao programa.
      
      //criando a matriz identidade.
      for (int i=0; i<ordem; i++)
      {
          m[i,i]=1;
      }
    
    //imprimindo a matriz identidade.  
    Console.WriteLine("Matriz identidade de ordem "+ordem);
        for (int i = 0; i < ordem; i++)
        {
            for (int j = 0; j < ordem; j++)
            {
                Console.Write("\t{0}", m[i, j]);
            }
            Console.WriteLine();
        }

  }
}
