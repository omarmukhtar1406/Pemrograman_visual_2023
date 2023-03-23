from tkinter import Frame, Label, Entry, Button, YES, BOTH, END, Tk, W

class Segitiga:
    def __init__(self, alas, tinggi, S1, S2, S3):
        self.alas = alas
        self.tinggi = tinggi
        self.s1 = S1
        self.s2 = S2
        self.s3 = S3

    def hitung_luas(self):
        return (self.alas * self.tinggi)/2
    
    def hitung_keliling(self):
        return self.s1 + self.s2 + self.s3

class FrmSegitiga:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x290")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        
        Label(mainFrame, text='Alas' ). grid(row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Tinggi" ).grid(row=1, column=0, sticky=W, padx=5, pady=5) 
        Label(mainFrame, text="S1").grid(row=3, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="S2").grid(row=4, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="S3").grid(row=5, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas" ).grid(row=7, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling" ).grid(row=8, column=0, sticky=W, padx=5, pady=5)

        self.txtAlas = Entry(mainFrame)
        self.txtAlas.grid(row=0, column=1, padx=5, pady=5)
        self.txtTinggi = Entry(mainFrame)
        self.txtTinggi.grid(row=1, column=1, padx=5, pady=5)
        self.txtS1 = Entry(mainFrame)
        self.txtS1.grid(row=3, column=1, padx=5, pady=5)
        self.txtS2 = Entry(mainFrame)
        self.txtS2.grid(row=4, column=1, padx=5, pady=5)
        self.txtS3 = Entry(mainFrame)
        self.txtS3.grid(row=5, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=7, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=8, column=1, padx=5, pady=5)
        
        self.btnHitung = Button(mainFrame, text='Hitung', command=self.on_hitung)
        self.btnHitung.grid(row=6, column=1, padx=5, pady=5)

    def on_hitung(self, event=None):
        alas = int(self.txtAlas.get())
        tinggi = int(self.txtTinggi.get())
        S1 = int(self.txtS1.get())
        S2 = int(self.txtS2.get())
        S3 = int(self.txtS3.get())
        segitiga = Segitiga(alas, tinggi, S1, S2, S3)
        luas = segitiga.hitung_luas()
        keliling = segitiga.hitung_keliling()
        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        self.txtKeliling.delete(0, END)
        self.txtKeliling.insert(END, str(keliling))

    def onKeluar(self, event=None):
        self.parent.destroy()

if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmSegitiga(root, "Program Luas dan Keliling Segitiga")
    root.mainloop()