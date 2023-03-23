from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W

class ketupat:
    def __init__(self, d1, d2, S):
        self.diag1 = d1
        self.diag2 = d2
        self.s = S
        
    def hitung_luas(self):
        return (self.diag1 * self.diag2)/2
    
    def hitung_keliling(self):
        return self.s + self.s + self.s + self.s

class FrmBelahKetupat:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x250")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()
    
    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        
        Label(mainFrame, text="Diagonal 1:" ).grid(row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Diagonal 2:").grid(row=1, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi:").grid(row=2, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=4, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=5, column=0, sticky=W, padx=5, pady=5)

        self.txtd1 = Entry(mainFrame)
        self.txtd1.grid(row=0, column=1, padx=5, pady=5)
        self.txtd2 = Entry(mainFrame)
        self.txtd2.grid(row=1, column=1, padx=5, pady=5)
        self.txtsisi = Entry(mainFrame)
        self.txtsisi.grid(row=2, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=4, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=5, column=1, padx=5, pady=5)

        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung)
        self.btnHitung.grid(row=3, column=1, padx=5, pady=5)

    def onHitung(self, event=None):
        d1 = int(self.txtd1.get())
        d2 = int(self.txtd2.get())  
        S = int(self.txtsisi.get())
        belket = ketupat(d1,d2,S)
        keliling = belket.hitung_keliling()
        luas = belket.hitung_luas()
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(keliling))
    
    def onKeluar(self, event=None):
        self.parent.destroy()

if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmBelahKetupat(root, "Program Luas dan Keliling Belah Ketupat")
    root.mainloop() 