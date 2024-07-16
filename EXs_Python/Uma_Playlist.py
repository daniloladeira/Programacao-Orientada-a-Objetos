class Playlist:
    def __init__(self, nome, descricao):
        self.__nome = nome
        self.__descricao = descricao
        self.__musicas = []

    def set_nome(self, nome):
        if nome == "":
            raise ValueError("Nome não pode ser vazio")
        self.__nome = nome

    def set_descricao(self, descricao):
        if descricao == "":
            raise ValueError("Descrição não pode ser vazia")
        self.__descricao = descricao

    def get_nome(self):
        return self.__nome
    
    def get_descricao(self):
        return self.__descricao
    
    def inserir(self, musica):
        self.__musicas.append(musica)

    def listar(self):
        return self.__musicas
    
    def __str__(self):
        return f"Playlist {self.__nome} possui {len(self.__musicas)} músicas"

class Musica:
    def __init__(self, titulo, artista, album):
        self.__titulo = titulo
        self.__artista = artista
        self.__album = album

    def set_titulo(self, titulo):
        self.__titulo = titulo

    def set_artista(self, artista):
        self.__artista = artista

    def set_album(self, album):
        self.__album = album

    def get_titulo(self):
        return self.__titulo
    
    def get_artista(self):
        return self.__artista
    
    def get_album(self):
        return self.__album
    
    def __str__(self):
        return f"{self.__titulo} por {self.__artista} do álbum {self.__album}"
    
class UI:
    @staticmethod
    def main():
        play = None
        op = 0
        while op != 9:
            op = UI.menu()
            if op == 1: 
                play = UI.nova_playlist()
            elif op == 2: 
                if play is None: 
                    print("Crie uma nova playlist antes!")
                else:
                    musica = UI.nova_musica()
                    play.inserir(musica)
            elif op == 3: 
                if play is None: 
                    print("Crie uma nova playlist antes!")
                else:
                    for musica in play.listar():
                        print(musica)
            elif op == 9:
                print("Saindo...")
            else:
                print("Opção inválida, tente novamente.")
    
    @staticmethod
    def nova_playlist():
        nome = input("Informe o nome da playlist: ")
        descricao = input("Informe uma descrição: ")
        playlist = Playlist(nome, descricao)
        return playlist
    
    @staticmethod
    def nova_musica():
        titulo = input("Informe o título da música: ")
        artista = input("Informe o artista ou banda: ")
        album = input("Informe o álbum: ")
        musica = Musica(titulo, artista, album)
        return musica

    @staticmethod
    def menu():
        print("\n1 - Nova Playlist")
        print("2 - Inserir música")
        print("3 - Listar músicas")
        print("9 - Sair")
        return int(input("Opção: "))

UI.main()
