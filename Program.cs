
// Metot OverLoading  : Metotları aşırı yüklemek 

// Aynı isimde iki metot yazdığımızda, bu iki metodun adı çakışacağı için, c# bize izin vermez
// Ancak bazı durumlarda aynı isimde bir yada daha fazla metot yazılmasına izin verir
// Birden fazla metodun aynı ismi alma konusuna Method Overloading denir.

// Method Overloding c# içerisinde çok fazla kullanılan bir yöntemdir. 

// bir metodun overload olabilmesi için, parametre sayısı ve parametre tipi



// Başarısız OverLoading örneği, : Parametreler aynı tipte ve aynı sayıda
/*
static void Deneme(bool isOk){

}
static int Deneme(bool notOk){
    return 0;
}*/

// Başarılı OverLoading Örneği

// Metot Overloading Program.Cs dosyasında, çalışmamaktadır.

// Main : 

internal class Program
{
    private static void Main(string[] args)
    {
        // main metodu, uygulamanın başlangıç noktasıdır.

        // derleciyi uygulamayı nereden başlatacağını main metodu ile bilir.
        // main metodu eskiden, her yeni projede gelirdi ancak yavaş yavaş artık kullanılmayacağı için, projeyi açtığımızda ekranda gelmiyordu. Ancak yinede derleyici biz görmesekte bir tane arkada main metodunu yazıyorud
        // main metodu, ekranda görünmediği zaman , kod yazdığımız kısım, olduğu gibi main metodunun içerisi oluyordu
        // bu sebeple, main metodunun içerisinde metot yazdığımızda overloding yapamış oluyordu
        Topla(10, 20);


        
    }

    // bir metodun overloading olabilmesi için, main metodunun dışarında olması gerekmektedir.
    // ilerleyen konularda, kendimize yeni bir sınıf yazdığımızda, main metodu olmayacağıiçin, rahatlıkla overloading yapabilirz

    // Başarılı bir overloading örneği

    // aldıkları parametre tipleri ve sayıları

    // Önemli : Geri dönüş değeri metot overloading kavramı içerisinde bir önemi yoktur.
    static void Topla(int a, int b)
    {
    }
    static void Topla(double a, double b)
    {
    }

    // Başarılı bir overloaing örneği : Parametre sayıları aynı ancak tipleri farklı!!!
    static void Yaz(string yaz)
    {

    }
    static void Yaz(double yaz)
    {

    }

    // Başarısız bir overloading örneği
    // Geri dönüş değerinin farklı olması, metot overloading için yeterli değildir


    // DİKKAT : metot overloading yapmak için, parametre tip veya sayısının farklı olması gerkemektedir.
    // Geri dönüş değeri overloading için yeterli değildir.
    static int Oku(string deger)
    {

        return 1;
    }
    static string Oku(string deger)
    {
        return "";

    }
    static void CarpInt(int a, int b)
    {


    }
    static void CarpDouble(double a,double b){

    }

}
// Metot Overloading olmasaydı ne olurdu ? 
// Metot OverLoading olmasaydı : c# içerisindeki bir çok metodun örnek console.Writeline 19 farklı kullanımı olmazdı
// her bir farklı parametre alan WriteLine metodu için ayrı isimlerle metot yazmak zorunda kalırlardı


