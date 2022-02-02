# Test rekrutacyjny - CSS

Przygotowanie strony na podstawie dołączonych designów zgodnie z poniższymi wytycznymi:

1. Mobile first
2. Kod zapisany musi zostać w formacie SCSS
3. Wykorzystane muszą być:
    - Zmienne CSS dla wszystkich kolorów
    - Zmienne SCSS dla wszystkich paddingów i marginów
    - Stan (np. aktywny element menu) za pomocą atrybutu typu `data-*` (np. `data-is-active="true"`)
    - Media queries
    - Minimalnie jeden Mixin
    - Metodyka BEM
4. Strona musi być responsywna tj.:
    - Strona musi dobrze wyglądać niezależnie od rozmiaru urządzenia (przy założeniu, że minimum szerokości to 320px)
    - Strona musi posiadać różnice w wyglądzie zależnie od szerokości wyświetlania (breakpointy):
	- Mobile: min. 320px, max. 767px
 	- Tablet: min. 768px, max. 1024px
        - Desktop: min. 1025px, max. nieskończność
5. Elementy interaktywne (przyciski, linki etc.) muszą posiadać prawidłowe przejścia z zastosowaniem transiton
6. Założenia wstępne dot. testowego projektu:
    - Font - Open Sans (z użyciem Google Fonts)
    - Ikony - Feather Icons (https://feathericons.com/) - uwaga, trzeba tutaj znaleźć zamienniki pasujące do designu, w wypadku braku takiej lub podobnej ikonki, można wziąć inną, zastępczą
    - Zdjęcia - Lorem Picsum (https://picsum.photos/) - z wykorzystaniem tej strony, trzeba podlinkować losowe zdjęcia w odpowiednich rozmiarach w potrzebnych miejscach
7. Project trzeba dostarczyć w formie projektu na GitHub
8. W ramach projektu muszą znajdować się pliki HTML, SCSS oraz skompilowane w sposób dowolny pliki CSS potrzebne do podglądu HTML

PS projekt nie jest naszego autorstwa, został wykorzystany wyłącznie na potrzeby rekrutacyjne
