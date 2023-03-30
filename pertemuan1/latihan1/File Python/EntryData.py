import tkinter as tk
from tkinter import ttk

class App:
    def __init__(self, root):
        self.root = root
        self.root.title("Data Entry App")

        # siapkan variabel dictionary kosong utk menyimpan data
        self.data = {}

        # Label dan Textbox Nama
        tk.Label(root, text="Nama:").grid(row=0, column=0, padx=5, pady=5)
        self.nama_entry = tk.Entry(root)
        self.nama_entry.grid(row=0, column=1, padx=5, pady=5)

        # Label dan Textbox Umur
        tk.Label(root, text="Umur:").grid(row=1, column=0, padx=5,
        pady=5)
        self.umur_entry = tk.Entry(root)
        self.umur_entry.grid(row=1, column=1, padx=5, pady=5)

        # Tombol Simpan
        tk.Button(root, text="Simpan",
        command=self.save_data).grid(row=2, column=1, padx=5, pady=5)

        # create a TreeView widget to display data
        self.tree = ttk.Treeview(root, columns=("nama", "umur"),
        show="headings")
        self.tree.column("nama", width=100)
        self.tree.column("umur", width=100)
        self.tree.heading("nama", text="Nama")
        self.tree.heading("umur", text="Umur")
        self.tree.grid(row=3, column=0, columnspan=2, padx=5, pady=5)

    def save_data(self):
        nama = self.nama_entry.get()
        umur = self.umur_entry.get()

        # save data to dictionary
        data_dict = {
        "nama": nama,
        "umur": umur
        }
        self.data.update(data_dict)

        # clear entry widgets
        self.nama_entry.delete(0, tk.END)
        self.umur_entry.delete(0, tk.END)

        # update TreeView with new data
        self.tree.insert("", tk.END, values=(nama, umur))

if __name__ == "__main__":
    root = tk.Tk()
    app = App(root)
    root.mainloop()