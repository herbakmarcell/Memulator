## Általános mód tesztelés
 | Teszteset               | Elvárt eredmény                                                                                                     | 
 |-------------------------|---------------------------------------------------------------------------------------------------------------------| 
 | Szám gomb (0-9) megnyomása | Alsó szövegdobozba megjelenik a szám. Ha 0 az első, felülíródik, több 0 nem kerülhet, ha az első karakter 0.|
 | Kéttagú művelet gomb megnyomása (+, -, *, /, pow) | Az alsó szövegdobozba lévő szám felülre kerül, el lesz tárolva a memóriába és műveleti állapotba kerül a program. | 
 | Egytagú műveletek gomb megnyomása | Az alsó szövegdobozba lévő számra a művelet végrehajtódik, el lesz tárolva a memóriába és műveleti állapotba kerül a program. | 
 | Ismételt kéttagú műveletgomb megnyomása | A memória felülíródik a kívánt művelet végrehajtásával. | 
 | Eredmény kiíratása (=)| A műveleti állapotban a művelet végrehajtódik, ellenkező esetben  a memória az első bevitt szám lesz. |
 | Negáló gomb (+/-) megnyomása | A szám ellentétes előtagú megfelelőjévé változik. |
 | Exit gomb megnyomása | A program jóváhagyásra kilép. |
 | Pont gomb megnyomása | A szövegdobozba megjelenik a pont karakter több nem jelenhet meg. |
 | All clear gomb megnyomása | A memória és műveleti állapot alaphelyzetbe állítása. |
 | Del gomb megnyomása | Legutolsó bevitt karakter, eltűnik a szövegdobozbol. | 
 | Mode gomb megnyomása | A program Meme módba kapcsol. A kinézete és eredmény megjelenítési funkciók megváztoznak. Lásd Meme mód specifikus tesztelések. |

 ## Meme mód specifikus tesztelés
 | Teszteset               | Elvárt eredmény                                                                                                     | 
 |-------------------------|---------------------------------------------------------------------------------------------------------------------| 
 | Meme eredmények megjelenítése | A megadott eredményekhez tartozó kép és hanganyagok megjelenítése |
 | Exit gomb megnyomása | A program nem lép ki, helyette képet és hangot játszik le. |
 | Kínai gomb megnyomása | Képet és hangot játszik le. | 
 | Pizza time gomb megnyomása | Felugró ablakot jelenít meg, amely ki be kapcsolja a "pizza time" módot és hangot játszik le. | 
 | Pizza gomb megnyomása | Megállít minden folyamatot, majd képet és hangot játszik le. |
 | Mode gomb megnyomása | A program Általános módba kapcsol. A kinézete és eredmény megjelenítési funkciók megváztoznak. Lásd Általános mód tesztelés. |

 ### Ezeket a teszteseteket végrehajtani a legtöbb kombinációval

Tesztelő: Herbák Marcell
Tesztelés dátuma: 2023. október. 09. 21:30
| Tesztszám | Rövid leírás                     | Várt eredmény                                                                   | Eredmény                                                                       | Megjegyzés                |
|-----------|----------------------------------|---------------------------------------------------------------------------------|--------------------------------------------------------------------------------|---------------------------|
| Teszt #01 | Szám gomb (0-9) megnyomása | Alsó szövegdobozba megjelenik a szám. Ha 0 az első, felülíródik, több 0 nem kerülhet, ha az első karakter 0. | Alsó szövegdobozba megjelent a szám. | Nem találtam problémát. |
| Teszt #02 | Kéttagú művelet gomb megnyomása (+, -, *, /, pow) | Az alsó szövegdobozba lévő szám felülre kerül, el lesz tárolva a memóriába és műveleti állapotba kerül a program. | Művelet  végrehajtódik. Felső szövegdobozba megjelent a szám. | Nem találtam problémát. |
| Teszt #03 | Egytagú műveletek gomb megnyomása | Az alsó szövegdobozba lévő számra a művelet végrehajtódik, el lesz tárolva a memóriába és műveleti állapotba kerül a program. | Művelet  végrehajtódik. Felső szövegdobozba megjelent a szám. | Nem találtam problémát. |
| Teszt #04 | Ismételt kéttagú műveletgomb megnyomása | A memória felülíródik a kívánt művelet végrehajtásával. | Művelet  megváltozik. A következő alkalommal a kiválasztott művelet fut le. | Nem találtam problémát. |
| Teszt #05 | Eredmény kiíratása (=) | A műveleti állapotban a művelet végrehajtódik, ellenkező esetben  a memória az első bevitt szám lesz. | Alsó szövegdobozba megjelent a szám. | Nem találtam problémát. |
| Teszt #06 | Negáló gomb (+/-) megnyomása | A szám ellentétes előtagú megfelelőjévé változik. | A szám előtt megjelent a '-'. | Nem követi a művelet végrehajtást! |
| Teszt #07 | Exit gomb megnyomása | A program jóváhagyásra kilép. | A program jóváhagyásra kilépett. | Nem találtam problémát. |
| Teszt #08 | Pont gomb megnyomása |A szövegdobozba megjelenik a pont karakter több nem jelenhet meg. | A pont megjelent, több pont bevitel nem történhetett. | Nem találtam problémát. |
