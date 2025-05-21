using InheritanceExample;

public class Program
{
    public static void Main (string[] args)
    {
        Ogretmen ogretmen = new Ogretmen();
        Ogrenci ogrenci=new Ogrenci();
        ogretmen.Name = "Musa";
        ogretmen.Surname = "Aydın";
        ogretmen.Salary = 86000;

        ogretmen.DisplayOgretmen();
        ogrenci.Name = "Rana";
        ogrenci.Surname = "Kaya";
        ogrenci.OgrenciNumarasi = "1921221032";
        ogrenci.DisplayOgrenci();
    }
}
