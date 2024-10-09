
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

// Bu konu, class konusunu gördüğümüzde tekrar konuşulacaktır.
static int Topla(int a,int b)
{

    return 1;
}
static double Topla(double a, double b)
{
    return 1;
}


// aynı örneği kendi bilgisayarlarınzda bir deneyin!!