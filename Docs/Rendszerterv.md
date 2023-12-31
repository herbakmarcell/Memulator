## 1. A rendszer célja

A Kézifék E. Inc. azt a megbízást kapta, hogy segítsék a kisiskolásokat a számológép használatának könnyebb elsajátítására játékos funkciókkal, ezzel segítve a tanárok és szülők munkáját. Annak érdekében, hogy felkeltsük az érdeklődésüket a számológép használatához, a tanulóknak szórakoztató, figyelem lekötő és önfejlesztő lehetőségeket biztosító szoftvert kell készíteni, ezáltal válik szórakoztatóvá a felhasználó számára a számológép használata. A rendszer alapköve az átlagos számológép funkcióinak felfrissítése és kibővítése az aktuális trendek és média felhasználásával. Az aktuál média bevonása még erősebbé teszi a szoftver és a felhasználó közötti kapcsolatot. Lehetőséget ad a generációk közötti különbségek csökkentésére is, hiszen a fejlesztett és bővitett változat mellett retro, konzervatív számológépként is tud funkcionálni.

## 2. Projektterv
   
### 2.1 Projektszerepkörök, felelőségek
* Scrum master:
	-   Kaponya Martin 	
* Product owner:
	-   Kaponya Martin 
* Üzleti szereplő:
	-   Megrendelő:
		 -  Bagoly Gábor
   
### 2.2 Projektmunkások és felelőségek
   		
* Frontend:
	-   Détári Levente
	-   Fodor Győző Benedek
* Backend:  
	-   Herbák Marcell
	-   Pántya Barnabás
	-   Détári Levente
* Tesztelés:   
	-   Herbák Marcell
	-   Pántya Barnabás
	-   Détári Levente
	-   Fodor Győző Benedek
  
### 2.3 Ütemterv
|Funkció                  | Feladat                   | Prioritás | Becslés (nap) | Aktuális becslés (nap) | Eltelt idő (nap) | Határidő (nap) |
|-------------------------|---------------------------|-----------|---------------|------------------------|------------------|---------------------|
|Követelmény specifikáció |Megírás                    |         1 |             1 |                      1 |                1 |                   1 |             
|Funkcionális specifikáció|Megírás                    |         1 |             1 |                      1 |                1 |                   1 |
|Rendszerterv             |Megírás                    |         1 |             1 |                      1 |                1 |                   1 |
|Program                  |Vizuális tervek elkészítése|         2 |             1 |                      1 |                1 |                   1 |
|Program                  |Prototípus elkészítése     |         3 |             5 |                      5 |                0 |                   5 |
|Program                  |Alapfunkciók elkészítése   |         3 |             5 |                      5 |                0 |                   5 |
|Program                  |Extra funkciók elkészítése |         3 |             7 |                      7 |                0 |                   7 |
|Program                  |Tesztelés                  |         4 |             2 |                      2 |                0 |                   2 |

   
### 2.4 Mérföldkövek
   *   09.24. Követelmény specifikáció elkészítése
   *   09.27. Funkcionális specifikáció elkészítése
   *   09.30. Rendszerterv elkészítése
   *   10.07. Back- és Front-end elkészítése
   *   10.08. Előzetes tesztelések és prototípus elkészítése
   *   10.11. Prototípus prezentálása
   
## 3. Üzleti folyamatok modellje

![tanuló hozzáadó felület](../Img/business.png)

### 3.1 Üzleti szereplők

A szoftver használatához nincs szükség regisztrációra. A telepítést követően a szoftver bármely felhasználó számára elérhető, teljes egészében az összes
funkcióval.
   
### 3.2 Üzleti folyamatok

A program indulását követően a felhasználó azonnal használhatja a számológép minden funkcióját. A felhasználó választhat a számológép különböző módjai között, ezek a szórakoztató és a hagyományos.
   
## 4. Követelmények

 ### Követelménytáblázat

 | ID | Modul | Név | Kifejtés |
 | :---: | --- | --- | --- |
 | K1  | Felület | Összeadás  | Számok összeadása. |
 | K2  | Felület | Kivonás  | Számok kivonása. |
 | K3  | Felület | Szorzás  | Számok szorzása. |
 | K4  | Felület | Osztás  | Számok osztása. |
 | K5  | Felület | Gyökvonás | Számok gyökei. |
 | K6  | Felület | Törlés  | Törlés a képernyőről |
 | K7  | Felület | Nullázás | Az összes szám törlése a képernyőről |
 | K8  | Felület | Eredmény | Az művelet eredményének kiíratása a képernyőre |

