1. A rendszer célja

	A rendszer célja a manapság használt elavult számológép formátum felfrissítése. Szeretnénk közelebb hozni a fiatalabb generációkat a számológép használathoz és megismertetni az emberekkel a számológépek jövőjét. Emellett a rendszer segítené a tanulók, tanárok és szülők munkáját. A tanulóknak szórakoztató, figyelem lekötő és önfejlesztő lehetőségeket biztosít. A rendszer alapköve az átlagos számológép funkcióinak felfrissítése és kibővítése az aktuális trendek és média felhasználásával. Az aktuál média bevonásával még erősebbé tennénk a termék és a felhasználók közötti kapcsolatot. Lehetőséget ad a generációk közötti különbségek csökkentésére is, hiszen a fejlesztett és bővitett változat mellett retro, konzervatív számológépként is tud majd funkcionálni.
2. Projektterv
   
	2.1 Projektszerepkörök, felelőségek
	-   Srcum master:
	-   Product owner: Dr. Tajti Tibor Gábor
	-   Üzleti szereplő:
		-   Megrendelő: Dr. Tajti Tibor Gábor
   
	2.2 Projektmunkások és felelőségek
   		
	-   Frontend:
		-   Détári Levente
		-   Fodor Győző Benedek
	-   Backend:  
		-   Herbák Marcell
		-   Pántya Barnabás
		-   Détári Levente
	-   Tesztelés:   
		-   Herbák Marcell
		-   Pántya Barnabás
		-   Détári Levente
		-   Fodor Győző Benedek
  
	2.3 Ütemterv
   
	2.4 Mérföldkövek
   	-   Prototípus prezentálása
   
4. Üzleti folyamatok modellje
   
	3.1 Üzleti szereplők
   
	3.2 Üzleti folyamatok
   
## 5. Követelmények
  ### Funkcionális
    - Egyszerűbb matematikai műveletek elvégzése
    - A folyamat alatt az eredmények tárolása
    - Megakadályozni, hogy a felhasználó érvénytelen adatot adjon meg

### Nem Funkcionális 
	- Gyorsnak és átláthatónak kell lennie
	- Úgy érezze a felhasználó mintha gyorsabb fejben vagy papíron való számolás helyett a műveletek megoldása.
	- Úgy nézzen ki a program mintha nem 15 éve fejlesztették volna amikor csak szögletes kis windows programok voltak.
   
7. Funkcionális terv
    
	5.1 Rendszerszereplők
   
	### 5.2 Menü-hierarchia:
* Interface:
	- Kijelző megjelenítése mely a jelenlegi eredményt mutatja
	- Gombok melyek a reláció beírásához szükségesek(Számok 0-9, operátorok)
	- Gombok a program kezelésére(tálcára rakás, bezárás)
	- Gomb a kijelző megjelenítésére
   
8. Fizikai környezet
    
9. Architekturális terv
    
## 10. Adatbázis terv

Az alkalmazásunkhoz nincs szükség adatbázisra, azonban előfordulhat, hogy tárolni kell helyi fájlokat, ebben az esetben a felhasználó számítógépén történik a tárolás.

11. Implementációs terv
    
## 12. Tesztterv

A rendszerterv szerint implementált szoftver tesztelésének célja az Üzleti folyamatok modellje című pontban meghatározott folyamatok helyes, gördülékeny lefutása.

A tesztelés során használt kliens hardverek a napjainkban általánosan elterjedt hardverkonfigurációjú PC-k illetve laptopok.
A minimum hardverkonfiguráció: Intel Celeron processzor, 4GB RAM, 128GB HDD, a képernyők felbontása 1280x1024 vagy 1920x1080.

A tesztelés során a szoftver megfelelő működését vizsgáljuk. Amennyiben az elvártnak megfelelő eredményt kapunk, a teszt eset sikeresnek tekinthető, ellenkező 
esetben a hibát rögzítjük a teszt jegyzőkönyvben. Ezt követően a megtalált hibákat javítjuk a szoftverben, és újbóli tesztelésnek vetjük alá a rendszert.

13. Telepítési terv
    
## 14. Karbantartási terv

Az alkalmazásnak nincs szüksége különösebb karbantartásra, új funkció hozzáadása esetén opcionális frissítést teszünk elérhetővé a felhasználó számára.
