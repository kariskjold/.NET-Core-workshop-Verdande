# .NET-Core-workshop-Verdande

Velkommen til workshop med Verdande og Knowit Experience! Her finner du instruksjoner til hvordan du får satt opp og kjørt en ny web applikasjon med .NET Core og C# på din lokale maskin. Videre, vil du få oppgaver som skal gjøre deg kjent med web applikasjonen. Temaet for workshoppen er musikk. Vi har satt opp en database som du skal hente data fra, og vise i applikasjonen din.

## Opprett et nytt prosjekt

1. Last ned [.NET Core SDK](https://www.microsoft.com/net/download/macos) - Software Development Kit

2. Åpne terminal hvis du har mac / linux, eller command prompt dersom du har Windows

3. Naviger deg til den mappen du ønsker å opprette prosjektet i, for eksempel til /Documents/git

4. Kjør følgende kommando for å opprette en web applikasjon som heter "music":

```
dotnet new mvc music
```

5. Naviger deg inn i prosjektet

```
cd music
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


## Oppsett av data

1. Legg til Mockdata fra SampleTracks.cs

Last ned SampleTracks.cs og legg filen inn i rotmappen til prosjektet. Sjekk at filen inneholder riktig namespace. Det må være det samme som det du har kalt prosjektet ditt. 
Du får en track ved å kalle:
```csharp
new SampleTracks().GetTrackById(id);
```
Id er lagt inn som et løpenummer i listen av sanger. Den første sangen har Id=0.  

Du får en liste av tracks ved å kalle:

```csharp
new SampleTracks().GetAllTracks();
```

2. Opprett en TrackController og en TrackModel. 

```
/Controllers/TrackController.cs
```

```
/Models/Track.cs
```

Modellen brukes som et objekt som inneholder track-data. Modellen til Track skal inneholde følgende egenskaper:

|Type   | Name     |
|-------|----------|
|int    | Id       |
|string | Title    |
|string | Artist   |
|int    | NumPlays |

3. Opprett et View som heter Index.cshtml under Views/Track. 

```
/Views/Track/Index.cshtml
```
MVC vil lete i Views etter en mappe basert på kontrollernavnet. Hvis kontrolleren heter "TrackController" vil MVC automatisk lete etter mappen "Track" under Views for å finne tihørende Views. MVC vil deretter hente ut Views basert på metodenavnene i kontrolleren. Dersom vi har en metode som heter Index(), vil MVC lete etter Index.cshtml.

```csharp
public IActionResult Index()
        {
            ...
        }
```

I Index.cshtml ønsker vi å ta imot Track som modell. Et view tar imot en modell for å kunne vise data fra modellene. For å kunne vise Track-data i index.cshtml skriver vi følgende i Index.cshtml :

```
@model Track
```

Index.cshtml vil da vite at den skal ta imot Track-data. Vi kan da legge til:
```html
<h1>@Model.Title - @Model.Artist</h1>
```
Index.cshtml vil skrive ut Title og Artist fra modellen avhengig av hvilken Track-modell vi sender med. Ettersom vi har ca 30 tracks, har vi tilsvarende antall Track-modeller fordi vi trenger én Modell per track. 

For å kunne styre hvilken Track-modell som sendes til Index.cshtml, må vi gå inn i kontrolleren for å håndtere hvilken Track-modell som skal sendes når.

4. Legg til logikk i TrackController.

TrackController.cs bør se slik ut: 

```csharp
using Microsoft.AspNetCore.Mvc;
using music.Models;
using System;

namespace music.Controllers
{
    public class TrackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
```
`using` fungere på samme måte som `import` i java.

Vi ønsker å styre hvilken Track-modell som skal sendes med i "return View(Track-modell)". I modellen Track.cs har vi satt opp `Id` som en egenskap, og ønsker å styre det ved hjelp av denne verdien. Index() bør derfor ta imot en Id som parameter. 

Bruk GetTrackById(id) i SampleTracks for å returnere en Track basert på id: 

```csharp
new SampleTracks().GetTrackById(id);
```

5. Kjør applikasjonen, og sjekk om du får ut en Track basert på Id 1:

```
http://localhost:5000/Track/Index/1
```
 
## Model vs ViewModels





## Opprett en viewModel for Playlist

I "Playlist" ønsker vi et view der vi viser fram en spilleliste med tilhørende sanger. Spillelisten skal ha et navn. Vi begynner med å opprette en viewModel for Playlist. Under /Models ser dere et eksempel på en viewModel. 

1. Opprett en ny fil med en playlist viewModel som har egenskapen "Name" med getter og setter.

```
/Models/PlaylistViewModel.cs
```

2. Definer playlistViewModel som model i PlaylistController. Sett et navn til spillelisten, og send med modellen i det du returnerer viewet i Index-metoden.

3. Vis spillelistens navn i viewet



4. Bytt mellom ListView og GridView - lenker mellom og CSS-forklaringer (TODO Lana)

## Authors

* **Lana Vu** - [Github](https://github.com/lanavu)
* **Kari Skjold** - [Github](https://github.com/kariskjold)
