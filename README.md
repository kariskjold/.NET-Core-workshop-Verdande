# .NET-Core-workshop-Verdande

Velkommen til workshop med Verdande og Knowit Experience! Her finner du instruksjoner til hvordan du får satt opp og kjørt en ny web applikasjon med .NET Core og C# på din lokale maskin. Videre, vil du få oppgaver som skal gjøre deg kjent med web applikasjonen. Temaet for workshoppen er musikk. Vi har satt opp en database som du skal hente data fra, og vise i applikasjonen din.

## Opprett et nytt prosjekt

1. Last ned [.NET Core SDK](https://www.microsoft.com/net/download/macos) - Software Development Kit

2. Åpne terminal hvis du har mac / linux, eller command prompt dersom du har Windows

3. Naviger deg til den mappen du ønsker å opprette prosjektet i, for eksempel til /Documents/git

4. Kjør følgende kommando for å opprette en web applikasjon som heter "music":

```
dotnet new mvc Music
```

5. Naviger deg inn i prosjektet

```
cd Music
```

6. Start web applikasjonen:

```
dotnet run
```

7. Nå kan du se webapplikasjonen din kjøre på din lokale maskin:
http://localhost:5000

> Trykk Ctrl + C, for å avslutte applikasjonen

8. Bli kjent med applikasjonen ved å trykke deg gjennom fanene "Home", "About" og "Contact"


## Åpne prosjektet i Visual Studio Code

Videre skal vi se på selve koden for applikasjonen

1. Last ned [Visual studio code](https://code.visualstudio.com/)

1. Åpne Visual Studio Code

2. Åpne prosjektet ditt i Visual Studio Code

```
File >> Open >> ... music
```

<!---Snakk om MVC-modellen på white board--->

Her ser du en MVC-struktur, med mappe for controllere, modeller og views. Naviger deg litt frem og tilbake mellom filene, for å bli kjent med strukturen.

## Opprett en ny side som heter "Playlist"

1. Naviger deg til mappen /Controllers, og opprett en ny fil som heter PlaylistController.cs

```
/Controllers/PlaylistController.cs
```

```csharp
using Microsoft.AspNetCore.Mvc;

namespace Music.Controllers
{
    public class PlaylistController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Playlist";
            return View();
        }
    }
}
```

2. Naviger deg til mappen /Views, og opprett en undermappe "Playlist" og under der; en fil "Index.cshtml".

```
/Views/Playlist/Index.cshtml
```

Dette blir viewet til den nye siden vi lager. Legg til en header med tittelen vi definerte i controlleren, og en paragraf med en valgfri tekst.

3. Naviger deg til partial viewet /Shared/_Layout.cshtml og legg til et nytt menypunkt i headeren som du kaller "Playlist"

<!--- asp-controller: music --->
<!--- asp-action: Index --->

4. Lagre alle filene og kjør prosjektet på nytt i terminal/command prompt

```
Ctrl + C
```

```
dotnet run
```

5. Se oppdateringene på http://localhost:5000

## Opprett en viewModel for Playlist

I "Playlist" ønsker vi et view der vi viser fram en spilleliste med tilhørende sanger. Spillelisten skal ha et navn. Vi begynner med å opprette en viewModel for Playlist. Under /Models ser dere et eksempel på en viewModel. 

1. Opprett en ny fil med en playlist viewModel som har egenskapen "Name" med getter og setter.

```
/Models/PlaylistViewModel.cs
```

2. Definer playlistViewModel som model i PlaylistController. Sett et navn til spillelisten, og send med modellen i det du returnerer viewet i Index-metoden.

3. Vis spillelistens navn i viewet

## Oppsett av data (TODO)

1. Last ned Workshop.db fra github repoet, og legg det i ditt eget prosjekt under /bin/Debug/netcoreapp2.0

2. Koble opp mot databasen

## Legg til data i viewet (TODO)

## Authors

* **Lana Vu** - [Github](https://github.com/lanavu)
* **Kari Skjold** - [Github](https://github.com/kariskjold)
