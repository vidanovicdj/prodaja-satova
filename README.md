# Prodaja satova

Klijent-server aplikacija za evidenciju prodaje satova, izrađena u C# (.NET, Windows Forms) kao projekat iz predmeta **Projektovanje softvera** na Fakultetu organizacionih nauka.

Aplikacija omogućava prodavcima da vode evidenciju klijenata i satova i da izdaju račune, uz slojevitu arhitekturu koja razdvaja korisnički interfejs, aplikacionu logiku i pristup bazi podataka.

## Funkcionalnosti

- Prijava prodavca na sistem 
- Upravljanje klijentima (unos, pretraga, izmena, brisanje) 
- Upravljanje satovima 
- Kreiranje računa sa stavkama (račun može imati više stavki) 
- Evidencija sertifikata i kvalifikacija prodavaca

## Domenski model

| Entitet | Opis |
|---|---|
| `Prodavac` | zaposleni koji izdaje račune |
| `Sertifikat` | sertifikat koji prodavac može da poseduje |
| `KvalifikacijaProdavca` | veza između prodavca i sertifikata |
| `Klijent` | kupac |
| `TipKlijenta` | kategorija klijenta |
| `Sat` | artikal koji se prodaje |
| `Racun` | račun izdat klijentu |
| `StavkaRacuna` | pojedinačna stavka na računu |

## Arhitektura

Rešenje (`prodaja-satova.sln`) se sastoji od pet projekata:

| Projekat | Tip | Uloga |
|---|---|---|
| `Klijent` | Windows Forms | korisnički interfejs i komunikacija sa serverom |
| `Server` | Windows Forms | prihvatanje zahteva klijenata i pokretanje sistemskih operacija |
| `SistemskeOperacije` | Class Library | aplikaciona logika (jedna klasa po sistemskoj operaciji) |
| `DBBroker` | Class Library | pristup bazi podataka (SQL Server) |
| `Zajednicki` | Class Library | domenske klase i objekti koje dele klijent i server |

```
Klijent  ⇄  Server  →  SistemskeOperacije  →  DBBroker  →  SQL Server
              ↑
          Zajednicki (deljene klase)
```

Komunikacija između klijenta i servera ostvaruje se preko TCP soketa.

## Tehnologije

- C# / .NET 
- Windows Forms
- Microsoft SQL Server
- Visual Studio

## Pokretanje projekta

### Preduslovi
- Windows
- Visual Studio 2022 (sa .NET desktop workload-om)
- SQL Server (LocalDB ili SQL Server Express) i SQL Server Management Studio

### 1. Baza podataka
1. U SSMS-u napravi novu bazu `satovi`.
2. Izvrši skriptu `Baza/skripta.sql` da bi se kreirale tabele.

### 2. Konekcija
U fajlu `Broker.cs` podesi connection string prema svom okruženju.

Koristi se Windows autentifikacija, pa nisu potrebni korisničko ime i lozinka.

### 3. Pokretanje
1. Otvori `prodaja-satova.sln` u Visual Studio-u.
2. Pokreni projekat `Server` i pokreni server.
3. Pokreni projekat `Klijent` i prijavi se.

Preporučeno je da se u *Solution → Properties → Startup Project* izabere opcija **Multiple startup projects** (prvo `Server`, zatim `Klijent`).

## Autor
Đurđa Vidanović
