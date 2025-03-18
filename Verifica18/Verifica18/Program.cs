
int [,] vm = new int [2, 12];
Random random = new Random();
string scritta = "NELMEZZODICAMMINDINOSTRAVITA";

void generaMatrice(int[,] vm)
{
    for (int i = 0; i < vm.GetLength(0); i++)
    {
        for (int j = 0; j < vm.GetLength(1); j++)
        {
            if (i == 0)
            {
                vm[i, j] = random.Next(100, 1001);
            }else
            {
                vm[i, j] = 0;
            }
            Console.Write("["+vm[i, j]+"]");
        }
        Console.WriteLine();
    }
    
}
generaMatrice (vm);

void cumulativi(int[,] vm )
{
    int tot=0;
    for (int i = 0; i < vm.GetLength(0); i++)
    {
        for (int j = 0; j < vm.GetLength(1); j++)
        {
            if (i == 1)
            {
                tot = tot + vm[i - 1, j];
                vm[i, j] = tot;
            }
            Console.Write("[" + vm[i, j] + "]");
        }
       
        Console.WriteLine();
    }

}
cumulativi(vm);

int trovaMese(int[,] vm)
{
    int cifra;
    int tot = 0;
    Console.WriteLine("che cifra vuoi controllare quando è stata raggiunta?");
    cifra = Int32.Parse(Console.ReadLine());
    for (int i = 0; i < vm.GetLength(0); i++)
    {
        for (int j = 0; j < vm.GetLength(1); j++)
        {
            if (i == 1)
            {
                tot = tot + vm[i - 1, j];
                vm[i, j] = tot;
                if (vm[i, j] >= cifra)
                {
                    return j+1;
                    
                }         
            }
        }
    }
    return 0;
}
Console.WriteLine(trovaMese(vm));
void genera(string scritta)
{
    int p=0;
     string risultato ="";
    for (int i = 0; i < scritta.Length; i++)
    {
        for (int j = 0; j < scritta.Length; j++)
        {
            if (i != j)
            {
                if (scritta[i] != scritta[j])
                {
                    if (p == 0)
                    {
                        p =0;
                    }
                }
                else
                {
                    p = 1;
                }
            }
        }
        if (p == 1)
        {
            risultato += '/';
        }
    }
    for (int i = 0; i < scritta.Length; i++)
    {
        if (scritta[i]!='/') 
        {
            Console.WriteLine(scritta[i]);
        }
        

    }
    
}

bool verifica(string numeri)
{
    
    int p = 0;
    for (int i = 0; i < scritta.Length; i++)
    {
        for (int j = 0; j < scritta.Length; j++)
        {
            if (i != j)
            {
                if (scritta[i] != scritta[j])
                {
                    if (p == 0)
                    {
                        p = 0;
                    }
                }
                else
                {
                    p = 1;
                }
            }
        }
    }
    if (p == 1)
    {
        return false;
    }
    else 
    { 
        return true;
    }
}
genera(scritta);
Console.WriteLine(verifica("123456789"));