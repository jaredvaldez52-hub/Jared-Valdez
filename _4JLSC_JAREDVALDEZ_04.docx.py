class Complejo:
    def__init__(self,real=0,imaginario=0):
        self.real = Real # type: ignore
        self.imaginario = imaginario
def main():
    # Declarar dos objetos p y q de la clase Complejo
    p = Complejo()
    q = Complejo()

    #Cargar los datos del n�mero complejo p
    p.real = 4
    p.imaginario = 10

    #Cargar los datos del n�mero complejo q
    q.real = -4
    q.imaginario = 1

    #Mostrar los n�meros complejos p y q 
    print("p = {} + {}i".format(p.real, p.imaginario))
    print("q = {} + {}i".format(p.real, p.imaginario))
if __name__ == "__main__":
    main()