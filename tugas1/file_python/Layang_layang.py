from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W

class FrmLayang2:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x400")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)

        # pasang Label
        Label(mainFrame, text='Diagonal 1 :').grid(row=0, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Diagonal 2 :").grid(row=1, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="a :").grid(row=2, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="b :").grid(row=3, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="c :").grid(row=4, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="d :").grid(row=5, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas :").grid(row=7, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling :").grid(row=8, column=0,
        sticky=W, padx=5, pady=5)

        # pasang textbox
        self.txtDiagonal1 = Entry(mainFrame)
        self.txtDiagonal1.grid(row=0, column=1, padx=5, pady=5)
        self.txtDiagonal2 = Entry(mainFrame)
        self.txtDiagonal2.grid(row=1, column=1, padx=5, pady=5)
        self.txta = Entry(mainFrame)
        self.txta.grid(row=2, column=1, padx=5, pady=5)
        self.txtb = Entry(mainFrame)
        self.txtb.grid(row=3, column=1, padx=5, pady=5)
        self.txtc = Entry(mainFrame)
        self.txtc.grid(row=4, column=1, padx=5, pady=5)
        self.txtd = Entry(mainFrame)
        self.txtd.grid(row=5, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=7, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=8, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung)
        self.btnHitung.grid(row=6, column=1, padx=5, pady=5)

    # fungsi untuk menghitung luas dan keliling Layang-layang
    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Terstruktur
        diagonal1 = int(self.txtDiagonal1.get())
        diagonal2 = int(self.txtDiagonal2.get())
        a = int(self.txta.get())
        b = int(self.txtb.get())
        c = int(self.txtc.get())
        d = int(self.txtd.get())
        layang2 = Layang2(diagonal1, diagonal2, a, b, c, d)
        luas = layang2.luas()
        keliling = layang2.keliling()

        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(keliling))

    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()

class Layang2():
    # perhitungan dengan metode Pemrograman OOP
    def __init__(self, diagonal1, diagonal2, a, b, c, d):
        self.diagonal1 = diagonal1
        self.diagonal2 = diagonal2
        self.Sisia = a
        self.Sisib = b
        self.Sisic = c
        self.Sisid = d

    def luas(self):
        return (self.diagonal1 * self.diagonal2) /2

    def keliling(self):
        return self.Sisia + self.Sisib + self.Sisic + self.Sisic
        
if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmLayang2(root, "Program Luas dan Keliling Layang-layang")
    root.mainloop() 