# .NET-Core-workshop-Verdande

Velkommen til workshop med Verdande og Knowit Experience! Her finner du instruksjoner til hvordan du får satt opp og kjørt en ny web applikasjon med .NET Core og C# på din lokale maskin. Videre, vil du få oppgaver som skal gjøre deg kjent med web applikasjonen. Temaet for workshoppen er musikk. Vi har satt opp en database som du skal hente data fra, og vise i applikasjonen din.

## Opprett et nytt prosjekt

1. Last ned [.NET Core SDK](https://www.microsoft.com/net/download/macos) - Software Development Kit

2. Åpne terminal hvis du har mac / linux, eller command prompt dersom du har Windows
3. Naviger deg til den mappen du ønsker å opprette prosjektet i, for eksempel til /Documents/git
4. Kjør følgende kommando for å opprette web applikasjonen:

```
dotnet new mvc <navn på applikasjon>
```

5. Naviger deg inn i prosjektet

```
cd <navn på applikasjon>
```

6. Start web applikasjonen:

```
dotnet run
```

7. Nå kan du se webapplikasjonen din kjøre på din lokale maskin:
http://localhost:5000

8. Bli kjent med applikasjonen ved å trykke deg gjennom fanene "Home", "About" og "Contact"


## Åpne prosjektet i Visual Studio Code

Videre skal vi se på selve koden for applikasjonen

1. Last ned [Visual studio code](https://code.visualstudio.com/)

1. Åpne Visual Studio Code

2. File >> Open >> Prosjektet ditt

3. Under mappen /Pages, ser du index, home og contact-filene


## Oppsett av database (TODO)

1. Last ned Workshop.db fra github repoet, og legg det i ditt eget prosjekt under /bin/Debug/netcoreapp2.0

2. Koble opp mot databasen


## Lag en ny side som heter "music"
// Her snakker vi om MVC-modellen, på white board

1. Opprett et view som heter "music.cshtml" under /Pages

```
/Pages/music.cshtml
```

2. 

## Authors

* **Lana Vu** - [Github](https://github.com/lanavu)
* **Kari Skjold** - [Github](https://github.com/kariskjold)
