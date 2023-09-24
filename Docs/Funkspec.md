# Funkcionális Specifikáció
## 1. Jelenlegi helyzet

Jelenleg unalmas, egyszerű számológépeket használnak a fiatalok, ezért szeretnénk ezeket lecserélni, és saját, könnyen használhatóakkal helyettesíteni, amely
szórakoztató és optimális a feladat elvégzésére. Ezzel megkönnyítve a tanárok, szülők dolgát azzal, hogy a fiatalok szívesebben használják a számológépet.

## 2. Vágyálom rendszer

A projekt célja, hogy optimális és egyben szórakoztató számológép jöjjön létre a fiatalok számára. A számológépnek egyszerűnek, és könnyen használhatónak kell
lennie. Az alkalmazás funkciói: Összeadás, kivonás, szorzás, osztás, hatványozás, gyökvonás, a hagyományos számológépen látható DEL illetve AC jelzésű gombok.

## 3. Jelenlegi üzleti folyamatok modellje

A számológépünk nem sokkal különbözik az alapmodelltől, műveletei tartalmazzák:

-   Összeadás
-   Kivonás
-   Szorzás
-   Osztás
-   Gyökvonás
-   Négyzetre emelés
- 	Kijelzőn lévő adatok törlése

## 4. Igényelt üzleti folyamatok modellje

Egy olyan szoftver, amely alkalmas a szórakoztató, optimális tanulásra, munkavégzésre. Használata közben a szoftver képes hangok lejátszására, képek
megjelenítésére.

## 5. Követelménylista

| ID  | Név | Kifejtés |
| ------------- | ------------- | ------------- |
| 1  | Összeadás  | Számok összeadása. |
| 2  | Kivonás  | Számok kivonása. |
| 3  | Szorzás  | Számok szorzása. |
| 4  | Osztás  | Számok osztása. |
| 5  | Gyökvonás | Számok gyökei. |
| 6  | Törlés  | Törlés a képernyőről |
| 7  | Nullázás | Az összes szám törlése a képernyőről |
| 8  | Eredmény | A művelet eredményének kiíratása a képernyőre. |

## 6. Használati esetek

1. Felhasználó számolása: A felhasználó a képernyőablakon megjelenő gombok segítségével ki tudja választani, hogy melyik matematikai műveletet szeretné elvégezni.
2. Eredmény kiírása a képernyőre: A program a háttérben a felhasználó által meghívott matematikai műveletet végrehajtja.

## 7. Megfeleltetés, hogyan fedik le a használati eseteket a követelményeket

1: A felhasználó a második szám kiválasztása előtt rákattint az összeadás (+) gombra. Ezzel jelezve a rendszernek, hogy a két szám összegét szeretnénk megkapni.
2: A felhasználó a második szám kiválasztása előtt rákattint a kivonás (-) jelre. Ezzel jelezve a rendszernek, hogy az első számból ki szeretnénk vonni a másodikat.
3: A felhasználó a második szám kiválasztása előtt rákattint a szorzás (*) jelre. Ezzel jelezve a rendszernek, hogy a két szám szorzatát szeretnénk megkapni.
4: A felhasználó a második szám kiválasztása előtt rákattint az osztás (/) jelre. Ezzel jelezve a rendszernek, hogy az első számot el szeretnénk osztani a második számmal.
5: A felhasználó a második szám kiválasztása előtt rákattint a gyökvonás (√) jelre. Ezzel jelezve a rendszernek, hogy az első számnak a második számú gyökét szeretnénk megkapni.
6. A felhasználó rákattinthat a törlés (DEL) gombra. Ekkor a legutolsó karakter törlésre kerül a képrenyőről.
7. A felhasználó rákattinthat a nullázás (AC) gombra. Ekkor az összes szám törlésre kerül a képernyőről.
8. A felhasználó bármikor rákattinthat az eredmény (=) gombra. Ekkor az aktuális számolási folyamat eredményét kiírja a kijelzőre.
