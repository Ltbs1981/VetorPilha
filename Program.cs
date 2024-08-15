int[] pilha = new int[5];
int topo = -1;
Pop();


Push(5);
Push(10);
Push(15);
Push(9);
Push(200);
Push(32);

ExibirPilha();
Pop();
Pop();
Pop();
Pop();
Pop();

ExibirPilha();

bool PilhaCheia()
{
    return topo == pilha.Length - 1;
}

bool PilhaVazia()
{
    return topo == -1;
}

void Push(int valor)
{
    if (PilhaCheia())
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

void Pop()
{
    if (PilhaVazia())
    {
        Console.WriteLine("a pilha está vazia.");
        
    }
    else
    {
        int valor = pilha[topo];
        topo--;
        Console.WriteLine($"Item {valor} removido da pilha.");
    }
}
void ExibirPilha()
{
    if (PilhaVazia())
    {
        Console.WriteLine("A pilha está vazia.");
    }
    else
    {
        Console.WriteLine("Exibindo a pilha");
        for (int i = topo; i >= 0; i--)
        {
            Console.WriteLine(pilha[i]);
        }
    }
}