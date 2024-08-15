int [] pilha  = new int[5];

int topo = -1;

static bool PilhaCheia()
{
    return topo == pilha.Length - 1;
}

static bool PilhaVazia()
{
    return topo == -1;
}

static void Push(int valor)
{
    if (IsFull())
    {
        Console.WriteLine("Não é possível empilhar: a pilha está cheia.");
    }
    else
    {
        topo++;
        pilha[topo] = valor;
        Console.WriteLine($"Item {valor} adicionado à pilha.");
    }
}

static int Pop()
{
    if (IsEmpty())
    {
        Console.WriteLine("Não é possível desempilhar: a pilha está vazia.");
        return -1; // Valor indicativo de falha
    }
    else
    {
        int valor = pilha[topo];
        topo--;
        Console.WriteLine($"Item {valor} removido da pilha.");
        return valor;
    }
}





