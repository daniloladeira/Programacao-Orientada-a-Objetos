class Triangulo:
    def __init__(self):
        self.b = 0
        self.h = 0

    def set_base(self,v):
        if v >= 0: self.__b = v
        else: raise ValueError("Inválido")

    def set_altura(self,v):
        if v >= 0: self.__h = v
        else: raise ValueError("Inválido")

    def get_base(self):
        return self.__b

    def get_altura(self):
        return self.__h

    def calc_area(self):
        return self.__b * self.__h / 2

class UI:
    @staticmethod
    def main():
            x = Triangulo()
            print("Digite o valor da base: ")
            x.set_base(float(input()))
            print("Digite o valor da altura: ")
            x.set_altura(float(input()))
            print(f"Um triângulo de base {x.get_base()} e altura {x.get_altura()}")
            print(f"ÁREA: {x.calc_area()}")
UI.main()
    