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


