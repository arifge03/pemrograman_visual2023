from tkinter import Tk

class FormBlanko:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x200")
        self.parent.title(title)

if __name__ == '__main__':
    root = Tk()
    aplikasi = FormBlanko(root, "Program")
    root.mainloop() 