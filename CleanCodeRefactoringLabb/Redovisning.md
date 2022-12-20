Redovisning refaktorisering 

Steg 1. 

Jag började med att bryta ut, och skapa klasser för dem olika metoder, som alla låg inne i main klassen. MakeGoal() och CheckBC() metoderna stoppade jag i en klass, vilket jag döpte till “Goals”. Ena metoden skapar målet, och den andra kollar gissning mot målet(bulls, cows). ShowToplist() stoppade jag också i en egen klass, “TopList”, osv... för dem andra metoderna.  

Steg 2. 

När metoderna var uppdelade, började jag kolla på namngivningar på variabler, metoder och klasser. Det fanns en hel del namngivningar att ändra på i många av metoderna, så här gjordes det några förbättringar. T ex inne i “PlayerData” klassen, ändrades variabeln “NGames” till “NumberOfGames”, och inne i Game klassen ändrades variableln “nGuess” till “numberOfGuesses” osv... 

Steg 3. 

Efter namngivning och uppdelning började jag kolla funktionaliteten i koden. Började med att bryta ut delar i metoderna, som kunde vara sin egen, vilka jag sedan kallade på istället. T ex SteamWriter som låg i spelet bröt jag ut och la i en annan klass, samt la den i en egen metod WriteScore(). Inne i ShowTopList() bröt jag ut foreach loopen, som displayar resultat till en egen method osv...  

Steg 4. 

Nu började jag att lägga till tester för några delar i koden, mest strängar. Såg till att testerna fungerade, genom att få dem att faila i början. Skapade allt fler tester allt eftersom jag kollade över koden. 

Steg 5.  

Här fortsatte jag att bryta ut allt mer, och dela upp funktionalitet i egna metoder, men även ta bort onödig kod. T ex inne i MakeGoal(), var det mycket onödig kod för att skapa ett slumpat nummer, så där tog jag bort ganska mycket kod. Inuti CheckBC fanns det två for-loopar, vilket jag tyckte var onödig så jag tog bort en, då den andra var överflödig. Liknande ändringar gjordes även i övriga metoder. 

 

Github-länk: https://github.com/Larsn280/Inlamningsuppgift-CleanCode/tree/Workbranch 

 

Skrivet av: Lars Norman 

2022-12-19 

 

 