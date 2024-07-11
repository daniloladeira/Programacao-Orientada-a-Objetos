class Item:
    def __init__(self, prod, qtd, preco):
        self.__produto = prod
        self.__qtd = qtd
        self.__preco_unit = preco

        if prod == "": raise ValueError()
        if qtd <= 0: raise ValueError()
        if preco <= 0: raise ValueError()

    def set_produto(self, prod):
        self.__produto = prod
        if prod == "": raise ValueError()

    def set_qtd(self, qtd):
        self.__qtd = qtd
        if qtd <= 0: raise ValueError()

    def set_preco_unit(self, preco):
        self.__preco_unit = preco
        if preco <= 0: raise ValueError()

    def get_produto(self):
        return self.__produto
    
    def get_qtd(self):
        return self.__qtd
    
    def get_preco_unit(self):
        return self.__preco_unit
    
    def Total(self):
        return (self.__qtd) * (self.__preco_unit)
    
    def ToString(self):
        return 'f Produto - {self.__produto} Quantidade - {self.__quantidade} Preço Unitário - {self.__preco_unit}'

class Carrinho:
    def __init__(self):
        self.__cliente = ""
        self.__data = ""
        self.__itens = []

    def inserir(self, item):
        self.__itens.append(item)