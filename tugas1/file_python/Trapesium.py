from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W

class FrmTrapesium:
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
        Label(mainFrame, text='Alas a:').grid(row=0, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Alas b:').grid(row=1, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Tinggi:").grid(row=2, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="a:").grid(row=3, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="b:").grid(row=4, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="c:").grid(row=5, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="d:").grid(row=6, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=8, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=9, column=0,
        sticky=W, padx=5, pady=5)

        # pasang textbox
        self.txtAlasa = Entry(mainFrame)
        self.txtAlasa.grid(row=0, column=1, padx=5, pady=5)
        self.txtAlasb = Entry(mainFrame)
        self.txtAlasb.grid(row=1, column=1, padx=5, pady=5)
        self.txtTinggi = Entry(mainFrame)
        self.txtTinggi.grid(row=2, column=1, padx=5, pady=5)
        self.txta = Entry(mainFrame)
        self.txta.grid(row=3, column=1, padx=5, pady=5)
        self.txtb = Entry(mainFrame)
        self.txtb.grid(row=4, column=1, padx=5, pady=5)
        self.txtc = Entry(mainFrame)
        self.txtc.grid(row=5, column=1, padx=5, pady=5)
        self.txtd = Entry(mainFrame)
        self.txtd.grid(row=6, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=8, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=9, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung)
        self.btnHitung.grid(row=7, column=1, padx=5, pady=5)

    # fungsi untuk menghitung luas dan keliling trapesium
    def onHitung(self, event=None):
        alas_a = int(self.txtAlasa.get())
        alas_b = int(self.txtAlasb.get())
        tinggi = int(self.txtTinggi.get())
        a = int(self.txta.get())
        b = int(self.txtb.get())
        c = int(self.txtc.get())
        d = int(self.txtd.get())
        trapesium = Trapesium(alas_a, alas_b, tinggi, a, b, c, d)
        luas = trapesium.luas()
        keliling = trapesium.keliling()

        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(keliling))

    def trapesium(self, alas_a, alas_b, tinggi, a, b, c, d):
        luas = 0.5 * (alas_a + alas_b) * tinggi
        keliling = a + b + c + d
        return luas, keliling

    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()

class Trapesium():
    # perhitungan dengan metode Pemrograman OOP
    def __init__(self, alas_a, alas_b, tinggi, a, b, c, d):
        self.alas_a = alas_a
        self.alas_b = alas_b
        self.tinggi = tinggi
        self.sisia = a
        self.sisib = b
        self.sisic = c
        self.sisid = d

    def luas(self):
        return (self.alas_a + self.alas_b) * self.tinggi / 2 

    def keliling(self):
        return self.sisia + self.sisib + self.sisic + self.sisid
if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmTrapesium(root, "Program Luas dan Keliling Trapesium")
    root.mainloop() 