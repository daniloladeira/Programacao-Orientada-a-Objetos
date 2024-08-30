using System;
using System.Collections.Generic;

class Item
{
    private string produto;
    private int qtd;
    private double precoUnit;

    public Item(string prod, int qtd, double preco)
    {
        if (string.IsNullOrEmpty(prod))
            throw new ArgumentException("Produto não pode ser vazio");
        if (qtd <= 0)
            throw new ArgumentException("Quantidade deve ser maior que zero");
        if (preco <= 0)
            throw new ArgumentException("Preço deve ser maior que zero");

        this.produto = prod;
        this.qtd = qtd;
        this.precoUnit = preco;
    }

    public void SetProduto(string prod)
    {
        if (string.IsNullOrEmpty(prod))
            throw new ArgumentException("Produto não pode ser vazio");
        this.produto = prod;
    }

    public void SetQtd(int qtd)
    {
        if (qtd <= 0)
            throw new ArgumentException("Quantidade deve ser maior que zero");
        this.qtd = qtd;
    }

    public void SetPrecoUnit(double preco)
    {
        if (preco <= 0)
            throw new ArgumentException("Preço deve ser maior que zero");
        this.precoUnit = preco;
    }

    public string GetProduto()
    {
        return produto;
    }

    public int GetQtd()
    {
        return qtd;
    }

    public double GetPrecoUnit()
    {
        return precoUnit;
    }

    public double Total()
    {
        return qtd * precoUnit;
    }

    public override string ToString()
    {
        return $"{produto} {qtd} x {precoUnit:C} = {Total():C}";
    }
}

class Carrinho
{
    private string cliente;
    private string data;
    private List<Item> itens;

    public Carrinho(string cliente, string data)
    {
        if (string.IsNullOrEmpty(cliente))
            throw new ArgumentException("Cliente não pode ser vazio");

        this.cliente = cliente;
        this.data = data;
        this.itens = new List<Item>();
    }

    public void Inserir(Item item)
    {
        itens.Add(item);
    }

    public void Remover(Item item)
    {
        itens.Remove(item);
    }

    public List<Item> Listar()
    {
        return itens;
    }

    public double Total()
    {
        double total = 0;
        foreach (var item in itens)
        {
            total += item.Total();
        }
        return total;
    }

    public override string ToString()
    {
        return $"Cliente: {cliente}\nData: {data}\nTotal de itens: {itens.Count}\nTotal a pagar: {Total():C}";
    }
}

class Program
{
    static void Main()
    {
        // Aqui você cria os itens
        Item fruta1 = new Item("Maçã", 5, 2.5);
        Item fruta2 = new Item("Banana", 2, 1.0);
        Item comida1 = new Item("Galeto", 1, 20.50);

        // Aqui você cria um carrinho
        Carrinho carrinho = new Carrinho("Danilo", "03/04/2024");

        // Aqui você insere os itens criados anteriormente
        carrinho.Inserir(fruta1);
        carrinho.Inserir(fruta2);
        carrinho.Inserir(comida1);

        // Imprimindo detalhes do carrinho
        Console.WriteLine(carrinho);

        // Listando itens no carrinho
        foreach (var item in carrinho.Listar())
        {
            Console.WriteLine(item);
        }

        // Imprimindo o total do carrinho
        Console.WriteLine("Total do carrinho: " + carrinho.Total().ToString("C"));
    }
}