### Funkcionális
  
  - Egyszerűbb matematikai műveletek elvégzése
  - A folyamat alatt az eredmények tárolása
  - Megakadályozni, hogy a felhasználó érvénytelen adatot adjon meg

### Nem Funkcionális

  - Gyorsnak és átláthatónak kell lennie
  - Úgy érezze a felhasználó mintha gyorsabb fejben vagy papíron való számolás helyett a műveletek megoldása.
  - Úgy nézzen ki a program mintha, nem 15 éve fejlesztették volna.
   
## 5. Funkcionális terv
    
### 5.1 Rendszerszereplők

A rendszer, helyileg a felhasználó számítógépén, internetre való kapcsolódás nélkül fut. Egyetlen egy jogosultsági kör van, ezért a felhasználók között
nem teszünk különbséget.
   
### 5.2 Menü-hierarchia:
* Interface:
	- Kijelző megjelenítése mely a jelenlegi eredményt mutatja
	- Gombok melyek a reláció beírásához szükségesek(Számok 0-9, operátorok)
	- Gombok a program kezelésére(tálcára rakás, bezárás)
	- Gomb a kijelző megjelenítésére
   
## 6. Fizikai környezet

### Vásárolt szoftverkomponensek, valamint esetleges külső rendszerek
Nincsenek vásárolt szoftverkomponensek.
### Hardver topológia
32 bites Windows-ra készült, ezért a 64 bites is képes a futtatására.
### Fizikai alrendszerek
Kliens gépek: A követelményeknek megfelelő, Windows-ra alkalmas PC-k, amin telepítve van a .Net keretrendszer.
### Fejlesztő eszközök
Visual Studio 2022
    
## 7. Architekturális terv

A program futásához nem szükséges webhez vagy adatbázisrendszerhez való csatlakozás.

Az alkalmazás a felhasználó számítógépén tud futni, amennyiben rendelkezik .Net keretrendszerrel. A szoftver futtatásához kétszer rá kell kattintani az állományra
vagy a program parancsikonjára.
    
## 8. Adatbázis terv

Az alkalmazásunkhoz nincs szükség adatbázisra, azonban előfordulhat, hogy tárolni kell helyi fájlokat, ebben az esetben a felhasználó számítógépén történik a tárolás.

## 9. Implementációs terv

 * A felhasználói felület - WindowsForms alkalmazás.
 * A program .NET keretrendszert használ, lehetővé téve az alkalmazás egyszerű futtatását, indítását.
    
## 10. Tesztterv

A rendszerterv szerint implementált szoftver tesztelésének célja az Üzleti folyamatok modellje című pontban meghatározott folyamatok helyes, gördülékeny lefutása.

A tesztelés során használt kliens hardverek a napjainkban általánosan elterjedt hardverkonfigurációjú PC-k illetve laptopok.
A minimum hardverkonfiguráció: Intel Celeron processzor, 4GB RAM, 128GB HDD, a képernyők felbontása 1280x1024 vagy 1920x1080.

A tesztelés során a szoftver megfelelő működését vizsgáljuk. Amennyiben az elvártnak megfelelő eredményt kapunk, a teszt eset sikeresnek tekinthető, ellenkező 
esetben a hibát rögzítjük a teszt jegyzőkönyvben. Ezt követően a megtalált hibákat javítjuk a szoftverben, és újbóli tesztelésnek vetjük alá a rendszert.

## 11. Telepítési terv

Fizikai telepítési terv: A számológép nem csatlakozik adatbázishoz, webszerverhez és internethez, csak a számítógépen kell futtatni.

Szoftver telepítési terv: Szükségünk van egy 32-bites Windows-t futtató számítógépre, hogy futtathassuk a programot.
    
## 12. Karbantartási terv

Az alkalmazásnak nincs szüksége különösebb karbantartásra, új funkció hozzáadása esetén opcionális frissítést teszünk elérhetővé a felhasználó számára.
