import streamlit as st
import math

def calcular_II_grau(a, b, c):
    delta = b**2 - 4*a*c
    if delta > 0:
        x1 = (-b + math.sqrt(delta)) / (2 * a)
        x2 = (-b - math.sqrt(delta)) / (2 * a)
        return x1, x2
    elif delta == 0:
        x1 = -b / (2 * a)
        return x1,
    else:
        return None

def calcular_I_grau(a, b):
    if a != 0:
        x = -b / a
        return x
    else:
        return None



st.title("Resolução de Equações ")

escolha = st.selectbox("Escolha uma opção", ["Equação do I Grau", "Equação do II Grau"])

if escolha == ("Equação do I Grau"):
    a = st.number_input("Valor de A", value=1, format="%d", step=1)
    b = st.number_input("Valor de B", value=0, format="%d", step=1)

    if st.button("Resolver"):
        resultado = calcular_I_grau(a, b)
        if resultado is not None:
            st.write(f"A solução da equação é: x = {resultado}")
        else:
            st.write("O coeficiente 'a' não pode ser zero.")
elif escolha == "Equação do II Grau":
    a = st.number_input("Coeficiente A", value=1, format="%d", step=1)
    b = st.number_input("Coeficiente B", value=0, format="%d", step=1)
    c = st.number_input("Coeficiente C", value=0, format="%d", step=1)
    
    if st.button("Resolver"):
        if a != 0:
            resultado = calcular_II_grau(a, b, c)
            if resultado is not None:
                if len(resultado) == 2:
                    st.write(f"As raízes da equação são: x1 = {resultado[0]} e x2 = {resultado[1]}")
                else:
                    st.write(f"A raiz da equação é: x1 = {resultado[0]}")
            else:
                st.write("A equação não tem raízes reais.")
        else:
            st.write("O coeficiente 'a' não pode ser zero.")

