from tkinter import Tk, Button, Frame, BOTH, YES, messagebox

class FormBlanko:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("300x200")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()
        
    def aturKomponen(self):
        # Pasang Frame
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        # Pasang Button
        self.btnTampil = Button(mainFrame, text='Tampil Pesan', command=self.onTampil)
        self.btnTampil.grid(row=2, column=1, padx=5, pady=5)

    def onTampil(self, event=None):
        messagebox.showinfo("showinfo", "Selamat Belajar Pemrograman Visual")

    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()

if __name__ == '__main__':
    root = Tk()
    aplikasi = FormBlanko(root, "Program")
    root.mainloop() 