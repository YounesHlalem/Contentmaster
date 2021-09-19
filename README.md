# Integrated teamproject .NET: Content master

## Kadering project 
E4Progress is een e-learning platform toegespitst op het leren werken met de meest courante Office pakketten. Centraal staan de oefenbundels (quizzen) die studenten op hun eigen computer kunnen uitvoeren en onmiddellijk verbeterd worden. 

Het uitwerken van een oefenbundel vereist niet alleen creativiteit, maar ook een didactische 
onderbouwing. Al deze ontwerpinfo wordt momenteel in documenten bewaard. De bedoeling is om 
deze info in een database te kunnen beheren via een gebruiksvriendelijke 
gebruikersinterface i.p.v. het gebruik van dergelijke documenten.

## Use cases
### 1. Aanmelden:

Als een gebruiker van de app wil ik bij het opstarten van de app een dialoogscherm te zien krijgen 
waarop ik mijn gebruikersnaam en wachtwoord kan ingeven. 
 
Wanneer gebruikersnaam en of wachtwoord foutief zijn moet daarvoor een aangepaste boodschap 
verschijnen. Wanneer succesvol wordt aangemeld verdwijnt het dialoogscherm en wordt het 
startscherm van de app getoond. 

### 2. Startscherm van de app 

Het hoofdscherm toont aan de linkerkant een menubalk. 
De menubalk moet volgende structuur voorzien (3 main topics met daaronder submenu-items): 
 
1. **Inhoud**: - Cursussen - Quizzen - Vragen - Oefenbestanden - Themas - (Uitrol) 

2. **Beveiliging**: - Gebruikers - Rollen 

3. **Profiel**: - Wachtwoord instellen 

### 3. Cursussen 
### 3.1 Startscherm voor beheren van cursussen 
Wanneer ik als gebruiker geklikt heb op het submenu-item “Cursussen” wordt het startscherm voor het 
beheren van cursussen getoond. 
 
Dit scherm toont cursussen gepagineerd (50 in een pagina) in een datagrid, aflopend gesorteerd op 
datum van creatie zodat de meest recente cursussen bovenaan getoond worden. 
De datagrid moet volgende kolommen tonen: Office applicatie naam, cursusnaam, instructietaal, 
gebuikersinterface taal, aantal onderliggende modules, aantal onderliggende topics. 
 
Er moet eender waar in een rij een rechtermuisklik uitgevoerd kunnen worden die een contextmenu 
zal tonen. De acties zijn “Nieuw”, “Details” en “Layout”. Verwijderen van een cursus is voorlopig niet 
toegelaten. Deze acties moeten ook gestart kunnen worden via knoppen op het scherm waarbij 
afhankelijk van de actie, eerst een rij geselecteerd moet zijn. 
 
Wanneer op een knop save gedrukt wordt moet alle wijzigingen bewaard worden. Als veiligheid moet 
de vraag ook gesteld worden als het scherm gesloten wordt. 
 
### 3.2 Details van een cursus 
Het detailscherm van een cursus toont alle eigenschappen van een cursus behalve de afgeleide 
gegevens (child records). Voor een bestaande cursus worden de gegevens ingeladen zodat deze 
indien gewenst gewijzigd kunnen worden. 
 
In geval het om een nieuwe cursus gaat moeten de invoervelden leeg zijn. De gebruiker moet bij het 
veld replicationkey een GUID invullen. Als dat niet gebeurt is bij het saven moet de app er een 
genereren. Voor het bepalen van het cursusicoon kan de gebruiker kiezen uit een lijst van reeds 
bestaande afbeeldingen of een afbeelding uploaden vanop het lokale bestandssysteem. De 
afbeeldingen moeten geupload worden naar de server naar een in configuratie opgegeven locatie.  
 
In  geval het om een bestaande cursus gaat mag de replicationkey niet meer aangepast worden!  
 
### 3.3 Layout van een cursus 
In het scherm voor de layout van een cursus moet de volledige layout van een cursus getoond worden 
in een boomstructuur. In deze boomstructuur moet het mogelijk zijn om de structuur van een cursus 
vorm te geven via volgende acties 
 
1. Modules toevoegen. Dit moet op verschillende manieren mogelijk zijn: 
- Via selectie van de rootnode (cursus) en druk op een knop of via rechtsklik. 
Langs deze weg wordt een module altijd helemaal onderaan de lijst van modules 
binnen de cursus toegevoegd. 
- Via selectie van een modulenode en druk op een knop. Hierdoor wordt de nieuwe 
module toegevoegd onder de geselecteerde module (maar op hetzelfde niveau) 
- Via rechtsklik op een modulenode waarbij er 2 opties zijn: “boven deze module 
invoegen” of “onder deze module invoegen”. 
2. Modulegegevens wijzigen 
- Via selectie + knop of via rechtsklik 
3. Module verwijderen 
- Via selectie + knop of via rechtsklik. Een module verwijderen zal ook alle 
onderliggende topics en koppelingen naar de topics verwijderen. 
OPGELET: enkel koppelingen, niet de effectieve definities van elementen binnen het 
topic. Dus geen quiz verwijderen die onder een topic hangt, maar wel de koppeling 
naar de quiz in het topic. 
4. Op eenzelfde manier moeten ook topics kunnen toegevoegd, gewijzigd of verwijderd worden. 
5. Het moet mogelijk zijn om de sortering van elementen aan te passen op elk specifiek niveau. 
Modules binnen een cursus, topics binnen een module, elementen binnen een topic. 
 
### 4. Quizzen 
### 4.1 Startscherm voor beheren van quizzen 
Dit scherm toont quizzen gepagineerd (50 in een pagina) in een datagrid, aflopend gesorteerd op 
datum van creatie zodat de meest recente quizzen bovenaan getoond worden. 
Standaard worden de quizzen gefilterd zodat de quizzen voor de Office applicatie Excel getoond 
worden. 
 
De datagrid moet volgende kolommen tonen: Office applicatie naam, identificatiecode, titel, 
instructietaal, gebuikersinterface taal, aantal onderliggende vragen. 
 
Er moet eender waar in een rij een rechtermuisklik uitgevoerd kunnen worden die een contextmenu 
zal tonen. De acties zijn “Nieuw” en “Details”. Verwijderen van een quiz is voorlopig niet toegelaten. 
Deze acties moeten ook gestart kunnen worden via knoppen op het scherm waarbij afhankelijk van de 
actie, eerst een rij geselecteerd moet zijn. 

Wanneer op een knop save gedrukt wordt moet alle wijzigingen bewaard worden. 
 
### 4.2 Details van een quiz 
Het detailscherm van een quiz moet zo goed als mogelijk de werking in Excel simuleren. 
Bij een vraag moet daarbij de mogelijkheid zijn om info te kunnen beheren omtrent: 
• Leerdoelen 
• Vereiste voorkennis 
• Vraag (EVA eigenschappen moeten nog niet voorzien worden) 
• Zoektermen mag (niet voorzien in ERD) maar moet nog niet 
• Informatie over oefenbestand 