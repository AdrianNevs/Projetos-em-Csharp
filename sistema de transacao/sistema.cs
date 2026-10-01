void Relatorio(Dictionary<string,int> resumo,Dictionary<string,double> clientes)
{
    double maior = 0;
    string cliente = "";
    Console.WriteLine("=====Resumo=====");
    foreach (var item in resumo)
    {
        Console.WriteLine($"{item.Key} = {item.Value}");
    }
    foreach (var item in clientes)
    {
        if (maior < item.Value){
            cliente = item.Key;
            maior = item.Value;
        } 
    }
    Console.WriteLine();
    Console.WriteLine($"Cliente com maior saldo {cliente} = {maior}");

}


bool Processar_Transacao(string nome, Dictionary<string, double> clientes, double valor, string transferencia,Dictionary<string,int> Resumo)
{
    string[] permitidos = ["PIX", "DEBITO", "SAQUE"];
    if (!clientes.ContainsKey(nome))
    {
        return false;
    }
    if (!permitidos.Contains(transferencia))
    {
        Console.WriteLine("Trasferencia nao e permitida");
        Resumo["Recusadas"]++;
        return true;
    }
    if (valor <= 0)
    {
        Console.WriteLine("Valor inesistente");
        Resumo["Recusadas"]++;
        return true;
    }
    if (valor <= clientes[nome])
    {
        Console.WriteLine($"Cliente {nome} {transferencia} = {valor}");
        clientes[nome] -= valor;
        Resumo["Aprovadas"]++;
        return true;
    }
    else
    {
        Console.WriteLine("Valor de saque acima do valor da conta");
        Resumo["Recusadas"]++;
        return true;
    }

}

void Sistema_De_Transacao(string[] transacoes, Dictionary<string, double> cliente)
{
    Dictionary<string,int> Resumo = new Dictionary<string, int> {{"Recusadas",0},{"Aprovadas",0}};
    string nome, transferencia;
    double valor = 0;
    string[] separar;
    foreach (string processo in transacoes)
    {
        separar = processo.Split(':');
        nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(separar[0]);
        transferencia = separar[1].ToUpper();
        try
        {
            valor = Convert.ToDouble(separar[2]);
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor de transacao invalido");
            Resumo["Recusadas"]++;
            continue;
        }
        if (!Processar_Transacao(nome, cliente, valor, transferencia,Resumo))
        {
            Console.WriteLine("Cliente nao consta no banco de cadastro");
            Resumo["Recusadas"]++;
        }
    }
    Relatorio(Resumo,cliente);
    return;
}

string[] transacoes =
{
    "Adrian:PIX:500",
    "ana:DEBITO:150",
    "Carlos:PIX:abc",
    "Bruno:PIX:-200",
    "Adrian:SAQUE:100",
    "Ana:PIX:300",
    "Carlos:SAQUE:50",
    "Bruno:pix:400",
    "Adrian:TRANSFERENCIA:200",
    "Ana:PIX:xyz",
    "Carlos:PIX:100",
    "Abdner los:credito:100"
};

Dictionary<string, double> contas = new()
{
    {"Adrian", 1000},
    {"Ana", 500},
    {"Carlos", 300},
    {"Bruno", 800}
};


Sistema_De_Transacao(transacoes, contas);
