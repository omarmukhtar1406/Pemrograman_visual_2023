from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W
class FrmPersegi:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x200")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        
        Label(mainFrame, text='Panjang:' ).grid(row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Lebar:").grid(row=1, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas Persegi Panjang:").grid(row=3, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling Persegi Panjang:").grid(row=4, column=0, sticky=W, padx=5, pady=5)

        self.txtPanjang = Entry(mainFrame)
        self.txtPanjang.grid(row=0, column=1, padx=5, pady=5)
        self.txtLebar = Entry(mainFrame)
        self.txtLebar.grid(row=1, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=3, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=4, column=1, padx=5, pady=5)

        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung)
        self.btnHitung.grid(row=2, column=1, padx=5, pady=5)

    def onHitung(self, event=None):
        panjang = int(self.txtPanjang.get())
        lebar = int(self.txtLebar.get())
        luas, keliling = self.luaskeliling(panjang, lebar)
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(keliling))

    def luaskeliling(self, panjang, lebar):
        luas = panjang * lebar
        keliling = (2 * panjang) + (2 * lebar)
        return luas, keliling
    
    def onKeluar(self, event=None):
        self.parent.destroy()

if __name__ == '__main__' :
    root = Tk()
    aplikasi = FrmPersegi(root, "Program Luas dan Keliling Persegi Panjang" )
    root.mainloop()
