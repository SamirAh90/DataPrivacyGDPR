Här är en professionellt formulerad README.md för ditt GitHub-projekt, baserat på texten du gav:

---

# Bevisinsamling mot olaglig datainsamling (C#)

## 📌 Introduktion

Detta projekt är del av ett större arbete som syftar till att hjälpa företaget *Angelic Good Guys Inc.* att samla bevis mot *Evil Eavesdrop Enterprises (EEE)* – ett företag som misstänks bryta mot GDPR genom olaglig insamling av persondata.

Syftet med laborationen var att utveckla ett system som kan simulera och demonstrera hur sådan datainsamling kan gå till, med målet att stärka bevisningen mot EEE. Arbetet är utfört i **C#**, där objektorienterade principer tillämpats för att skapa ett strukturerat och funktionellt system med hjälp av `enum`, `struct` och `class`.

Laborationen gav praktisk erfarenhet av:

* Agilt arbetssätt
* Objektorienterad programmering
* Etiskt kodåterbruk
* Bättre referenshantering enligt APA

---

## ⚙️ Metod

### 🛠 Verktyg

* **Visual Studio 2022 (v17.0)**
* **.NET 6.0**
* Kod från tidigare labbar, t.ex.:

  * *WeatherSenseApplication*, Lab 3 (Ahmad & Lindfors, 2024)

### 📋 Steg-för-steg

1. Analyserade uppgiften och skapade pseudokod + flödesschema
2. Delade arbetet i mindre steg:

   * `enum` för kön
   * `struct` för hår
   * `class` för person
   * `override` på `ToString()` för korrekt utskrift
3. Instansierade person-objekt och lagrade dem i en lista
4. Byggde meny med `while` och `switch`
5. Implementerade metoder för att lägga till och lista personer
6. Utförde omfattande testning vid varje steg

### 🧠 Förkunskaper

För att genomföra projektet behövdes:

* Grundläggande kunskaper i C# och OOP
* Förståelse för datastrukturer
* Tidigare erfarenhet från liknande projekt (Lab 3)

### ✅ Testning

Koden testades kontinuerligt:

* Giltig och ogiltig input
* Datumvalidering (ej framtidsdatum, ej år före 1900)
* Felhantering vid hårfärg, kön och längd
* Användning av `override` för korrekt `ToString()`-utskrift

---

## 📈 Resultat

Projektet uppfyllde alla krav i labbinstruktionen. Vi stötte på utmaningar med att:

* Kombinera `enum`, `struct` och `class`
* Hantera input-validering
* Lösa utskriftsproblem, vilket krävde en `override` av `ToString()`

### Lärdomar:

* Tydlig struktur underlättar felsökning
* Återanvändning av kod sparar mycket tid
* Testning är avgörande för kvalitet och robusthet

---

## 💬 Diskussion & Reflektion

Vi har utvecklat både teknisk och praktisk kompetens:

* Bättre förståelse för OOP och datastrukturer
* Insikter om vikten av dokumentation och kodstruktur
* Erfarenhet av agilt arbete och sprintplanering

### Sprint 1:

* Gick smidigt, men pausen inför Sprint 2 ledde till att vi tappade fart

### Sprint 2:

* Mer komplex: krävde djupare förståelse av datastrukturer
* Override på `ToString()` blev lösningen på flera problem

### Alternativa lösningar:

* Projektet skulle kunna vidareutvecklas i t.ex. Windows Forms, men vi hade inte tillräcklig kunskap i nuläget.

---

## 🧠 Frågor till AI-verktyg

| Verktyg | Fråga                                            | Användning                                                    |
| ------- | ------------------------------------------------ | ------------------------------------------------------------- |
| ChatGPT | Vad är skillnaden mellan enum, struct och klass? | Förstod syfte och användningsområden                          |
| ChatGPT | Varför använda `override`?                       | Användes för att lösa problem med objektutskrift              |
| ChatGPT | Tips vid testning av kod?                        | Hjälpte oss skapa en stabil inmatningsvalidering              |
| ChatGPT | Vad betyder `?` i C#?                            | Förstod nullable types, vilket hjälpte oss hantera null-input |

---

## 📚 Referenser

* Troelsen, A., & Japikse, P. (2022). *Pro C# 10 with .NET 6*. APress.
* Vision. (n.d.). *Guide: Så leder du agilt*. [https://vision.se/chef/amnen/agilt-ledarskap/guide-sa-leder-du-agilt/](https://vision.se/chef/amnen/agilt-ledarskap/guide-sa-leder-du-agilt/)
* Panjuta, D. (n.d.). *Complete C# masterclass*. Udemy.
* Ahmad, S., & Lindfors, L. (2024). *WeatherSenseApplication*, Lab 3.
* Stack Overflow: [https://stackoverflow.com/questions/59524568/](https://stackoverflow.com/questions/59524568/)
* Reddit: [https://www.reddit.com/r/csharp/comments/1682yux/](https://www.reddit.com/r/csharp/comments/1682yux/)

---

Vill du att jag genererar en README.md-fil du kan ladda ner och använda direkt i ditt repo?
