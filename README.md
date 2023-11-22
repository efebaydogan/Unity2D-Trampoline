
# Trampoline in Unity2D - English

With this repository, you can learn "How to Make Trampoline" in Unity 2D.


## Frequently asked Questions

#### What are variables for?

Rigidbody2D rb; - For our character's physical activies.

public int jumpPower; - To adjust the bouncing power of the trampoline.

public bool isTouch; - To check if the trampoline is in contact.

#### What is meaning Rigidbody2D?

It uses the Unity physics engine to simulate physical movements as in the real world.You have to add Rigidbody2D(component) to your character.

"rb = GetComponent<Rigidbody2D>();" - With this, we connect the rb variable we created to the rigidbody2D in Unity.

#### What is meaning OnCollisionEnter2D?

It is a function that works by sending a message when an object touches another object.


ATTENTİON:For the tramboline function to work correctly, you need to make the tag of your tramboline "trampoline" in unity.
## Author

- Created by Efe Baydoğan.

  ----------------------------------------------------------------------------------------------------

  # Unity2D'de Trambolin - Türkçe

Bu depo ile Unity 2D'de "Trambolin Nasıl Yapılır" öğrenebilirsiniz.


## Sık Sorulan Sorular

#### Değişkenler ne içindir?

Rigidbody2D rb; - Karakterimizin Fiziksel Aktiviteleri için.

public int jumpPower; - Trambolinin zıplama gücünü ayarlamak için.

public bool isTouch; - Trambolinin temas halinde olup olmadığını kontrol etmek için.


#### Rigidbody2D ne anlama gelir?

Gerçek dünyadaki gibi fiziksel hareketleri simüle etmek için Unity fizik motorunu kullanır. karakterinize Rigidbody2D (bileşen) eklemeniz gerekir.

"rb = GetComponent<Rigidbody2D>();" - Bununla oluşturduğumuz rb değişkenini Unity'deki rigidbody2D'ye bağlıyoruz.

#### OnCollisionEnter2D ne anlama geliyor?

Bir nesne başka bir nesneye dokunduğunda mesaj göndererek çalışan bir fonksiyondur.

DİKKAT:Trambolin fonksiyonunun doğru çalışması için trambolininizin etiketini unity'de "trampoline" yapmanız gerekir.
## Yazar

- Efe Baydoğan tarafından oluşturuldu.
