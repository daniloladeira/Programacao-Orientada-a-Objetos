class Item:
    def __init__(self, prod, qtd, preco):
        if prod == "":
            raise ValueError("Produto não pode ser vazio")
        if qtd <= 0:
            raise ValueError("Quantidade deve ser maior que zero")
        if preco <= 0:
            raise ValueError("Preço deve ser maior que zero")
        
        self.__produto = prod
        self.__qtd = qtd
        self.__preco_unit = preco

    def set_produto(self, prod):
        if prod == "":
            raise ValueError("Produto não pode ser vazio")
        self.__produto = prod

    def set_qtd(self, qtd):
        if qtd <= 0:
            raise ValueError("Quantidade deve ser maior que zero")
        self.__qtd = qtd

    def set_preco_unit(self, preco):
        if preco <= 0:
            raise ValueError("Preço deve ser maior que zero")
        self.__preco_unit = preco

    def get_produto(self):
        return self.__produto
    
    def get_qtd(self):
        return self.__qtd
    
    def get_preco_unit(self):
        return self.__preco_unit
    
    def total(self):
        return self.__qtd * self.__preco_unit
    
    def __str__(self):
        return f"{self.__produto} {self.__qtd} x {self.__preco_unit} = {self.total()}"

class Carrinho:
    def __init__(self, cliente, data):
        if cliente == "":
            raise ValueError("Cliente não pode ser vazio")
        self.__cliente = cliente
        self.__data = data
        self.__itens = []

    def inserir(self, item):
        self.__itens.append(item)

    def remover(self, item):
        self.__itens.remove(item)

    def listar(self):
        return self.__itens
    
    def total(self):
        t = 0
        for item in self.__itens:
            t += item.total()
        return t
    
    def __str__(self):
        return f"Cliente: {self.__cliente}\nData: {self.__data}\nTotal de itens: {len(self.__itens)}\nTotal a pagar: {self.total()}"

# Aqui você cria os itens
fruta_1 = Item("Maçã", 5, 2.5)
fruta_2 = Item("Banana", 2, 1.0)
comida_1 = Item("Galeto", 1, 20.50)

# Aqui você cria um carrinho
carrinho = Carrinho("Danilo", "03/04/2024")

# Aqui você insere os itens criados anteriormente
carrinho.inserir(fruta_1)
carrinho.inserir(fruta_2)
carrinho.inserir(comida_1)

# Imprimindo detalhes do carrinho
print(carrinho)

# Listando itens no carrinho
for item in carrinho.listar():
    print(item)

# Imprimindo o total do carrinho
print("Total do carrinho:", carrinho.total())
