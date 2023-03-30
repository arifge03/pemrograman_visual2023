from tkinter import Tk, Label, Frame, BOTH, YES, W
class FormBlanko:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("200x100") # Ukuran Layar Windows
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        # Label
        # row=0 -> baris pertama
        # column=0 -> kolom pertama
        Label(mainFrame, text='A1').grid(row=0, column=0, sticky=W,
        padx=5, pady=5)
        Label(mainFrame, text='B1').grid(row=0, column=1, sticky=W,
        padx=5, pady=5)
        Label(mainFrame, text='C1').grid(row=0, column=2, sticky=W,
        padx=5, pady=5)
        Label(mainFrame, text='D1').grid(row=0, column=3, sticky=W,
        padx=5, pady=5)
        Label(mainFrame, text='E1').grid(row=0, column=4, sticky=W,
        padx=5, pady=5)
        Label(mainFrame, text='F1').grid(row=0, column=5, sticky=W,
        padx=5, pady=5)
        Label(mainFrame, text='A2').grid(row=1, column=0, sticky=W,
        padx=5, pady=5)
        Label(mainFrame, text='B2').grid(row=1, column=1, sticky=W,
        padx=5, pady=5)
        Label(mainFrame, text='C2').grid(row=1, column=2, sticky=W,
        padx=5, pady=5)
        Label(mainFrame, text='D2').grid(row=1, column=3, sticky=W,
        padx=5, pady=5)
        Label(mainFrame, text='E2').grid(row=1, column=4, sticky=W,
        padx=5, pady=5)
        Label(mainFrame, text='F2').grid(row=1, column=5, sticky=W,
        padx=5, pady=5)

    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()
if __name__ == '__main__':
    root = Tk()
    aplikasi = FormBlanko(root, "Program")
    root.mainloop() 