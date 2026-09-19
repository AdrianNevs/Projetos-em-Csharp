Dictionary<string, int> List_person = new Dictionary<string, int> {{ "admin", 0 }};

void Menu(int opc)
{
    int sequencia = 0;
    while(opc != 3)
    {
        sequencia++;
        
        Console.WriteLine("=================================");
        Console.WriteLine("        SISTEMA DE FILAS         ");
        Console.WriteLine("=================================");
        Console.WriteLine("[ 1 ] Entrar na Fila Comum");
        Console.WriteLine("[ 2 ] Entrar na Fila Preferencial");
        Console.WriteLine("[ 3 ] Sair do Programa");
        Console.WriteLine("=================================");
        Console.Write("Escolha uma opção: ");
        opc = Convert.ToInt32(Console.ReadLine());
        
        if (opc == 1)
        {
            adicionar(true,sequencia); // verdadeiro é comum
        }
        if (opc == 2)
        {
            adicionar(false,sequencia);
        }
    }


}

void adicionar(bool prioridade,int sequencia)
{


    if (prioridade)
    {
        Console.WriteLine("Senha comum:");
        Console.WriteLine($"sua senha é 00{sequencia}");
        List_person.Add(Convert.ToString(sequencia),0);

    }
    if (!prioridade)
    {
        Console.WriteLine("Senha preferencial:");
        Console.WriteLine($"sua senha é 00{sequencia}");
        List_person.Add(Convert.ToString(sequencia),1);
    }


}

void Fila_ordem(Dictionary<string, int> List_person)
{
    int i = 0;
    int opc = 0;

    while (List_person.Count != 0)
    {
        if (List_person.ElementAt(i).Value == 1 && List_person.Count(x => x.Value == 1) > 0)
        {
            Console.WriteLine($"senha = {List_person.ElementAt(i).Key}");
            List_person.Remove(List_person.ElementAt(i).Key);
            i--;

        }
        if (!(List_person.Count(x => x.Value == 1) > 0) || i < 0)
        {
            i = 0;

        }

        if (List_person.ElementAt(i).Value == 0 && !(List_person.Count(x => x.Value == 1) > 0))
        {
            Console.WriteLine($"senha = {List_person.ElementAt(i).Key}");
            List_person.Remove(List_person.ElementAt(i).Key);
            i--;
        }
        
        if (List_person.Count > 0)
        {
            i++;
        }
        else // depois de tirar todas as senhas ele entra para adicionar mais pessoas a fila
        {
            Menu(opc);
            i = 0;
        }
    }

}
Fila_ordem(List_person);
