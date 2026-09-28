bool Verificar_Pacote(string nome,string servicos,Dictionary<string,int> pacotes_pet,Dictionary<string,double> relatorio){

    if (pacotes_pet.ContainsKey(nome)) // verificar se o pet esta no pacote
    {
        if (pacotes_pet[nome] >= 1 && servicos == "Banho") // verificar serviços disponiveis o pacote cobre apenas banho
        {

            pacotes_pet[nome]--;

            if (pacotes_pet[nome] == 0)
            {
                Console.WriteLine($"{nome} → atendimento realizado → {servicos} serviços restantes → 0 → PACOTE ESGOTADO");
            }
            else
            {
                Console.WriteLine($"{nome} → Banho → PACOTE CONSUMIDO → {pacotes_pet[nome]} serviço restante");
            }
            relatorio["Atendimentos Realizados"]++;
            relatorio["Serviços consumidos do pacote"]++;
            return true;
        }
    }
    return false;
}


Dictionary<string,double> SistemaCaixa(string[] atendimentos,Dictionary<string, int> pacotes_pet, Dictionary<string,double> servicos_dic,Dictionary<string,double> desconto){
    Dictionary<string,double> relatorio = new() {{"Atendimentos Realizados",0},{"atendimentos Recusados",0},{"Serviços pagos",0},{"Serviços consumidos do pacote",0},{"valor recebido R$",0}};
    string[] separar;
    string servicos,nome;
    double somaServicos = 0 , desconto_pet = 0;

    foreach (string pet_Servicos in atendimentos)
    {
        separar = pet_Servicos.Split(':');
        nome = separar[0];
        servicos = separar[1];
        if (servicos_dic.ContainsKey(servicos))
        {
            if (!Verificar_Pacote(nome,servicos,pacotes_pet,relatorio)){
                
                if (desconto.ContainsKey(nome))
                {
                    desconto_pet = servicos_dic[servicos] - (servicos_dic[servicos] * (desconto[nome] / 100));
                    Console.WriteLine($"{nome} → {servicos} → {desconto_pet} → desconto → {desconto[nome]}% ");
                    somaServicos += desconto_pet;  
                }
                else
                {
                    Console.WriteLine($"{nome} → {servicos} → {servicos_dic[servicos]} ");
                    somaServicos += servicos_dic[servicos];        
                }
                relatorio["Atendimentos Realizados"]++;
                relatorio["Serviços pagos"]++;
                relatorio["valor recebido R$"] = somaServicos;
            }
            
        }
        else
        {
            Console.WriteLine($"serviço indisponivel {servicos}");
            relatorio["atendimentos Recusados"]++;
        }
    }
    return relatorio;
}

Dictionary<string, double> servicos_valor = new()
{
    {"Banho", 50},
    {"Banho + Tosa", 80},
    {"Tosa Total", 60},
    {"Tosa Bebê", 70}
};

string[] atendimentos =
{
    "Thor:Banho",
    "Mel:Banho + Tosa",
    "Rex:Tosa Total",
    "Thor:Banho",
    "Luna:Tosa Bebê",
    "Mel:Banho + Tosa",
    "Bob:Banho",
    "kiara:unha"
};


Dictionary<string, double> descontos = new()
{
    {"Thor", 10},
    {"Mel", 5},
    {"Rex", 0}
};
Dictionary<string, int> pacotes = new()
{
    {"Thor", 3},
    {"Mel", 2},
    {"Rex", 0},
    {"Luna", 5}
};

void Resumo(Dictionary<string,double> relatorio){
    Console.WriteLine("======= RESUMO =======");
    foreach(var item in relatorio ){
        var key = item.Key;
        var value = item.Value;
        Console.WriteLine($"{key} {value}");
    }
}

Resumo(SistemaCaixa(atendimentos,pacotes,servicos_valor,descontos));
