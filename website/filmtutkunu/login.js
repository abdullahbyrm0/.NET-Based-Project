
                var kullanicilar = [{ kullaniciAdi:"abdullahbyrm0", parola: "Abdullah123."},
                {kullaniciAdi:"admin", parola:"admin"},
                ]  ;
var girilenkullaniciAdi;
var girilenParola;
var x;
function kontrolEt(){

     girilenkullaniciAdi = document.getElementById("kullaniciAdi").value;
     girilenParola = document.getElementById("parola").value;


     for(x of kullanicilar){

         if((x.kullaniciAdi == girilenkullaniciAdi) && (x.parola == girilenParola)) {
             return true;
         }
         

     }
} 
function girisOnayi() {

 kontrolEt();
 if(kontrolEt()) {

                 window.location.href="Default/HomePage";
 }
 else{
     
     alert("Girdiğiniz bilgiler yanlıştır Lütfen kontrol ediniz !");
     document.getElementById("kullaniciAdi").value="";
     document.getElementById("parola").value="";

 }

}



