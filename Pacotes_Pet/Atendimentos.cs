void GerenciarPacotes(Dictionary<string, int> pacotes, string[] atendimentos)
{
    string maiorAtendimento = "", pet;
    int somaServicos = 0, maior = 0, novoValor;

    Dictionary<string, int> dicAtendimento = new();

    for (int i = 0; i < atendimentos.Length; i++)
    {
        pet = atendimentos[i];

        if (pacotes[pet] >= 1)
        {
            novoValor = pacotes[pet] - 1;
            pacotes[pet] = novoValor;

            if (novoValor == 0)
            {
                Console.WriteLine($"{pet} → atendimento realizado → {novoValor} serviços restantes → PACOTE ESGOTADO");
            }
            else
            {
                Console.WriteLine($"{pet} → atendimento realizado → {novoValor} serviços restantes");
            }

            if (!dicAtendimento.ContainsKey(pet))
            { 
                dicAtendimento.Add(pet, 1);
            }
            else
            {
                dicAtendimento[pet] += 1;
            }
        }
        else
        {
            Console.WriteLine($"{pet} → atendimento recusado → pacote esgotado");
        }
    }

    Console.WriteLine();
    Console.WriteLine("====RESUMO=====");
    
    foreach (string key in dicAtendimento.Keys)
    {
        somaServicos += dicAtendimento[key];

        if (maior < dicAtendimento[key])
        {
            maior = dicAtendimento[key];
            maiorAtendimento = $"Maior consumo: {key} → {maior} serviços";
        }
    }

    Console.WriteLine(maiorAtendimento);
    Console.WriteLine($"TOTAL DE SERVIÇOS REALIZADOS = {somaServicos}");
    return;
}

Dictionary<string, int> dicPacotes = new()
{
    {"Thor", 3},
    {"Mel", 1},
    {"Rex", 0},
    {"Luna", 5},
    {"Bob", 2}
};

string[] atendimentos =
{
    "Thor",
    "Rex",
    "Thor",
    "Mel",
    "Thor",
    "Bob",
    "Rex",
    "Luna",
    "Mel"
};

void Main()
{
    GerenciarPacotes(dicPacotes, atendimentos);
}

Main();
