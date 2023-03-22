from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W

class FrmSegitiga:
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
        Label(mainFrame, text='Alas:').grid(row=0, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Tinggi:").grid(row=1, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi a:").grid(row=2, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi b:").grid(row=3, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi c:").grid(row=4, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=6, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=7, column=0,
        sticky=W, padx=5, pady=5)

        # pasang textbox
        self.txtAlas = Entry(mainFrame)
        self.txtAlas.grid(row=0, column=1, padx=5, pady=5)
        self.txtTinggi = Entry(mainFrame)
        self.txtTinggi.grid(row=1, column=1, padx=5, pady=5)
        self.txtSisia = Entry(mainFrame)
        self.txtSisia.grid(row=2, column=1, padx=5, pady=5)
        self.txtSisib = Entry(mainFrame)
        self.txtSisib.grid(row=3, column=1, padx=5, pady=5)
        self.txtSisic = Entry(mainFrame)
        self.txtSisic.grid(row=4, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=6, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=7, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung)
        self.btnHitung.grid(row=5, column=1, padx=5, pady=5)

    # fungsi untuk menghitung luas dan keliling segitiga
    def onHitung(self, event=None):
        alas = int(self.txtAlas.get())
        tinggi = int(self.txtTinggi.get())
        a = int(self.txtSisia.get())
        b = int(self.txtSisib.get())
        c = int(self.txtSisic.get())
        segitiga = Segitiga(alas, tinggi, a, b, c)
        luas = segitiga.luas()
        keliling = segitiga.keliling()

        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(keliling))

    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()

class Segitiga():
    # perhitungan dengan metode Pemrograman OOP
    def __init__(self, alas, tinggi, a, b, c):
        self.alas = alas
        self.tinggi = tinggi
        self.sisia = a
        self.sisib = b
        self.sisic = c

    def luas(self):
        return 0.5 * self.alas * self.tinggi

    def keliling(self):
        return self.sisia + self.sisib + self.sisic

if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmSegitiga(root, "Program Luas dan Keliling Segitiga")
    root.mainloop() 