class BangunDatar():
    def luas(self):
        print("Menghitung Luas bangun datar")

    def keliling(self):
        print("Menghitung Keliling bangun datar")


class Persegi(BangunDatar):
    def _init_(self, sisi=0):
        self.sisi = sisi

    def luas(self):
        print("Luas Persegi: ", self.sisi * self.sisi)

    def keliling(self):
        print("Keliling Persegi: ", 4 * self.sisi)


class Lingkaran(BangunDatar):

    def _init_(self, r=0):
        self.r = r

    def luas(self):
        print("Luas Lingkaran: ", 3.14 * self.r ** 2)

    def keliling(self):
        print("Keliling Lingkaran: ", 2 * 3.14 * self.r)


class PersegiPanjang(BangunDatar):
    def _init_(self, panjang=0, lebar=0):
        self.panjang = panjang
        self.lebar = lebar

    def luas(self):
        print("Luas Persegi Panjang: ", self.panjang * self.lebar)

    def keliling(self):
        print("Keliling Persegi Panjang: ", 2 * self.panjang + 2 * self.lebar)


class Segitiga(BangunDatar):
    def _init_(self, alas=0, tinggi=0):
        self.alas = alas
        self.tinggi = tinggi

    def luas(self):
        print("Luas Segitiga: ", 1/2 * self.alas * self.tinggi)


class Main():

    def menu():
        print("\n\nInheritance Program")
        print("1. Persegi")
        print("2. Lingkaran")
        print("3. Persegi Panjang")
        print("4. Segitiga")
        print("5. Keluar Program")

    menu()
    pilihan = int(input("\nPilih Menu yang anda inginkan : "))

    while pilihan != 5:
        if pilihan == 1:
            persegi = Persegi()
            print("Menghitung Luas dan Keliling Persegi")
            persegi.sisi = int(input("Masukkan Sisi: "))
            persegi.luas()
            persegi.keliling()

        elif pilihan == 2:
            lingkaran = Lingkaran()
            print("Menghitung Luas dan Keliling Lingkaran")
            lingkaran.r = int(input("Masukkan Jari-jari: "))
            lingkaran.luas()
            lingkaran.keliling()

        elif pilihan == 3:
            persegiPanjang = PersegiPanjang()
            print("Menghitung Luas dan Keliling Persegi Panjang")
            persegiPanjang.panjang = int(input("Masukkan Panjang: "))
            persegiPanjang.lebar = int(input("Masukkan Lebar: "))
            persegiPanjang.luas()
            persegiPanjang.keliling()

        elif pilihan == 4:
            segitiga = Segitiga()
            print("Menghitung Luas Segitiga")
            segitiga.alas = int(input("Masukkan Alas: "))
            segitiga.tinggi = int(input("Masukkan Tinggi: "))
            segitiga.luas()

        else:
            print("Menu tidak tersedia")

        menu()
        pilihan = int(input("\nPilih Menu yang anda inginkan :  "))