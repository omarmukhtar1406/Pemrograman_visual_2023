from tkinter import Frame, Label, Entry, Button, YES, BOTH, END, Tk, W

class Trapesium:
    def __init__(self, Sa, Sb, Sc, Sd, T):
        self.sa = Sa
        self.sb = Sb
        self.sc = Sc
        self.sd = Sd
        self.tinggiTrapesium = T
    
    def hitung_luas(self):
        return ((self.sa + self.sb) * self.tinggiTrapesium/2)
    
    def hitung_keliling(self):
        return self.sa + self.sb + self.sc + self.sd

class TrapesiumGUI: 
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x300")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()
    
    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)

        Label(mainFrame, text='Sisi a').grid(row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi b").grid(row=1, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi c").grid(row=2, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi d").grid(row=3, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Tinggi").grid(row=4, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas").grid(row=6, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling").grid(row=7, column=0, sticky=W, padx=5, pady=5)

        self.txtSa = Entry(mainFrame)
        self.txtSa.grid(row=0, column=1, padx=5, pady=5)
        self.txtSb = Entry(mainFrame)
        self.txtSb.grid(row=1, column=1, padx=5, pady=5)
        self.txtSc = Entry(mainFrame)
        self.txtSc.grid(row=2, column=1, padx=5, pady=5)
        self.txtSd = Entry(mainFrame)
        self.txtSd.grid(row=3, column=1, padx=5, pady=5)
        self.txtTinggi = Entry(mainFrame)
        self.txtTinggi.grid(row=4, column=1, padx=5, pady=5)
        
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=6, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=7, column=1, padx=5, pady=5)

        self.btnHitung = Button(mainFrame, text='Hitung', command=self.onHitung)
        self.btnHitung.grid(row=5, column=1, padx=5, pady=5)
    
    def onHitung(self, event=None):
        Sa = int(self.txtSa.get())    
        Sb = int(self.txtSb.get())
        Sc = int(self.txtSc.get())    
        Sd = int(self.txtSd.get())
        T= int(self.txtTinggi.get())
        trapesium = Trapesium(Sa, Sb, Sc, Sd, T)
        luas = trapesium.hitung_luas()
        keliling = trapesium.hitung_keliling()
        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(keliling))
    
    def onKeluar(self, event=None):
        self.parent.destroy()

if __name__ == '__main__':
    root = Tk()
    aplikasi = TrapesiumGUI(root, "Program Luas dan Keliling Trapesium")
    root.mainloop()