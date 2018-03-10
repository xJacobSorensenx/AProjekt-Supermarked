# AProjekt-Supermarked
Shopping komponenten


actions:

login
logout
se oversigt over varerkategorier (grønt, kød, dessert, vin osv.)
se alle varer i en specifik kategori
overfører x-antal specifik vare til kurven (læg i kurven)
se alle vare i kurven
fjerne x-antal vare fra kurven
checke ud (gå til betaling)
se liste med subtotaler for samtligevare i kurven
se total for samtlige varer i kurven
acceptere køb (færdigbehandl indkøb)

vise en profil side (avatar navn, login/passw adresse tlf. osv)
se udestående 
(se historik )
redigere oplysnigner på profilside

tilbage melding til supermarked (ris/ros side - forslag til varesortiment osv.)


administration:
tilføje ny varer
fjerne en varer
ændre prisen på en vare



modeller:
Kunde:
-id (int)
-brugernavn (string)
-password (pw/string)
-kurv (liste af vare)
-historik(liste af indkøb)

vare:
-id(int)
-navn(string)
-pris(int)
-beskrivelse(string)


Supermarked:
-inventar (liste af vare)
(der skal oprettes en komplex type der indeholde en vare samt en int til at bestemme antallet af vare)

Historik:
-indkøb (liste af vare)
-dato 
-betalt (bool)








