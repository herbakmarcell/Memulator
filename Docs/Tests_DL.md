## Általános mód tesztelés
 | Teszteset               | Elvárt eredmény                                                                                                     | 
 |-------------------------|---------------------------------------------------------------------------------------------------------------------| 
 | Szám gomb(0-9) megnyomása | Alsó szövegdobozba megjelenik a szám. |
 | Kéttagú művelet gomb megnyomása (+, -, *, /, pow) | Az alsó szövegdobozban lévő szám felülre kerül, el lesz tárolva a memóriába és műveleti állapotba kerül a program. | 
 | Egytagú műveletek gomb megnyomása | Az alsó szövegdobozban lévő számra a művelet végrehajtódik, el lesz tárolva a memóriába és műveleti állapotba kerül a program. | 
 | Ismételt kéttagú műveletgomb megnyomása | A memória felülíródik a kívánt művelet végrehajtásával. | 
 | Eredmény kiíratása (=)| A műveleti állapotban a művelet végrehajtódik, ellenkező esetben a memória az első bevitt szám lesz. |
 | Negáló gomb (+/-) megnyomása | A szám ellentétes előtagú megfelelőjévé változik. |
 | Exit gomb megnyomása | A program jóváhagyásra kilép. |
 | Pont gomb megnyomása | A szövegdobozban megjelenik a pont karakter, több nem jelenhet meg. |
 | All clear gomb megnyomása | A memória és műveleti állapot alaphelyzetbe állítása. |
 | Del gomb megnyomása | Legutolsó bevitt karakter, törlésre kerül a szövegdobozból. Ha üres lenne, 0 kerül a szövegdobozba. | 
 | Mode gomb megnyomása | A program Meme módba kapcsol. A kinézete és eredmény megjelenítési funkciók megváztoznak. Lásd Meme mód specifikus tesztelések. |

 ## Meme mód specifikus tesztelés
 | Teszteset               | Elvárt eredmény                                                                                                     | 
 |-------------------------|---------------------------------------------------------------------------------------------------------------------| 
 | Meme eredmények megjelenítése | A megadott eredményekhez tartozó kép és hanganyagok megjelenítése. |
 | Exit gomb megnyomása | A program nem lép ki, helyette képet és hangot játszik le. |
 | Kínai gomb megnyomása | Képet és hangot játszik le. | 
 | Pizza time gomb megnyomása | Felugró ablakot jelenít meg, amely ki be kapcsolja a "pizza time" módot és hangot játszik le. | 
 | Pizza gomb megnyomása | Megállít minden folyamatot, majd képet és hangot játszik le. |
 | Mode gomb megnyomása | A program Általános módba kapcsol. A kinézete és eredmény megjelenítési funkciók megváztoznak. Lásd Általános mód tesztelés. |

 ### Ezeket a teszteseteket végrehajtani a legtöbb kombinációval

 Tesztelő: Détári Levente
Tesztelés dátuma: 2023.október.10.

