class Cinema:
    def __init__(self, dia, horario):
        self.__dia = dia
        self.__horario = horario

    def entrada(self):
        # Definir o valor base do ingresso com base no dia da semana
        if self.__dia in ["segunda", "terça", "quinta"]:
            valor_base = 16.00
        elif self.__dia == "quarta":
            valor_base = 8.00  # Todos pagam meia na quarta
        elif self.__dia in ["sexta", "sábado", "domingo"]:
            valor_base = 20.00
        else:
            raise ValueError("Dia inválido")

        # Adicionar acréscimo de 50% se o horário for entre 17h e meia-noite
        if 17 <= self.__horario <= 23:
            valor_base *= 1.5

        return valor_base

    def valor_inteira(self):
        return self.entrada()

    def valor_meia(self):
        if self.__dia == "quarta":
            return self.entrada()  # Na quarta, todos pagam meia
        return self.entrada() / 2

    def __str__(self):
        return f"Dia: {self.__dia.capitalize()}, Hora: {self.__horario}:00"

# Programa para testar a classe Cinema
def testar_entradas():
    # Teste com diferentes dias e horários
    dias = ["segunda", "terça", "quarta", "quinta", "sexta", "sábado", "domingo"]
    horas = [10, 16, 17, 20, 23]

    for dia in dias:
        for hora in horas:
            entrada = Cinema(dia, hora)
            print(entrada)
            print(f"Valor Inteira: R${entrada.valor_inteira():.2f}")
            print(f"Valor Meia: R${entrada.valor_meia():.2f}")
            print("-" * 30)

# Executar os testes
testar_entradas()