| Tesztszám | Rövid leírás                     | Várt eredmény                                                                   | Eredmény                                                                       | Megjegyzés                |
|-----------|----------------------------------|---------------------------------------------------------------------------------|--------------------------------------------------------------------------------|---------------------------|
| Teszt #01 | Szám gomb (0-9) megnyomása | Alsó szövegdobozban megjelenik a szám/megjelennek a számok. | Gombok műveletei sikeresen lefutnak, és megjelennek az alsó  szövegdobozban. Az alap 0 szám átíródik, kivétel a nulla megnyomásakor  | Nem találtam problémát. |
| Teszt #02 | Kéttagú művelet gomb megnyomása (+, -, *, /, pow) | Az alsó szövegdobozban lévő szám/számok felülre kerülnek, el lesz tárolva a memóriában és műveleti állapotba kerül a program. | Gombok műveletei sikeresen lefutnak, Felső szövegdobozban megjelent a szám/megjelentek a számok. | Nem találtam problémát. |
| Teszt #03 | Egytagú műveletek gomb megnyomása | Az alsó szövegdobozban lévő számra a művelet végrehajtódik, el lesz tárolva a memóriában és műveleti állapotba kerül a program. | Művelet végrehajtódik. Felső szövegdobozban megjelent a szám/megjelentek a számok. | Nem találtam problémát. |
| Teszt #04 | Ismételt kéttagú műveletgomb megnyomása | A memória felülíródik a kívánt művelet végrehajtásával. | Az első művelet lefut, a bevitt szám felülre kerül, ha nem adunk meg ezután számot, a második műveleti gomb megnyomásától az alap nulla értékkel végződik el a művelet, számbevitel esetén a bevitt szám és a felső memóriában lévő számmal fut le a művelet. | Nem találtam problémát. |
| Teszt #05 | Eredmény kiíratása (=) | A műveleti állapotban a művelet végrehajtódik, ellenkező esetben a memória az első bevitt szám lesz. | Művelet  végrehajtódik. Műveleti állapotban a felső szövegdobozban megjelenik a művelet értéke, más esetben az alsó szövegdoboz értéke elmentődik a memőriába, és kiiratódik felül | Nem követi a művelet végrehajtást! Prioritás: alacsony |
| Teszt #06 | Negáló gomb (+/-) megnyomása | Alsó szövegdobozban megjelenik/eltűnik az előjel. | Művelet végrehajtódik. Alsó szövegdobozban megjelent/eltűnt az előjel, nulla esetén nem változik az előjel. | Nem találtam problémát. |
| Teszt #07 | Exit gomb megnyomása | A program jóváhagyásra kilép. | Művelet végrehajtódik. igen-re program kilépett, nem-re visszakerülünk a fő képernyőre. | Nem találtam problémát. |
| Teszt #08 | Pont gomb megnyomása | A szövegdobozban megjelenik a pont karakter több nem jelenhet meg. | A szövegdobozban megjelent a pont karakter, több nem jelent meg. | Nem találtam problémát. |
| Teszt #09 | All clear gomb megnyomása | A memória és műveleti állapot alaphelyzetbe állítása. | Művelet végrehajtódik. A program alaphelyzetbe kerül. | Nem találtam problémát. |
| Teszt #10 | Del gomb megnyomása | Legutolsó bevitt karakter, törlésre kerül a szövegdobozból. Ha üres lenne, 0 kerül a szövegdobozba. | Művelet végrehajtódik. Legutolsó bevitt karakter, törlésre került a szövegdobozból. Amikor üres volt, 0 került a szövegdobozba, pontra is működik. | Nem találtam problémát. | 
| Teszt #11 | Mode gomb megnyomása | A program Meme módba kapcsol. A kinézete és eredmény megjelenítési funkciók megváztoznak. | Művelet végrehajtódik. A program Meme módba kapcsolt. A kinézete és eredmény megjelenítési funkciók megváztoztak, hangok lejátsződnak, ismételt megnyomásra abbamaradnak. | Nem találtam problémát. |
| Teszt #12 | Meme eredmények megjelenítése | A megadott eredményekhez tartozó kép és hanganyagok megjelenítése. | Műveletek végrehajtódnak. Az eredményekhez kapcsolódó média lejátszódik, egymás utáni bevitel esetén a régebbi abbamarad, az új játsződik csak. | Nem találtam problémát. |
| Teszt #13 | Exit gomb megnyomása Meme módban | A program nem lép ki, helyette képet és hangot játszik le. | Művelet végrehajtódik. A média lejátszódott. | Nem találtam problémát. |
| Teszt #14 | Kínai gomb megnyomása | Képet és hangot játszik le. | Művelet végrehajtódik. A média lejátszódott, ismételt megnyomásra újrakezdődik. | Nem találtam problémát. |
| Teszt #15 | Pizza time gomb megnyomása | Felugró ablakot jelenít meg, amely ki-be kapcsolja a "pizza time" módot és hangot játszik le. | Művelet végrehajtódik. A felugró ablak működött, a hang lejátszódott, a pizza time módot ki-be tudja kapcsolni. | Nem találtam problémát. |
| Teszt #16 | Pizza gomb megnyomása | Megállít minden folyamatot, majd képet és hangot játszik le. | Művelet végrehajtódik. Minden a szálon futó műveletet megállított és lejátszotta a kapcsolódó médiát. | Nem találtam problémát. |
| Teszt #17 | Mode gomb megnyomása | A program Általános módba kapcsol. A kinézete és eredmény megjelenítési funkciók megváztoznak. | Művelet végrehajtódik. A program Általános módba kapcsolt. A kinézete és eredmény megjelenítési funkciók megváztoztak.  | Nem találtam problémát. |
